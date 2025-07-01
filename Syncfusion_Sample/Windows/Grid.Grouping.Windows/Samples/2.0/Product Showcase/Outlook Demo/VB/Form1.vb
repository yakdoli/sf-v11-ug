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

Imports System
Imports System.Xml
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Drawing
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms.Schedule

Imports System.Diagnostics

Namespace OutlookDemo
	#Region "Form"
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits RibbonForm
		#Region "Members"
		Private parentPanel As System.Windows.Forms.Panel
		Private WithEvents groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private listView1 As System.Windows.Forms.ListView
		Private groupBarItem4 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem5 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem6 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem7 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private mailPanel As System.Windows.Forms.Panel
		Private treeView3 As System.Windows.Forms.TreeView
		Private smallImageList As System.Windows.Forms.ImageList
		Private calendarPanel As System.Windows.Forms.Panel
		Private contactsPanel As System.Windows.Forms.Panel
		Private panel7 As System.Windows.Forms.Panel
		Private radioButton6 As System.Windows.Forms.RadioButton
		Private radioButton7 As System.Windows.Forms.RadioButton
		Private radioButton8 As System.Windows.Forms.RadioButton
		Private radioButton9 As System.Windows.Forms.RadioButton
		Private radioButton10 As System.Windows.Forms.RadioButton
		Private linkLabel4 As System.Windows.Forms.LinkLabel
		Private tasksPanel As System.Windows.Forms.Panel
		Private radioButton11 As System.Windows.Forms.RadioButton
		Private radioButton12 As System.Windows.Forms.RadioButton
		Private notesPanel As System.Windows.Forms.Panel
		Private panel9 As System.Windows.Forms.Panel
		Private radioButton13 As System.Windows.Forms.RadioButton
		Private radioButton14 As System.Windows.Forms.RadioButton
		Private radioButton15 As System.Windows.Forms.RadioButton
		Private radioButton16 As System.Windows.Forms.RadioButton
		Private radioButton17 As System.Windows.Forms.RadioButton
		Private linkLabel5 As System.Windows.Forms.LinkLabel
		Private linkLabel6 As System.Windows.Forms.LinkLabel
		Private treeView1 As System.Windows.Forms.TreeView
		Private linkLabel7 As System.Windows.Forms.LinkLabel
		Private linkLabel8 As System.Windows.Forms.LinkLabel
		Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private journalPanel As System.Windows.Forms.Panel
		Private panel14 As System.Windows.Forms.Panel
		Private radioButton18 As System.Windows.Forms.RadioButton
		Private radioButton19 As System.Windows.Forms.RadioButton
		Private radioButton20 As System.Windows.Forms.RadioButton
		Private radioButton21 As System.Windows.Forms.RadioButton
		Private radioButton22 As System.Windows.Forms.RadioButton
		Private linkLabel9 As System.Windows.Forms.LinkLabel
		Private linkLabel11 As System.Windows.Forms.LinkLabel
		Private components As System.ComponentModel.IContainer
		'private AxSHDocVw.AxWebBrowser Display;

		' Outlook Groups Add/Remove Implementation		
		Private htLabelToImageIndex As System.Collections.Hashtable = New Hashtable()
		Private clientPanel As System.Windows.Forms.Panel
		Private clientPanelImage As System.Windows.Forms.Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private clientPanelLabel2 As System.Windows.Forms.Label
		Private clientPanelLabel1 As System.Windows.Forms.Label
		Private gridContainerPanel As System.Windows.Forms.Panel
		Private restoreList As System.Collections.ArrayList = New ArrayList()
		Private splitter2 As System.Windows.Forms.Splitter
		Private panel16 As System.Windows.Forms.Panel
		Private Display As System.Windows.Forms.RichTextBox
		Private scheduleContainerPanel As System.Windows.Forms.Panel
		Private contactsGridPanel As System.Windows.Forms.Panel
		Private contactForm As ContactsPaneForm = Nothing
		Private calForm As CalendarForm = Nothing
		Private mailTaskBar As XPTaskBar
		Private WithEvents favouritesTaskBarBox As XPTaskBarBox
		Private WithEvents mailTaskBarBox As XPTaskBarBox
		Private gradientPanel2 As GradientPanel
		Private gradientPanel3 As GradientPanel
		Private xpTaskBar1 As XPTaskBar
		Private WithEvents myCalendarsTaskBarBox1 As XPTaskBarBox
		Private gradientPanel4 As GradientPanel
		Private checkBox1 As CheckBox
		Private checkBox2 As CheckBox
		Private panel11 As Panel
		Private linkLabel12 As LinkLabel
		Private linkLabel10 As LinkLabel
		Private linkLabel13 As LinkLabel
		Private linkLabel14 As LinkLabel
		Private linkLabel15 As LinkLabel
		Private linkLabel16 As LinkLabel
		Private linkLabel17 As LinkLabel
		Private gradientPanel5 As GradientPanel
		Private xpTaskBar2 As XPTaskBar
		Private WithEvents myContactsTaskBarBox As XPTaskBarBox
		Private WithEvents currentViewTaskBarBox As XPTaskBarBox
		Private panel2 As Panel
		Private WithEvents radioButton5 As RadioButton
		Private WithEvents radioButton4 As RadioButton
		Private WithEvents radioButton3 As RadioButton
		Private radioButton2 As RadioButton
		Private radioButton1 As RadioButton
		Private radioButton25 As RadioButton
		Private radioButton24 As RadioButton
		Private radioButton23 As RadioButton
		Private panel3 As Panel
		Private linkLabel1 As LinkLabel
		Private linkLabel2 As LinkLabel
		Private linkLabel18 As LinkLabel
		Private linkLabel19 As LinkLabel
		Private linkLabel3 As LinkLabel
		Private gradientPanel6 As GradientPanel
		Private xpTaskBar3 As XPTaskBar
		Private WithEvents mytasksTaskBarBox As XPTaskBarBox
		Private WithEvents currentViewTaskBarBox1 As XPTaskBarBox
		Private radioButton31 As RadioButton
		Private radioButton30 As RadioButton
		Private radioButton28 As RadioButton
		Private radioButton27 As RadioButton
		Private linkLabel20 As LinkLabel
		Private linkLabel21 As LinkLabel
		Private panel4 As Panel
		Private gradientPanel7 As GradientPanel
		Private xpTaskBar4 As XPTaskBar
		Private WithEvents notesTaskBarBox As XPTaskBarBox
		Private WithEvents currentViewTaskBarBox2 As XPTaskBarBox
		Private linkLabel22 As LinkLabel
		Private panel5 As Panel
		Private linkLabel23 As LinkLabel
		Private xpTaskBar5 As XPTaskBar
		Private WithEvents allFoldersTaskBarBox As XPTaskBarBox
		Private gradientPanel9 As GradientPanel
		Private panel1 As Panel
		Private panel6 As Panel
		Private gradientPanel10 As GradientPanel
		Private xpTaskBar6 As XPTaskBar
		Private WithEvents myJournalTaskBarBox As XPTaskBarBox
		Private WithEvents currentViewTaskBarBox3 As XPTaskBarBox
		Private radioButton29 As RadioButton
		Private radioButton26 As RadioButton
		Private linkLabel25 As LinkLabel
		Private linkLabel24 As LinkLabel
		Private splitContainer1 As SplitContainer
		Private folderlistPanel As Panel
		Private gradientPanel8 As GradientPanel
		Private panel8 As Panel
		Private statusStripEx1 As StatusStripEx
		Private toolStripStatusLabel1 As ToolStripStatusLabel
		Private splashControl1 As SplashControl
		Private ribbonControlAdv1 As RibbonControlAdv
		Private toolStripEx1 As ToolStripEx
		Private toolStripPanelItem1 As ToolStripPanelItem
		Private toolStripButton1 As ToolStripButton
		Private toolStripButton2 As ToolStripButton
		Private toolStripEx2 As ToolStripEx
		Private toolStripPanelItem2 As ToolStripPanelItem
		Private toolStripButton3 As ToolStripButton
		Private toolStripButton4 As ToolStripButton
		Private toolStripButton5 As ToolStripButton
		Private toolStripButton6 As ToolStripButton
		Private toolStripLabel1 As ToolStripLabel
		Private toolStripEx3 As ToolStripEx
		Private toolStripPanelItem3 As ToolStripPanelItem
		Private toolStripButton7 As ToolStripButton
		Private toolStripButton10 As ToolStripButton
		Private toolStripPanelItem4 As ToolStripPanelItem
		Private toolStripButton8 As ToolStripButton
		Private toolStripButton9 As ToolStripButton
		Private toolStripEx4 As ToolStripEx
		Private toolStripPanelItem5 As ToolStripPanelItem
		Private toolStripButton11 As ToolStripButton
		Private toolStripButton12 As ToolStripButton
		Private WithEvents toolbtnswitch As ToolStripButton
		Private toolStripStyle As ToolStripTabItem
		Private toolStripFile As ToolStripTabItem
		Private toolStripEdit As ToolStripTabItem
		Private toolStripView As ToolStripTabItem
		Private toolStripGo As ToolStripTabItem
		Private toolStripAction As ToolStripTabItem
		Private toolStripFileNew As ToolStripEx
		Private toolStripNewPanel As ToolStripPanelItem
		Private WithEvents toolbtnmailMessage As ToolStripButton
		Private WithEvents toolbtnappointment As ToolStripButton
		Private WithEvents toolbtncontact As ToolStripButton
		Private toolbtntask As ToolStripButton
		Private toolbtnjournal As ToolStripButton
		Private toolbtnnotes As ToolStripButton
		Private toolStripFileSearch As ToolStripEx
		Private toolStripSearchPanel As ToolStripPanelItem
		Private toolbtnfolder As ToolStripButton
		Private toolbtnsearch As ToolStripButton
		Private toolStripFilePage As ToolStripEx
		Private toolStripPagePanel As ToolStripPanelItem
		Private toolbtnpreview As ToolStripButton
		Private toolbtnprint As ToolStripButton
		Private toolStripFileHelp As ToolStripEx
		Private toolStripHelpPanel As ToolStripPanelItem
		Private WithEvents toolbtnhelp As ToolStripButton
		Private WithEvents toolbtnabout As ToolStripButton
		Private toolStripEditAction As ToolStripEx
		Private toolStripActionPanel As ToolStripPanelItem
		Private toolbtnundo As ToolStripButton
		Private toolbtnredo As ToolStripButton
		Private toolStripEditClipBoard As ToolStripEx
		Private toolStripClipbdPanel As ToolStripPanelItem
		Private toolbtncopy As ToolStripButton
		Private toolbtncut As ToolStripButton
		Private toolStripClipbd2Panel As ToolStripPanelItem
		Private toolbtnclipboard As ToolStripButton
		Private toolbtnpaste As ToolStripButton
		Private toolStripEditDelete As ToolStripEx
		Private toolStripDeletePanel As ToolStripPanelItem
		Private toolbtndel As ToolStripButton
		Private toolbtnundel As ToolStripButton
		Private toolStripEditDelete2 As ToolStripPanelItem
		Private toolbtnmove As ToolStripButton
		Private toolbtncopyto As ToolStripButton
		Private toolStripViewArrange As ToolStripEx
		Private toolStripButton14 As ToolStripButton
		Private toolStripViewSwitch As ToolStripEx
		Private toolStripViewExp As ToolStripEx
		Private toolStripGoItems As ToolStripEx
		Private toolStripGoItemsPanel As ToolStripPanelItem
		Private WithEvents toolbtnmail As ToolStripButton
		Private WithEvents toolbtncalndr As ToolStripButton
		Private WithEvents toolbtncnt As ToolStripButton
		Private WithEvents toolbtntasks As ToolStripButton
		Private WithEvents toolbtnGonote As ToolStripButton
		Private toolStripGoMisc As ToolStripEx
		Private toolStripGoMiscPanel As ToolStripPanelItem
		Private WithEvents toolbtnfolderlist As ToolStripButton
		Private WithEvents toolbtnGojournal As ToolStripButton
		Private toolStripActionsMail As ToolStripEx
		Private toolStripActionMailPanel As ToolStripPanelItem
		Private toolbtnActionmail As ToolStripButton
		Private toolbtnJunk As ToolStripButton
		Private toolStripActionRespond As ToolStripEx
		Private toolbtnreply As ToolStripButton
		Private toolbtnreplyall As ToolStripButton
		Private toolbtnfwd As ToolStripButton
		Private toolStripStyles As ToolStripEx
		Private WithEvents toolbtnstyleBlue As ToolStripButton
		Private WithEvents toolbtnstyleBlack As ToolStripButton
		Private WithEvents toolbtnstyleSilver As ToolStripButton
		Private toolStripSeparator2 As ToolStripSeparator
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripSeparator3 As ToolStripSeparator
		Private toolStripSeparator4 As ToolStripSeparator
		Private WithEvents toolbtnexit As ToolStripButton
		Private toolStripEx5 As ToolStripEx
		Private toolStripReadPane As ToolStripPanelItem
		Private WithEvents toolbtnRight As ToolStripButton
		Private WithEvents toolbtnBottom As ToolStripButton
		Private WithEvents toolbtnTop As ToolStripButton
		Private toolStripViewSwitchPanel As ToolStripPanelItem
		Private WithEvents toolchknav As ToolStripCheckBox
		Private WithEvents toolbtnautoprev As ToolStripCheckBox
		Private backStageTab2 As BackStageTab
		Private pictureBox2 As PictureBox
		Private backStageTab3 As BackStageTab
		Private pictureBox3 As PictureBox
		Private backStageButton1 As BackStageButton
		Private WithEvents backStageButton2 As BackStageButton
		Private backStage1 As BackStage
		Private backStageTab1 As BackStageTab
		Private pictureBox1 As PictureBox
		Private backStageTab4 As BackStageTab
		Private pictureBox4 As PictureBox
		Private backStageTab5 As BackStageTab
		Private pictureBox5 As PictureBox
		Private WithEvents backStageButton3 As BackStageButton
		Private WithEvents backStageButton4 As BackStageButton
		Private backStageView1 As BackStageView
		Private toolStripViewExpand As ToolStripPanelItem
		Private WithEvents toolbtnExpAllGroup As ToolStripButton
		Private WithEvents toolbtnCollapse As ToolStripButton
		Private WithEvents toolbtnExpthisGroup As ToolStripButton
		Private toolStripSeparator5 As ToolStripSeparator
		Private toolStripPanelItem6 As ToolStripPanelItem
		Private toolbtnMeeting As ToolStripButton
		Private toolbtnMore As ToolStripButton

		Private gridGroupingPanel As OutlookDemo.GroupingPanel

		#End Region

		#Region "Properties"
		Public ReadOnly Property GroupBarControl() As GroupBar
			Get
				Return Me.groupBar1
			End Get
		End Property

		Public ReadOnly Property ItemStateStore() As IEnumerator
			Get
				Return Me.restoreList.GetEnumerator()
			End Get
		End Property

		#End Region

		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			Me.splashControl1.SplashControlPanel.BorderType = SplashBorderType.None
			Me.splashControl1.ShowDialogSplash(Me)

'			#Region "Settings"

			Dim clrDefault() As Color = { Color.FromArgb(192,219,255), Color.FromArgb(188,217,255), Color.FromArgb(184,215,255), Color.FromArgb(181,213,255), Color.FromArgb(177,211,255), Color.FromArgb(173,209,255), Color.FromArgb(198,222,255), Color.FromArgb(204,225,255), Color.FromArgb(210,229,255), Color.FromArgb(215,232,255), Color.FromArgb(221,236,255), Color.FromArgb(227,239,255) }
			Me.Display.Hide()
			scheduleContainerPanel.Hide()
			contactsGridPanel.Hide()

			' Set the 1 and 3 monthAdv instances in the Calendar panel to the previous and next month

			Me.treeView1.ExpandAll()
			Me.treeView3.ExpandAll()

			' Initialize the htLabelToImageIndex map - the index refers to the icon position in the smallImageList
			Me.htLabelToImageIndex.Add("Mail", 2)
			Me.htLabelToImageIndex.Add("Calendar", 12)
			Me.htLabelToImageIndex.Add("Contacts", 9)
			Me.htLabelToImageIndex.Add("Tasks", 10)
			Me.htLabelToImageIndex.Add("Notes", 11)
			Me.htLabelToImageIndex.Add("Folder List", 3)
			Me.htLabelToImageIndex.Add("Journal", 13)

			' The restoreList is used by the OptionsForm Restore functionality to restore the GroupBarItems to the state set in the designer.
			For Each item As GroupBarItem In Me.groupBar1.GroupBarItems
				Me.restoreList.Add(New GroupBarItemState(item.Text, item.InNavigationPane, item.Visible))
			Next item

			Me.InitializeGroupBarClientColors()

			' Set the text for the ClientPanel labels
			Dim selitem As GroupBarItem = Me.groupBar1.GroupBarItems(Me.groupBar1.SelectedItem)
			Me.clientPanelLabel1.Text = "Inbox"
			Me.clientPanelLabel2.Text = String.Empty
			Me.clientPanelImage.ImageIndex = CInt(Fix(Me.htLabelToImageIndex(selitem.Text)))

			' Create the GroupingPanel instance that contains the grouped Essential Grid and add it to the form's placeholder Panel
			Me.gridGroupingPanel = New GroupingPanel()
			Me.gridContainerPanel.Controls.Add(Me.gridGroupingPanel)
			Me.gridGroupingPanel.Dock = DockStyle.Fill

			Me.contactForm = New ContactsPaneForm()
			Me.contactsGridPanel.Controls.Add(contactForm)
			Me.contactForm.Dock = DockStyle.Fill
			Me.contactForm.BringToFront()

			Me.calForm = New CalendarForm()
			Me.scheduleContainerPanel.Controls.Add(calForm)
			Me.calForm.Dock = DockStyle.Fill

			AddHandler Closing, AddressOf Form1_Closing
			AddHandler gridGroupingPanel.Grid.TableControl.Model.SelectionChanging, AddressOf Model_SelectionChanging
			'this.barItem47.PerformClick();
			AddHandler groupBar1.GroupBarItemSelectionChanging, AddressOf groupBar1_GroupBarItemSelectionChanging
			Me.toolStripStatusLabel1.Text = Me.gridGroupingPanel.Grid.Table.Records.Count.ToString() & " Messages"

			AddHandler gridGroupingPanel.Grid.Table.RecordDeleted, AddressOf Table_RecordDeleted
			AddHandler mailTaskBar.SizeChanged, AddressOf mailTaskBar_SizeChanged
			SetGradientColors()
			Me.groupBar1.HeaderForeColor = Color.MidnightBlue

			Me.splitContainer1.Dock = DockStyle.Fill
			Me.splitContainer1.BringToFront()
'			#End Region

			Me.gridContainerPanel.Height = 325
			Me.gridContainerPanel.Dock = DockStyle.Top
			Me.splitter2.Dock = DockStyle.Top
			Me.panel16.Dock = DockStyle.Fill
			Me.panel16.Show()
			Me.groupBar1.SelectedItem = 0
			SetBackGroundTheme()
		End Sub

		#Region "Helper Methods"

		Private Sub SetGradientColors()
			Office2003Colors.GroupBarHeaderColorDark = Color.FromArgb(175, 210, 255)
			Office2003Colors.GroupBarHeaderColorLight = Color.FromArgb(227, 239, 255)
			Office2003Colors.GroupBarItemTextColor = Color.MidnightBlue
			Office2003Colors.GroupBarHighlightColorDark = Color.FromArgb(255, 215, 103)
			Office2003Colors.GroupBarHighlightColorLight = Color.FromArgb(255, 254, 228)
			Office2003Colors.GroupBarSelectedColorDark = Color.FromArgb(251, 140, 60)
			Office2003Colors.GroupBarSelectedColorLight = Color.FromArgb(255, 211, 101)
			Office2003Colors.SeparatorColor = Color.FromArgb(101, 147, 207)
		End Sub

		' Sets the Office2003 colors for the GroupBar's client controls
		Private Sub InitializeGroupBarClientColors()
			Office2003Colors.UpdateMenuColors()
		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n
			Return bitmapName
		End Function
		#End Region

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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
			Dim treeNode17 As New System.Windows.Forms.TreeNode("InBox", 2, 2)
			Dim treeNode18 As New System.Windows.Forms.TreeNode("OutBox", 3, 3)
			Dim treeNode19 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode20 As New System.Windows.Forms.TreeNode("Public")
			Dim treeNode21 As New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() { treeNode16, treeNode17, treeNode18, treeNode19, treeNode20})
			Dim treeNode22 As New System.Windows.Forms.TreeNode("For Follow Up", 4, 4)
			Dim treeNode23 As New System.Windows.Forms.TreeNode("Large Mail", 4, 4)
			Dim treeNode24 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4, New System.Windows.Forms.TreeNode() { treeNode22, treeNode23})
			Dim treeNode25 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode26 As New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
			Dim treeNode27 As New System.Windows.Forms.TreeNode("Inbox", 2, 2)
			Dim treeNode28 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode29 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode30 As New System.Windows.Forms.TreeNode("Personal Folders", 7, 7, New System.Windows.Forms.TreeNode() { treeNode25, treeNode26, treeNode27, treeNode28, treeNode29})
			Dim treeNode31 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode32 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode33 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode34 As New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() { treeNode31, treeNode32, treeNode33})
			Dim treeNode35 As New System.Windows.Forms.TreeNode("Drafts", 5, 5)
			Dim treeNode36 As New System.Windows.Forms.TreeNode("Inbox", 2, 2)
			Dim treeNode37 As New System.Windows.Forms.TreeNode("Outbox", 3, 3)
			Dim treeNode38 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode39 As New System.Windows.Forms.TreeNode("Public")
			Dim treeNode40 As New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() { treeNode35, treeNode36, treeNode37, treeNode38, treeNode39})
			Dim listViewItem1 As New System.Windows.Forms.ListViewItem(New String() { "ListViewItem0"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem2 As New System.Windows.Forms.ListViewItem(New String() { "ListViewItem1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem3 As New System.Windows.Forms.ListViewItem(New String() { "ListViewItem2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem4 As New System.Windows.Forms.ListViewItem(New String() { "ListViewItem3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem5 As New System.Windows.Forms.ListViewItem(New String() { "ListViewItem4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Me.parentPanel = New System.Windows.Forms.Panel()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.contactsPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar2 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.myContactsTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.smallImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.currentViewTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.radioButton25 = New System.Windows.Forms.RadioButton()
			Me.radioButton5 = New System.Windows.Forms.RadioButton()
			Me.radioButton24 = New System.Windows.Forms.RadioButton()
			Me.radioButton4 = New System.Windows.Forms.RadioButton()
			Me.radioButton23 = New System.Windows.Forms.RadioButton()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.linkLabel18 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel19 = New System.Windows.Forms.LinkLabel()
			Me.journalPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel10 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel8 = New System.Windows.Forms.Panel()
			Me.linkLabel25 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar6 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.myJournalTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.currentViewTaskBarBox3 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel14 = New System.Windows.Forms.Panel()
			Me.radioButton29 = New System.Windows.Forms.RadioButton()
			Me.radioButton18 = New System.Windows.Forms.RadioButton()
			Me.radioButton26 = New System.Windows.Forms.RadioButton()
			Me.radioButton19 = New System.Windows.Forms.RadioButton()
			Me.radioButton20 = New System.Windows.Forms.RadioButton()
			Me.radioButton21 = New System.Windows.Forms.RadioButton()
			Me.radioButton22 = New System.Windows.Forms.RadioButton()
			Me.linkLabel24 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel11 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel9 = New System.Windows.Forms.LinkLabel()
			Me.folderlistPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel8 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.linkLabel7 = New System.Windows.Forms.LinkLabel()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.linkLabel8 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar5 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.allFoldersTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel9 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.treeView1 = New System.Windows.Forms.TreeView()
			Me.calendarPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.linkLabel10 = New System.Windows.Forms.LinkLabel()
			Me.panel11 = New System.Windows.Forms.Panel()
			Me.linkLabel12 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel13 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.myCalendarsTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.linkLabel14 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel17 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel15 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel16 = New System.Windows.Forms.LinkLabel()
			Me.mailPanel = New System.Windows.Forms.Panel()
			Me.mailTaskBar = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.favouritesTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.mailTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.treeView3 = New System.Windows.Forms.TreeView()
			Me.notesPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel7 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.linkLabel22 = New System.Windows.Forms.LinkLabel()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.linkLabel23 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar4 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.notesTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.currentViewTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel9 = New System.Windows.Forms.Panel()
			Me.radioButton13 = New System.Windows.Forms.RadioButton()
			Me.radioButton14 = New System.Windows.Forms.RadioButton()
			Me.radioButton15 = New System.Windows.Forms.RadioButton()
			Me.radioButton16 = New System.Windows.Forms.RadioButton()
			Me.radioButton17 = New System.Windows.Forms.RadioButton()
			Me.linkLabel5 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel6 = New System.Windows.Forms.LinkLabel()
			Me.tasksPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel6 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.linkLabel20 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar3 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.mytasksTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.currentViewTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel7 = New System.Windows.Forms.Panel()
			Me.radioButton31 = New System.Windows.Forms.RadioButton()
			Me.radioButton30 = New System.Windows.Forms.RadioButton()
			Me.radioButton28 = New System.Windows.Forms.RadioButton()
			Me.radioButton27 = New System.Windows.Forms.RadioButton()
			Me.radioButton12 = New System.Windows.Forms.RadioButton()
			Me.radioButton11 = New System.Windows.Forms.RadioButton()
			Me.radioButton6 = New System.Windows.Forms.RadioButton()
			Me.radioButton7 = New System.Windows.Forms.RadioButton()
			Me.radioButton8 = New System.Windows.Forms.RadioButton()
			Me.radioButton9 = New System.Windows.Forms.RadioButton()
			Me.radioButton10 = New System.Windows.Forms.RadioButton()
			Me.linkLabel21 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel4 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel3 = New System.Windows.Forms.LinkLabel()
			Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem7 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem4 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem5 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem6 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.clientPanel = New System.Windows.Forms.Panel()
			Me.panel16 = New System.Windows.Forms.Panel()
			Me.Display = New System.Windows.Forms.RichTextBox()
			Me.splitter2 = New System.Windows.Forms.Splitter()
			Me.gridContainerPanel = New System.Windows.Forms.Panel()
			Me.scheduleContainerPanel = New System.Windows.Forms.Panel()
			Me.contactsGridPanel = New System.Windows.Forms.Panel()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.clientPanelImage = New System.Windows.Forms.Label()
			Me.clientPanelLabel1 = New System.Windows.Forms.Label()
			Me.clientPanelLabel2 = New System.Windows.Forms.Label()
			Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx()
			Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.splashControl1 = New Syncfusion.Windows.Forms.Tools.SplashControl()
			Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
			Me.backStageView1 = New Syncfusion.Windows.Forms.BackStageView(Me.components)
			Me.backStage1 = New Syncfusion.Windows.Forms.BackStage()
			Me.backStageTab1 = New Syncfusion.Windows.Forms.BackStageTab()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.backStageTab4 = New Syncfusion.Windows.Forms.BackStageTab()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.backStageTab5 = New Syncfusion.Windows.Forms.BackStageTab()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.backStageButton3 = New Syncfusion.Windows.Forms.BackStageButton()
			Me.backStageButton4 = New Syncfusion.Windows.Forms.BackStageButton()
			Me.toolStripFile = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripFileNew = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripNewPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnmailMessage = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnappointment = New System.Windows.Forms.ToolStripButton()
			Me.toolbtncontact = New System.Windows.Forms.ToolStripButton()
			Me.toolbtntask = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnjournal = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnnotes = New System.Windows.Forms.ToolStripButton()
			Me.toolStripFileSearch = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripSearchPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnfolder = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnsearch = New System.Windows.Forms.ToolStripButton()
			Me.toolStripFilePage = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPagePanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnpreview = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnprint = New System.Windows.Forms.ToolStripButton()
			Me.toolStripFileHelp = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripHelpPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnhelp = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnabout = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnexit = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEdit = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEditAction = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripActionPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnundo = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnredo = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEditClipBoard = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripClipbdPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtncopy = New System.Windows.Forms.ToolStripButton()
			Me.toolbtncut = New System.Windows.Forms.ToolStripButton()
			Me.toolStripClipbd2Panel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnclipboard = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnpaste = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEditDelete = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDeletePanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtndel = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnundel = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEditDelete2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnmove = New System.Windows.Forms.ToolStripButton()
			Me.toolbtncopyto = New System.Windows.Forms.ToolStripButton()
			Me.toolStripView = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripViewArrange = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripViewSwitch = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripViewSwitchPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolchknav = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
			Me.toolbtnautoprev = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
			Me.toolStripViewExp = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripViewExpand = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnExpAllGroup = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnCollapse = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnExpthisGroup = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx5 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripReadPane = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnRight = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnBottom = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnTop = New System.Windows.Forms.ToolStripButton()
			Me.toolStripGo = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripGoItems = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripGoItemsPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnmail = New System.Windows.Forms.ToolStripButton()
			Me.toolbtncalndr = New System.Windows.Forms.ToolStripButton()
			Me.toolbtncnt = New System.Windows.Forms.ToolStripButton()
			Me.toolbtntasks = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnGonote = New System.Windows.Forms.ToolStripButton()
			Me.toolStripGoMisc = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripGoMiscPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnfolderlist = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnGojournal = New System.Windows.Forms.ToolStripButton()
			Me.toolStripAction = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripActionsMail = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripActionMailPanel = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnActionmail = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnJunk = New System.Windows.Forms.ToolStripButton()
			Me.toolStripActionRespond = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolbtnreply = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolbtnreplyall = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolbtnfwd = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolbtnMeeting = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnMore = New System.Windows.Forms.ToolStripButton()
			Me.toolStripStyle = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripStyles = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolbtnstyleBlue = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolbtnstyleBlack = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolbtnstyleSilver = New System.Windows.Forms.ToolStripButton()
			Me.toolbtnswitch = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton()
			Me.backStageTab2 = New Syncfusion.Windows.Forms.BackStageTab()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.backStageTab3 = New Syncfusion.Windows.Forms.BackStageTab()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.backStageButton1 = New Syncfusion.Windows.Forms.BackStageButton()
			Me.backStageButton2 = New Syncfusion.Windows.Forms.BackStageButton()
			Me.parentPanel.SuspendLayout()
			'((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBar1.SuspendLayout()
			Me.contactsPanel.SuspendLayout()
			CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel5.SuspendLayout()
			CType(Me.xpTaskBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar2.SuspendLayout()
			Me.currentViewTaskBarBox.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.journalPanel.SuspendLayout()
			CType(Me.gradientPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel10.SuspendLayout()
			CType(Me.xpTaskBar6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar6.SuspendLayout()
			Me.currentViewTaskBarBox3.SuspendLayout()
			Me.panel14.SuspendLayout()
			Me.folderlistPanel.SuspendLayout()
			CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel8.SuspendLayout()
			Me.panel6.SuspendLayout()
			CType(Me.xpTaskBar5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar5.SuspendLayout()
			Me.allFoldersTaskBarBox.SuspendLayout()
			CType(Me.gradientPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel9.SuspendLayout()
			Me.calendarPanel.SuspendLayout()
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel3.SuspendLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			Me.myCalendarsTaskBarBox1.SuspendLayout()
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel4.SuspendLayout()
			Me.mailPanel.SuspendLayout()
			CType(Me.mailTaskBar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mailTaskBar.SuspendLayout()
			Me.mailTaskBarBox.SuspendLayout()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel2.SuspendLayout()
			Me.notesPanel.SuspendLayout()
			CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel7.SuspendLayout()
			CType(Me.xpTaskBar4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar4.SuspendLayout()
			Me.currentViewTaskBarBox2.SuspendLayout()
			Me.panel9.SuspendLayout()
			Me.tasksPanel.SuspendLayout()
			CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel6.SuspendLayout()
			CType(Me.xpTaskBar3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar3.SuspendLayout()
			Me.currentViewTaskBarBox1.SuspendLayout()
			Me.panel7.SuspendLayout()
			Me.clientPanel.SuspendLayout()
			Me.panel16.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.statusStripEx1.SuspendLayout()
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ribbonControlAdv1.SuspendLayout()
			CType(Me.backStage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backStage1.SuspendLayout()
			Me.backStageTab1.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backStageTab4.SuspendLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backStageTab5.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolStripFile.Panel.SuspendLayout()
			Me.toolStripFileNew.SuspendLayout()
			Me.toolStripFileSearch.SuspendLayout()
			Me.toolStripFilePage.SuspendLayout()
			Me.toolStripFileHelp.SuspendLayout()
			Me.toolStripEdit.Panel.SuspendLayout()
			Me.toolStripEditAction.SuspendLayout()
			Me.toolStripEditClipBoard.SuspendLayout()
			Me.toolStripEditDelete.SuspendLayout()
			Me.toolStripView.Panel.SuspendLayout()
			Me.toolStripViewArrange.SuspendLayout()
			Me.toolStripViewSwitch.SuspendLayout()
			Me.toolStripViewExp.SuspendLayout()
			Me.toolStripEx5.SuspendLayout()
			Me.toolStripGo.Panel.SuspendLayout()
			Me.toolStripGoItems.SuspendLayout()
			Me.toolStripGoMisc.SuspendLayout()
			Me.toolStripAction.Panel.SuspendLayout()
			Me.toolStripActionsMail.SuspendLayout()
			Me.toolStripActionRespond.SuspendLayout()
			Me.toolStripStyle.Panel.SuspendLayout()
			Me.toolStripStyles.SuspendLayout()
			Me.toolStripEx1.SuspendLayout()
			Me.toolStripEx2.SuspendLayout()
			Me.toolStripEx3.SuspendLayout()
			Me.toolStripEx4.SuspendLayout()
			Me.backStageTab2.SuspendLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backStageTab3.SuspendLayout()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' parentPanel
			' 
			Me.parentPanel.Controls.Add(Me.splitContainer1)
			Me.parentPanel.Controls.Add(Me.statusStripEx1)
			Me.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.parentPanel.Location = New System.Drawing.Point(6, 157)
			Me.parentPanel.Name = "parentPanel"
			Me.parentPanel.Size = New System.Drawing.Size(862, 579)
			Me.parentPanel.TabIndex = 4
			' 
			' splitContainer1
			' 
			Me.splitContainer1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(189))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(252))))))
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.groupBar1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.clientPanel)
			Me.splitContainer1.Size = New System.Drawing.Size(862, 579)
			Me.splitContainer1.SplitterDistance = 169
			Me.splitContainer1.TabIndex = 1002
			' 
			' groupBar1
			' 
			Me.groupBar1.AllowDrop = True
			Me.groupBar1.AnimatedSelection = False
			Me.groupBar1.BackColor = System.Drawing.SystemColors.Control
			Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBar1.Controls.Add(Me.contactsPanel)
			Me.groupBar1.Controls.Add(Me.journalPanel)
			Me.groupBar1.Controls.Add(Me.folderlistPanel)
			Me.groupBar1.Controls.Add(Me.calendarPanel)
			Me.groupBar1.Controls.Add(Me.mailPanel)
			Me.groupBar1.Controls.Add(Me.notesPanel)
			Me.groupBar1.Controls.Add(Me.tasksPanel)
			Me.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupBar1.ExpandButtonToolTip = Nothing
			Me.groupBar1.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold)
			Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.GroupBarDropDownToolTip = Nothing
			Me.groupBar1.GroupBarItemCursor = System.Windows.Forms.Cursors.Hand
			Me.groupBar1.GroupBarItemHeight = 32
			Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem1, Me.groupBarItem7, Me.groupBarItem3, Me.groupBarItem4, Me.groupBarItem5, Me.groupBarItem6, Me.groupBarItem2})
			Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.IndexOnVisibleItems = True
			Me.groupBar1.Location = New System.Drawing.Point(0, 0)
			Me.groupBar1.MinimizeButtonToolTip = Nothing
			Me.groupBar1.Name = "groupBar1"
			Me.groupBar1.NavigationPaneTooltip = Nothing
			Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.groupBar1.SelectedItem = 2
			Me.groupBar1.Size = New System.Drawing.Size(169, 579)
			Me.groupBar1.StackedMode = True
			Me.groupBar1.TabIndex = 0
			Me.groupBar1.Text = "groupBar1"
			Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.groupBar1.GroupBarItemSelected += New System.EventHandler(Me.groupBar1_GroupBarItemSelected)
'			Me.groupBar1.NavigationPaneDropDownClick += New Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventHandler(Me.groupBar1_NavigationPaneDropDownClick)
			' 
			' contactsPanel
			' 
			Me.contactsPanel.Controls.Add(Me.gradientPanel5)
			Me.contactsPanel.Location = New System.Drawing.Point(1, 27)
			Me.contactsPanel.Name = "contactsPanel"
			Me.contactsPanel.Size = New System.Drawing.Size(167, 289)
			Me.contactsPanel.TabIndex = 1
			' 
			' gradientPanel5
			' 
			Me.gradientPanel5.BackColor = System.Drawing.Color.White
			Me.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel5.Controls.Add(Me.linkLabel1)
			Me.gradientPanel5.Controls.Add(Me.panel3)
			Me.gradientPanel5.Controls.Add(Me.linkLabel2)
			Me.gradientPanel5.Controls.Add(Me.xpTaskBar2)
			Me.gradientPanel5.Controls.Add(Me.linkLabel18)
			Me.gradientPanel5.Controls.Add(Me.linkLabel19)
			Me.gradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel5.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel5.Name = "gradientPanel5"
			Me.gradientPanel5.Size = New System.Drawing.Size(167, 289)
			Me.gradientPanel5.TabIndex = 0
			' 
			' linkLabel1
			' 
			Me.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel1.AutoSize = True
			Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel1.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel1.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel1.Location = New System.Drawing.Point(9, 264)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New System.Drawing.Size(125, 14)
			Me.linkLabel1.TabIndex = 1003
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "Open Shared Contacts..."
			Me.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel3.Location = New System.Drawing.Point(0, 253)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(167, 5)
			Me.panel3.TabIndex = 1
			' 
			' linkLabel2
			' 
			Me.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel2.AutoSize = True
			Me.linkLabel2.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel2.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel2.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel2.Location = New System.Drawing.Point(9, 282)
			Me.linkLabel2.Name = "linkLabel2"
			Me.linkLabel2.Size = New System.Drawing.Size(140, 14)
			Me.linkLabel2.TabIndex = 1004
			Me.linkLabel2.TabStop = True
			Me.linkLabel2.Text = "Share My Contacts Folder..."
			Me.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' xpTaskBar2
			' 
			Me.xpTaskBar2.BackColor = System.Drawing.Color.White
			Me.xpTaskBar2.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar2.Controls.Add(Me.myContactsTaskBarBox)
			Me.xpTaskBar2.Controls.Add(Me.currentViewTaskBarBox)
			Me.xpTaskBar2.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskBar2.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar2.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar2.Name = "xpTaskBar2"
			Me.xpTaskBar2.Size = New System.Drawing.Size(167, 253)
			Me.xpTaskBar2.TabIndex = 0
			' 
			' myContactsTaskBarBox
			' 
			Me.myContactsTaskBarBox.BackColor = System.Drawing.SystemColors.Control
			Me.myContactsTaskBarBox.DrawFocusRect = False
			Me.myContactsTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.myContactsTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.myContactsTaskBarBox.HeaderImageIndex = -1
			Me.myContactsTaskBarBox.HitTaskBoxArea = False
			Me.myContactsTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.myContactsTaskBarBox.ImageList = Me.smallImageList
			Me.myContactsTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.myContactsTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Contacts", System.Drawing.Color.Empty, 38, Nothing, "", True, True, "XPTaskBarItem4", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0)})
			Me.myContactsTaskBarBox.Location = New System.Drawing.Point(0, 0)
			Me.myContactsTaskBarBox.Name = "myContactsTaskBarBox"
			Me.myContactsTaskBarBox.Size = New System.Drawing.Size(167, 54)
			Me.myContactsTaskBarBox.TabIndex = 0
			Me.myContactsTaskBarBox.Text = "My Contacts"
'			Me.myContactsTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
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
			Me.smallImageList.Images.SetKeyName(47, "")
			Me.smallImageList.Images.SetKeyName(48, "")
			Me.smallImageList.Images.SetKeyName(49, "today.png")
			' 
			' currentViewTaskBarBox
			' 
			Me.currentViewTaskBarBox.Controls.Add(Me.panel2)
			Me.currentViewTaskBarBox.DrawFocusRect = False
			Me.currentViewTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.currentViewTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.currentViewTaskBarBox.HeaderImageIndex = -1
			Me.currentViewTaskBarBox.HitTaskBoxArea = False
			Me.currentViewTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.currentViewTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.currentViewTaskBarBox.Location = New System.Drawing.Point(0, 54)
			Me.currentViewTaskBarBox.Name = "currentViewTaskBarBox"
			Me.currentViewTaskBarBox.PreferredChildPanelHeight = 165
			Me.currentViewTaskBarBox.Size = New System.Drawing.Size(167, 196)
			Me.currentViewTaskBarBox.TabIndex = 1
			Me.currentViewTaskBarBox.Text = "Current View"
'			Me.currentViewTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.White
			Me.panel2.Controls.Add(Me.radioButton25)
			Me.panel2.Controls.Add(Me.radioButton5)
			Me.panel2.Controls.Add(Me.radioButton24)
			Me.panel2.Controls.Add(Me.radioButton4)
			Me.panel2.Controls.Add(Me.radioButton23)
			Me.panel2.Controls.Add(Me.radioButton3)
			Me.panel2.Controls.Add(Me.radioButton2)
			Me.panel2.Controls.Add(Me.radioButton1)
			Me.panel2.Location = New System.Drawing.Point(2, 29)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(163, 165)
			Me.panel2.TabIndex = 2
			' 
			' radioButton25
			' 
			Me.radioButton25.AutoSize = True
			Me.radioButton25.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton25.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton25.Location = New System.Drawing.Point(10, 143)
			Me.radioButton25.Name = "radioButton25"
			Me.radioButton25.Size = New System.Drawing.Size(133, 20)
			Me.radioButton25.TabIndex = 2
			Me.radioButton25.TabStop = True
			Me.radioButton25.Text = "Outlook Data Files"
			Me.radioButton25.UseVisualStyleBackColor = True
			' 
			' radioButton5
			' 
			Me.radioButton5.AutoSize = True
			Me.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton5.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton5.Location = New System.Drawing.Point(10, 102)
			Me.radioButton5.Name = "radioButton5"
			Me.radioButton5.Size = New System.Drawing.Size(98, 20)
			Me.radioButton5.TabIndex = 4
			Me.radioButton5.Text = "By Company"
'			Me.radioButton5.CheckedChanged += New System.EventHandler(Me.radioButton5_CheckedChanged)
			' 
			' radioButton24
			' 
			Me.radioButton24.AutoSize = True
			Me.radioButton24.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton24.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton24.Location = New System.Drawing.Point(10, 123)
			Me.radioButton24.Name = "radioButton24"
			Me.radioButton24.Size = New System.Drawing.Size(93, 20)
			Me.radioButton24.TabIndex = 1
			Me.radioButton24.TabStop = True
			Me.radioButton24.Text = "By Location"
			Me.radioButton24.UseVisualStyleBackColor = True
			' 
			' radioButton4
			' 
			Me.radioButton4.AutoSize = True
			Me.radioButton4.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton4.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton4.Location = New System.Drawing.Point(10, 82)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.Size = New System.Drawing.Size(95, 20)
			Me.radioButton4.TabIndex = 3
			Me.radioButton4.Text = "By Category"
			Me.radioButton4.UseVisualStyleBackColor = False
'			Me.radioButton4.CheckedChanged += New System.EventHandler(Me.radioButton4_CheckedChanged)
			' 
			' radioButton23
			' 
			Me.radioButton23.AutoSize = True
			Me.radioButton23.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton23.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton23.Location = New System.Drawing.Point(10, 4)
			Me.radioButton23.Name = "radioButton23"
			Me.radioButton23.Size = New System.Drawing.Size(115, 20)
			Me.radioButton23.TabIndex = 0
			Me.radioButton23.TabStop = True
			Me.radioButton23.Text = "Business Cards"
			Me.radioButton23.UseVisualStyleBackColor = True
			' 
			' radioButton3
			' 
			Me.radioButton3.AutoSize = True
			Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton3.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton3.Location = New System.Drawing.Point(10, 62)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Size = New System.Drawing.Size(87, 20)
			Me.radioButton3.TabIndex = 2
			Me.radioButton3.Text = "Phone List"
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButton3_CheckedChanged)
			' 
			' radioButton2
			' 
			Me.radioButton2.AutoSize = True
			Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton2.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton2.Location = New System.Drawing.Point(10, 42)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(159, 20)
			Me.radioButton2.TabIndex = 1
			Me.radioButton2.Text = "Detailed Address Cards"
			' 
			' radioButton1
			' 
			Me.radioButton1.AutoSize = True
			Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton1.Location = New System.Drawing.Point(10, 23)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(110, 20)
			Me.radioButton1.TabIndex = 0
			Me.radioButton1.Text = "Address Cards"
			' 
			' linkLabel18
			' 
			Me.linkLabel18.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel18.AutoSize = True
			Me.linkLabel18.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel18.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel18.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel18.Location = New System.Drawing.Point(9, 299)
			Me.linkLabel18.Name = "linkLabel18"
			Me.linkLabel18.Size = New System.Drawing.Size(84, 14)
			Me.linkLabel18.TabIndex = 1005
			Me.linkLabel18.TabStop = True
			Me.linkLabel18.Text = "Add New Group"
			Me.linkLabel18.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel19
			' 
			Me.linkLabel19.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel19.AutoSize = True
			Me.linkLabel19.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel19.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel19.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel19.Location = New System.Drawing.Point(9, 317)
			Me.linkLabel19.Name = "linkLabel19"
			Me.linkLabel19.Size = New System.Drawing.Size(133, 14)
			Me.linkLabel19.TabIndex = 1006
			Me.linkLabel19.TabStop = True
			Me.linkLabel19.Text = "Customize Current View..."
			Me.linkLabel19.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' journalPanel
			' 
			Me.journalPanel.BackColor = System.Drawing.SystemColors.Window
			Me.journalPanel.Controls.Add(Me.gradientPanel10)
			Me.journalPanel.Location = New System.Drawing.Point(1, 225)
			Me.journalPanel.Name = "journalPanel"
			Me.journalPanel.Size = New System.Drawing.Size(218, 74)
			Me.journalPanel.TabIndex = 4
			' 
			' gradientPanel10
			' 
			Me.gradientPanel10.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel10.Controls.Add(Me.panel8)
			Me.gradientPanel10.Controls.Add(Me.linkLabel25)
			Me.gradientPanel10.Controls.Add(Me.xpTaskBar6)
			Me.gradientPanel10.Controls.Add(Me.linkLabel24)
			Me.gradientPanel10.Controls.Add(Me.linkLabel11)
			Me.gradientPanel10.Controls.Add(Me.linkLabel9)
			Me.gradientPanel10.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel10.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel10.Name = "gradientPanel10"
			Me.gradientPanel10.Size = New System.Drawing.Size(218, 74)
			Me.gradientPanel10.TabIndex = 0
			' 
			' panel8
			' 
			Me.panel8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.panel8.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel8.Location = New System.Drawing.Point(0, 263)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New System.Drawing.Size(218, 5)
			Me.panel8.TabIndex = 4
			' 
			' linkLabel25
			' 
			Me.linkLabel25.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel25.AutoSize = True
			Me.linkLabel25.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel25.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel25.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel25.Location = New System.Drawing.Point(6, 309)
			Me.linkLabel25.Name = "linkLabel25"
			Me.linkLabel25.Size = New System.Drawing.Size(84, 14)
			Me.linkLabel25.TabIndex = 3
			Me.linkLabel25.TabStop = True
			Me.linkLabel25.Text = "Add New Group"
			Me.linkLabel25.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' xpTaskBar6
			' 
			Me.xpTaskBar6.BackColor = System.Drawing.Color.White
			Me.xpTaskBar6.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar6.Controls.Add(Me.myJournalTaskBarBox)
			Me.xpTaskBar6.Controls.Add(Me.currentViewTaskBarBox3)
			Me.xpTaskBar6.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskBar6.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar6.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar6.Name = "xpTaskBar6"
			Me.xpTaskBar6.Size = New System.Drawing.Size(218, 263)
			Me.xpTaskBar6.TabIndex = 0
			' 
			' myJournalTaskBarBox
			' 
			Me.myJournalTaskBarBox.DrawFocusRect = False
			Me.myJournalTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.myJournalTaskBarBox.HeaderFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.myJournalTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.myJournalTaskBarBox.HeaderImageIndex = -1
			Me.myJournalTaskBarBox.HitTaskBoxArea = False
			Me.myJournalTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.myJournalTaskBarBox.ImageList = Me.smallImageList
			Me.myJournalTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.myJournalTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal", System.Drawing.Color.Empty, 13, Nothing, "", True, True, "XPTaskBarItem9", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal in Archive Folders", System.Drawing.Color.Empty, 13, Nothing, "", True, True, "XPTaskBarItem10", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0)})
			Me.myJournalTaskBarBox.Location = New System.Drawing.Point(0, 0)
			Me.myJournalTaskBarBox.Name = "myJournalTaskBarBox"
			Me.myJournalTaskBarBox.Size = New System.Drawing.Size(218, 76)
			Me.myJournalTaskBarBox.TabIndex = 0
			Me.myJournalTaskBarBox.Text = "My Journal"
'			Me.myJournalTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' currentViewTaskBarBox3
			' 
			Me.currentViewTaskBarBox3.Controls.Add(Me.panel14)
			Me.currentViewTaskBarBox3.DrawFocusRect = False
			Me.currentViewTaskBarBox3.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.currentViewTaskBarBox3.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.currentViewTaskBarBox3.HeaderImageIndex = -1
			Me.currentViewTaskBarBox3.HitTaskBoxArea = False
			Me.currentViewTaskBarBox3.HotTrackColor = System.Drawing.Color.Empty
			Me.currentViewTaskBarBox3.ItemBackColor = System.Drawing.Color.White
			Me.currentViewTaskBarBox3.Location = New System.Drawing.Point(0, 76)
			Me.currentViewTaskBarBox3.Name = "currentViewTaskBarBox3"
			Me.currentViewTaskBarBox3.PreferredChildPanelHeight = 150
			Me.currentViewTaskBarBox3.Size = New System.Drawing.Size(218, 181)
			Me.currentViewTaskBarBox3.TabIndex = 1
			Me.currentViewTaskBarBox3.Text = "Current View"
'			Me.currentViewTaskBarBox3.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' panel14
			' 
			Me.panel14.BackColor = System.Drawing.Color.White
			Me.panel14.Controls.Add(Me.radioButton29)
			Me.panel14.Controls.Add(Me.radioButton18)
			Me.panel14.Controls.Add(Me.radioButton26)
			Me.panel14.Controls.Add(Me.radioButton19)
			Me.panel14.Controls.Add(Me.radioButton20)
			Me.panel14.Controls.Add(Me.radioButton21)
			Me.panel14.Controls.Add(Me.radioButton22)
			Me.panel14.Location = New System.Drawing.Point(2, 29)
			Me.panel14.Name = "panel14"
			Me.panel14.Size = New System.Drawing.Size(214, 150)
			Me.panel14.TabIndex = 6
			' 
			' radioButton29
			' 
			Me.radioButton29.AutoSize = True
			Me.radioButton29.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton29.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton29.Location = New System.Drawing.Point(6, 128)
			Me.radioButton29.Name = "radioButton29"
			Me.radioButton29.Size = New System.Drawing.Size(133, 20)
			Me.radioButton29.TabIndex = 3
			Me.radioButton29.TabStop = True
			Me.radioButton29.Text = "Outlook Data Files"
			Me.radioButton29.UseVisualStyleBackColor = True
			' 
			' radioButton18
			' 
			Me.radioButton18.AutoSize = True
			Me.radioButton18.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton18.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton18.Location = New System.Drawing.Point(6, 108)
			Me.radioButton18.Name = "radioButton18"
			Me.radioButton18.Size = New System.Drawing.Size(96, 20)
			Me.radioButton18.TabIndex = 4
			Me.radioButton18.Text = "Phone Calls"
			' 
			' radioButton26
			' 
			Me.radioButton26.AutoSize = True
			Me.radioButton26.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton26.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton26.Location = New System.Drawing.Point(6, 90)
			Me.radioButton26.Name = "radioButton26"
			Me.radioButton26.Size = New System.Drawing.Size(117, 20)
			Me.radioButton26.TabIndex = 2
			Me.radioButton26.TabStop = True
			Me.radioButton26.Text = "Last Seven Days"
			Me.radioButton26.UseVisualStyleBackColor = True
			' 
			' radioButton19
			' 
			Me.radioButton19.AutoSize = True
			Me.radioButton19.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton19.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton19.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton19.Location = New System.Drawing.Point(6, 68)
			Me.radioButton19.Name = "radioButton19"
			Me.radioButton19.Size = New System.Drawing.Size(81, 20)
			Me.radioButton19.TabIndex = 3
			Me.radioButton19.Text = "Entry List"
			Me.radioButton19.UseVisualStyleBackColor = False
			' 
			' radioButton20
			' 
			Me.radioButton20.AutoSize = True
			Me.radioButton20.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton20.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton20.Location = New System.Drawing.Point(6, 46)
			Me.radioButton20.Name = "radioButton20"
			Me.radioButton20.Size = New System.Drawing.Size(95, 20)
			Me.radioButton20.TabIndex = 2
			Me.radioButton20.Text = "By Category"
			' 
			' radioButton21
			' 
			Me.radioButton21.AutoSize = True
			Me.radioButton21.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton21.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton21.Location = New System.Drawing.Point(6, 24)
			Me.radioButton21.Name = "radioButton21"
			Me.radioButton21.Size = New System.Drawing.Size(89, 20)
			Me.radioButton21.TabIndex = 1
			Me.radioButton21.Text = "By Contact"
			' 
			' radioButton22
			' 
			Me.radioButton22.AutoSize = True
			Me.radioButton22.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton22.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton22.Location = New System.Drawing.Point(6, 2)
			Me.radioButton22.Name = "radioButton22"
			Me.radioButton22.Size = New System.Drawing.Size(71, 20)
			Me.radioButton22.TabIndex = 0
			Me.radioButton22.Text = "By Type"
			' 
			' linkLabel24
			' 
			Me.linkLabel24.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel24.AutoSize = True
			Me.linkLabel24.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel24.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel24.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel24.Location = New System.Drawing.Point(6, 293)
			Me.linkLabel24.Name = "linkLabel24"
			Me.linkLabel24.Size = New System.Drawing.Size(125, 14)
			Me.linkLabel24.TabIndex = 2
			Me.linkLabel24.TabStop = True
			Me.linkLabel24.Text = "Share My Journal Folder"
			Me.linkLabel24.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel11
			' 
			Me.linkLabel11.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel11.AutoSize = True
			Me.linkLabel11.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel11.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel11.Location = New System.Drawing.Point(6, 276)
			Me.linkLabel11.Name = "linkLabel11"
			Me.linkLabel11.Size = New System.Drawing.Size(126, 14)
			Me.linkLabel11.TabIndex = 0
			Me.linkLabel11.TabStop = True
			Me.linkLabel11.Text = "Open a Shared Journal..."
			Me.linkLabel11.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel9
			' 
			Me.linkLabel9.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel9.AutoSize = True
			Me.linkLabel9.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel9.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel9.Location = New System.Drawing.Point(6, 327)
			Me.linkLabel9.Name = "linkLabel9"
			Me.linkLabel9.Size = New System.Drawing.Size(133, 14)
			Me.linkLabel9.TabIndex = 1
			Me.linkLabel9.TabStop = True
			Me.linkLabel9.Text = "Customize Current View..."
			Me.linkLabel9.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' folderlistPanel
			' 
			Me.folderlistPanel.Controls.Add(Me.gradientPanel8)
			Me.folderlistPanel.Location = New System.Drawing.Point(1, 27)
			Me.folderlistPanel.Name = "folderlistPanel"
			Me.folderlistPanel.Size = New System.Drawing.Size(205, 453)
			Me.folderlistPanel.TabIndex = 1
			' 
			' gradientPanel8
			' 
			Me.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel8.Controls.Add(Me.panel6)
			Me.gradientPanel8.Controls.Add(Me.xpTaskBar5)
			Me.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel8.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel8.Name = "gradientPanel8"
			Me.gradientPanel8.Size = New System.Drawing.Size(205, 453)
			Me.gradientPanel8.TabIndex = 0
			' 
			' panel6
			' 
			Me.panel6.BackColor = System.Drawing.Color.White
			Me.panel6.Controls.Add(Me.linkLabel7)
			Me.panel6.Controls.Add(Me.panel1)
			Me.panel6.Controls.Add(Me.linkLabel8)
			Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel6.Location = New System.Drawing.Point(0, 391)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(205, 62)
			Me.panel6.TabIndex = 2
			' 
			' linkLabel7
			' 
			Me.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel7.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel7.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel7.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel7.Location = New System.Drawing.Point(11, 31)
			Me.linkLabel7.Name = "linkLabel7"
			Me.linkLabel7.Size = New System.Drawing.Size(176, 16)
			Me.linkLabel7.TabIndex = 1
			Me.linkLabel7.TabStop = True
			Me.linkLabel7.Text = "Data File Management..."
			Me.linkLabel7.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(205, 6)
			Me.panel1.TabIndex = 1
			' 
			' linkLabel8
			' 
			Me.linkLabel8.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel8.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel8.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel8.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel8.Location = New System.Drawing.Point(11, 10)
			Me.linkLabel8.Name = "linkLabel8"
			Me.linkLabel8.Size = New System.Drawing.Size(176, 16)
			Me.linkLabel8.TabIndex = 0
			Me.linkLabel8.TabStop = True
			Me.linkLabel8.Text = "Folder Sizes"
			Me.linkLabel8.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' xpTaskBar5
			' 
			Me.xpTaskBar5.BackColor = System.Drawing.Color.White
			Me.xpTaskBar5.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar5.Controls.Add(Me.allFoldersTaskBarBox)
			Me.xpTaskBar5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xpTaskBar5.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar5.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar5.Name = "xpTaskBar5"
			Me.xpTaskBar5.Size = New System.Drawing.Size(205, 453)
			Me.xpTaskBar5.TabIndex = 0
			' 
			' allFoldersTaskBarBox
			' 
			Me.allFoldersTaskBarBox.Controls.Add(Me.gradientPanel9)
			Me.allFoldersTaskBarBox.DrawFocusRect = False
			Me.allFoldersTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.allFoldersTaskBarBox.HeaderFont = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.allFoldersTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.allFoldersTaskBarBox.HeaderImageIndex = -1
			Me.allFoldersTaskBarBox.HitTaskBoxArea = False
			Me.allFoldersTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.allFoldersTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.allFoldersTaskBarBox.Location = New System.Drawing.Point(0, 0)
			Me.allFoldersTaskBarBox.Name = "allFoldersTaskBarBox"
			Me.allFoldersTaskBarBox.PreferredChildPanelHeight = 360
			Me.allFoldersTaskBarBox.Size = New System.Drawing.Size(205, 392)
			Me.allFoldersTaskBarBox.TabIndex = 0
			Me.allFoldersTaskBarBox.Text = "All Folders"
'			Me.allFoldersTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' gradientPanel9
			' 
			Me.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel9.Controls.Add(Me.treeView1)
			Me.gradientPanel9.Location = New System.Drawing.Point(2, 30)
			Me.gradientPanel9.Name = "gradientPanel9"
			Me.gradientPanel9.Size = New System.Drawing.Size(201, 360)
			Me.gradientPanel9.TabIndex = 5
			' 
			' treeView1
			' 
			Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
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
			treeNode17.ImageIndex = 2
			treeNode17.Name = ""
			treeNode17.SelectedImageIndex = 2
			treeNode17.Text = "InBox"
			treeNode18.ImageIndex = 3
			treeNode18.Name = ""
			treeNode18.SelectedImageIndex = 3
			treeNode18.Text = "OutBox"
			treeNode19.ImageIndex = 6
			treeNode19.Name = ""
			treeNode19.SelectedImageIndex = 6
			treeNode19.Text = "Sent Items"
			treeNode20.Name = ""
			treeNode20.Text = "Public"
			treeNode21.ImageIndex = 8
			treeNode21.Name = ""
			treeNode21.SelectedImageIndex = 8
			treeNode21.Text = "Syncfusion Email"
			treeNode22.ImageIndex = 4
			treeNode22.Name = ""
			treeNode22.SelectedImageIndex = 4
			treeNode22.Text = "For Follow Up"
			treeNode23.ImageIndex = 4
			treeNode23.Name = ""
			treeNode23.SelectedImageIndex = 4
			treeNode23.Text = "Large Mail"
			treeNode24.ImageIndex = 4
			treeNode24.Name = ""
			treeNode24.SelectedImageIndex = 4
			treeNode24.Text = "Search Folders"
			Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode11, treeNode15, treeNode21, treeNode24})
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.ShowLines = False
			Me.treeView1.Size = New System.Drawing.Size(201, 360)
			Me.treeView1.TabIndex = 4
			' 
			' calendarPanel
			' 
			Me.calendarPanel.BackColor = System.Drawing.Color.White
			Me.calendarPanel.Controls.Add(Me.gradientPanel3)
			Me.calendarPanel.Location = New System.Drawing.Point(1, 27)
			Me.calendarPanel.Name = "calendarPanel"
			Me.calendarPanel.Size = New System.Drawing.Size(205, 453)
			Me.calendarPanel.TabIndex = 1
			' 
			' gradientPanel3
			' 
			Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			Me.gradientPanel3.Controls.Add(Me.linkLabel10)
			Me.gradientPanel3.Controls.Add(Me.panel11)
			Me.gradientPanel3.Controls.Add(Me.linkLabel12)
			Me.gradientPanel3.Controls.Add(Me.linkLabel13)
			Me.gradientPanel3.Controls.Add(Me.xpTaskBar1)
			Me.gradientPanel3.Controls.Add(Me.linkLabel14)
			Me.gradientPanel3.Controls.Add(Me.linkLabel17)
			Me.gradientPanel3.Controls.Add(Me.linkLabel15)
			Me.gradientPanel3.Controls.Add(Me.linkLabel16)
			Me.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gradientPanel3.Location = New System.Drawing.Point(0, 215)
			Me.gradientPanel3.Name = "gradientPanel3"
			Me.gradientPanel3.Size = New System.Drawing.Size(205, 238)
			Me.gradientPanel3.TabIndex = 0
			' 
			' linkLabel10
			' 
			Me.linkLabel10.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel10.AutoSize = True
			Me.linkLabel10.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel10.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel10.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel10.Location = New System.Drawing.Point(9, 96)
			Me.linkLabel10.Name = "linkLabel10"
			Me.linkLabel10.Size = New System.Drawing.Size(124, 14)
			Me.linkLabel10.TabIndex = 2
			Me.linkLabel10.TabStop = True
			Me.linkLabel10.Text = "How to Share Calendars"
			Me.linkLabel10.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' panel11
			' 
			Me.panel11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.panel11.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel11.Location = New System.Drawing.Point(0, 79)
			Me.panel11.Name = "panel11"
			Me.panel11.Size = New System.Drawing.Size(201, 5)
			Me.panel11.TabIndex = 1
			' 
			' linkLabel12
			' 
			Me.linkLabel12.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel12.AutoSize = True
			Me.linkLabel12.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel12.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel12.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel12.Location = New System.Drawing.Point(9, 117)
			Me.linkLabel12.Name = "linkLabel12"
			Me.linkLabel12.Size = New System.Drawing.Size(133, 14)
			Me.linkLabel12.TabIndex = 3
			Me.linkLabel12.TabStop = True
			Me.linkLabel12.Text = "Open a Shared Calendar..."
			Me.linkLabel12.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel13
			' 
			Me.linkLabel13.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel13.AutoSize = True
			Me.linkLabel13.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel13.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel13.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel13.Location = New System.Drawing.Point(10, 134)
			Me.linkLabel13.Name = "linkLabel13"
			Me.linkLabel13.Size = New System.Drawing.Size(127, 14)
			Me.linkLabel13.TabIndex = 4
			Me.linkLabel13.TabStop = True
			Me.linkLabel13.Text = "Search Calendars Online"
			Me.linkLabel13.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.BackColor = System.Drawing.Color.White
			Me.xpTaskBar1.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar1.Controls.Add(Me.myCalendarsTaskBarBox1)
			Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskBar1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Size = New System.Drawing.Size(201, 79)
			Me.xpTaskBar1.TabIndex = 0
			' 
			' myCalendarsTaskBarBox1
			' 
			Me.myCalendarsTaskBarBox1.Controls.Add(Me.gradientPanel4)
			Me.myCalendarsTaskBarBox1.DrawFocusRect = False
			Me.myCalendarsTaskBarBox1.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.myCalendarsTaskBarBox1.HeaderForeColor = System.Drawing.Color.DarkBlue
			Me.myCalendarsTaskBarBox1.HeaderImageIndex = -1
			Me.myCalendarsTaskBarBox1.HitTaskBoxArea = False
			Me.myCalendarsTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty
			Me.myCalendarsTaskBarBox1.ItemBackColor = System.Drawing.Color.White
			Me.myCalendarsTaskBarBox1.Location = New System.Drawing.Point(0, 0)
			Me.myCalendarsTaskBarBox1.Name = "myCalendarsTaskBarBox1"
			Me.myCalendarsTaskBarBox1.PreferredChildPanelHeight = 45
			Me.myCalendarsTaskBarBox1.Size = New System.Drawing.Size(201, 76)
			Me.myCalendarsTaskBarBox1.TabIndex = 0
			Me.myCalendarsTaskBarBox1.Text = "My Calendars"
'			Me.myCalendarsTaskBarBox1.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' gradientPanel4
			' 
			Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel4.Controls.Add(Me.checkBox2)
			Me.gradientPanel4.Controls.Add(Me.checkBox1)
			Me.gradientPanel4.Location = New System.Drawing.Point(2, 29)
			Me.gradientPanel4.Name = "gradientPanel4"
			Me.gradientPanel4.Size = New System.Drawing.Size(197, 45)
			Me.gradientPanel4.TabIndex = 0
			' 
			' checkBox2
			' 
			Me.checkBox2.AutoSize = True
			Me.checkBox2.BackColor = System.Drawing.Color.White
			Me.checkBox2.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox2.ImageIndex = 12
			Me.checkBox2.ImageList = Me.smallImageList
			Me.checkBox2.Location = New System.Drawing.Point(3, 23)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(169, 18)
			Me.checkBox2.TabIndex = 1
			Me.checkBox2.Text = "Calendar in Archive Folder"
			Me.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.checkBox2.UseVisualStyleBackColor = False
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.BackColor = System.Drawing.Color.White
			Me.checkBox1.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.ImageIndex = 12
			Me.checkBox1.ImageList = Me.smallImageList
			Me.checkBox1.Location = New System.Drawing.Point(3, 3)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(86, 18)
			Me.checkBox1.TabIndex = 0
			Me.checkBox1.Text = "Calendar"
			Me.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.checkBox1.UseVisualStyleBackColor = False
			' 
			' linkLabel14
			' 
			Me.linkLabel14.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel14.AutoSize = True
			Me.linkLabel14.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel14.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel14.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel14.Location = New System.Drawing.Point(9, 158)
			Me.linkLabel14.Name = "linkLabel14"
			Me.linkLabel14.Size = New System.Drawing.Size(108, 14)
			Me.linkLabel14.TabIndex = 5
			Me.linkLabel14.TabStop = True
			Me.linkLabel14.Text = "Share My Calendar..."
			Me.linkLabel14.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel17
			' 
			Me.linkLabel17.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel17.AutoSize = True
			Me.linkLabel17.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel17.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel17.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel17.Location = New System.Drawing.Point(9, 217)
			Me.linkLabel17.Name = "linkLabel17"
			Me.linkLabel17.Size = New System.Drawing.Size(84, 14)
			Me.linkLabel17.TabIndex = 8
			Me.linkLabel17.TabStop = True
			Me.linkLabel17.Text = "Add New Group"
			Me.linkLabel17.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel15
			' 
			Me.linkLabel15.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel15.AutoSize = True
			Me.linkLabel15.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel15.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel15.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel15.Location = New System.Drawing.Point(9, 175)
			Me.linkLabel15.Name = "linkLabel15"
			Me.linkLabel15.Size = New System.Drawing.Size(147, 14)
			Me.linkLabel15.TabIndex = 6
			Me.linkLabel15.TabStop = True
			Me.linkLabel15.Text = "Send a Calendar via E-mail..."
			Me.linkLabel15.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel16
			' 
			Me.linkLabel16.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel16.AutoSize = True
			Me.linkLabel16.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel16.ForeColor = System.Drawing.SystemColors.Desktop
			Me.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel16.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel16.Location = New System.Drawing.Point(9, 194)
			Me.linkLabel16.Name = "linkLabel16"
			Me.linkLabel16.Size = New System.Drawing.Size(115, 14)
			Me.linkLabel16.TabIndex = 7
			Me.linkLabel16.TabStop = True
			Me.linkLabel16.Text = "Publish My Calendar..."
			Me.linkLabel16.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' mailPanel
			' 
			Me.mailPanel.Controls.Add(Me.mailTaskBar)
			Me.mailPanel.Location = New System.Drawing.Point(1, 27)
			Me.mailPanel.Name = "mailPanel"
			Me.mailPanel.Size = New System.Drawing.Size(205, 453)
			Me.mailPanel.TabIndex = 1
			' 
			' mailTaskBar
			' 
			Me.mailTaskBar.BackColor = System.Drawing.Color.White
			Me.mailTaskBar.BorderColor = System.Drawing.Color.Black
			Me.mailTaskBar.Controls.Add(Me.favouritesTaskBarBox)
			Me.mailTaskBar.Controls.Add(Me.mailTaskBarBox)
			Me.mailTaskBar.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mailTaskBar.Location = New System.Drawing.Point(0, 0)
			Me.mailTaskBar.MinimumSize = New System.Drawing.Size(0, 0)
			Me.mailTaskBar.Name = "mailTaskBar"
			Me.mailTaskBar.Size = New System.Drawing.Size(205, 453)
			Me.mailTaskBar.TabIndex = 4
			' 
			' favouritesTaskBarBox
			' 
			Me.favouritesTaskBarBox.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(255))))))
			Me.favouritesTaskBarBox.DrawFocusRect = False
			Me.favouritesTaskBarBox.ForeColor = System.Drawing.SystemColors.ControlText
			Me.favouritesTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.favouritesTaskBarBox.HeaderFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.favouritesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.favouritesTaskBarBox.HeaderImageIndex = -1
			Me.favouritesTaskBarBox.HitTaskBoxArea = False
			Me.favouritesTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.favouritesTaskBarBox.ImageList = Me.smallImageList
			Me.favouritesTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.favouritesTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Inbox", System.Drawing.Color.Empty, 2, Nothing, "", True, True, "XPTaskBarItem0", New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Unread Mail", System.Drawing.Color.Empty, 4, Nothing, "", True, True, "XPTaskBarItem1", New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sent Items", System.Drawing.Color.Empty, 6, Nothing, "", True, True, "XPTaskBarItem2", New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0)})
			Me.favouritesTaskBarBox.Location = New System.Drawing.Point(0, 0)
			Me.favouritesTaskBarBox.Name = "favouritesTaskBarBox"
			Me.favouritesTaskBarBox.Size = New System.Drawing.Size(205, 98)
			Me.favouritesTaskBarBox.TabIndex = 0
			Me.favouritesTaskBarBox.Text = "Favourite Folders"
'			Me.favouritesTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' mailTaskBarBox
			' 
			Me.mailTaskBarBox.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(255))))))
			Me.mailTaskBarBox.Controls.Add(Me.gradientPanel2)
			Me.mailTaskBarBox.DrawFocusRect = False
			Me.mailTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.mailTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.mailTaskBarBox.HeaderImageIndex = -1
			Me.mailTaskBarBox.HitTaskBoxArea = False
			Me.mailTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.mailTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.mailTaskBarBox.Location = New System.Drawing.Point(0, 98)
			Me.mailTaskBarBox.Name = "mailTaskBarBox"
			Me.mailTaskBarBox.PreferredChildPanelHeight = 130
			Me.mailTaskBarBox.Size = New System.Drawing.Size(205, 161)
			Me.mailTaskBarBox.TabIndex = 1
			Me.mailTaskBarBox.Text = "Mail Folders"
'			Me.mailTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' gradientPanel2
			' 
			Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel2.Controls.Add(Me.treeView3)
			Me.gradientPanel2.Location = New System.Drawing.Point(2, 29)
			Me.gradientPanel2.Name = "gradientPanel2"
			Me.gradientPanel2.Size = New System.Drawing.Size(201, 130)
			Me.gradientPanel2.TabIndex = 4
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
			treeNode25.ImageIndex = 1
			treeNode25.Name = ""
			treeNode25.SelectedImageIndex = 1
			treeNode25.Text = "Deleted Items"
			treeNode26.ImageIndex = 0
			treeNode26.Name = ""
			treeNode26.SelectedImageIndex = 0
			treeNode26.Text = "Junk Email"
			treeNode27.ImageIndex = 2
			treeNode27.Name = ""
			treeNode27.SelectedImageIndex = 2
			treeNode27.Text = "Inbox"
			treeNode28.ImageIndex = 6
			treeNode28.Name = ""
			treeNode28.SelectedImageIndex = 6
			treeNode28.Text = "Sent Items"
			treeNode29.ImageIndex = 4
			treeNode29.Name = ""
			treeNode29.SelectedImageIndex = 4
			treeNode29.Text = "Search Folders"
			treeNode30.ImageIndex = 7
			treeNode30.Name = ""
			treeNode30.SelectedImageIndex = 7
			treeNode30.Text = "Personal Folders"
			treeNode31.ImageIndex = 4
			treeNode31.Name = ""
			treeNode31.SelectedImageIndex = 4
			treeNode31.Text = "Search Folders"
			treeNode32.ImageIndex = 6
			treeNode32.Name = ""
			treeNode32.SelectedImageIndex = 6
			treeNode32.Text = "Sent Items"
			treeNode33.ImageIndex = 1
			treeNode33.Name = ""
			treeNode33.SelectedImageIndex = 1
			treeNode33.Text = "Deleted Items"
			treeNode34.ImageIndex = 8
			treeNode34.Name = ""
			treeNode34.SelectedImageIndex = 8
			treeNode34.Text = "Archive Folders"
			treeNode35.ImageIndex = 5
			treeNode35.Name = ""
			treeNode35.SelectedImageIndex = 5
			treeNode35.Text = "Drafts"
			treeNode36.ImageIndex = 2
			treeNode36.Name = ""
			treeNode36.SelectedImageIndex = 2
			treeNode36.Text = "Inbox"
			treeNode37.ImageIndex = 3
			treeNode37.Name = ""
			treeNode37.SelectedImageIndex = 3
			treeNode37.Text = "Outbox"
			treeNode38.ImageIndex = 6
			treeNode38.Name = ""
			treeNode38.SelectedImageIndex = 6
			treeNode38.Text = "Sent Items"
			treeNode39.Name = ""
			treeNode39.Text = "Public"
			treeNode40.ImageIndex = 8
			treeNode40.Name = ""
			treeNode40.SelectedImageIndex = 8
			treeNode40.Text = "Syncfusion Email"
			Me.treeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode30, treeNode34, treeNode40})
			Me.treeView3.SelectedImageIndex = 0
			Me.treeView3.ShowLines = False
			Me.treeView3.Size = New System.Drawing.Size(201, 130)
			Me.treeView3.TabIndex = 3
			' 
			' notesPanel
			' 
			Me.notesPanel.Controls.Add(Me.gradientPanel7)
			Me.notesPanel.Location = New System.Drawing.Point(1, 27)
			Me.notesPanel.Name = "notesPanel"
			Me.notesPanel.Size = New System.Drawing.Size(205, 453)
			Me.notesPanel.TabIndex = 1
			' 
			' gradientPanel7
			' 
			Me.gradientPanel7.BackColor = System.Drawing.Color.White
			Me.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel7.Controls.Add(Me.linkLabel22)
			Me.gradientPanel7.Controls.Add(Me.panel5)
			Me.gradientPanel7.Controls.Add(Me.linkLabel23)
			Me.gradientPanel7.Controls.Add(Me.xpTaskBar4)
			Me.gradientPanel7.Controls.Add(Me.linkLabel5)
			Me.gradientPanel7.Controls.Add(Me.linkLabel6)
			Me.gradientPanel7.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel7.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel7.Name = "gradientPanel7"
			Me.gradientPanel7.Size = New System.Drawing.Size(205, 453)
			Me.gradientPanel7.TabIndex = 0
			' 
			' linkLabel22
			' 
			Me.linkLabel22.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel22.AutoSize = True
			Me.linkLabel22.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel22.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel22.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel22.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel22.Location = New System.Drawing.Point(4, 249)
			Me.linkLabel22.Name = "linkLabel22"
			Me.linkLabel22.Size = New System.Drawing.Size(126, 14)
			Me.linkLabel22.TabIndex = 0
			Me.linkLabel22.TabStop = True
			Me.linkLabel22.Text = "Share My Notes Folder..."
			Me.linkLabel22.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' panel5
			' 
			Me.panel5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel5.Location = New System.Drawing.Point(0, 215)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(205, 5)
			Me.panel5.TabIndex = 1
			' 
			' linkLabel23
			' 
			Me.linkLabel23.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel23.AutoSize = True
			Me.linkLabel23.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel23.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel23.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel23.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel23.Location = New System.Drawing.Point(4, 267)
			Me.linkLabel23.Name = "linkLabel23"
			Me.linkLabel23.Size = New System.Drawing.Size(84, 14)
			Me.linkLabel23.TabIndex = 1
			Me.linkLabel23.TabStop = True
			Me.linkLabel23.Text = "Add New Group"
			Me.linkLabel23.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' xpTaskBar4
			' 
			Me.xpTaskBar4.BackColor = System.Drawing.Color.White
			Me.xpTaskBar4.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar4.Controls.Add(Me.notesTaskBarBox)
			Me.xpTaskBar4.Controls.Add(Me.currentViewTaskBarBox2)
			Me.xpTaskBar4.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskBar4.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar4.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar4.Name = "xpTaskBar4"
			Me.xpTaskBar4.Size = New System.Drawing.Size(205, 215)
			Me.xpTaskBar4.TabIndex = 0
			' 
			' notesTaskBarBox
			' 
			Me.notesTaskBarBox.DrawFocusRect = False
			Me.notesTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.notesTaskBarBox.HeaderFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.notesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.notesTaskBarBox.HeaderImageIndex = -1
			Me.notesTaskBarBox.HitTaskBoxArea = False
			Me.notesTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.notesTaskBarBox.ImageList = Me.smallImageList
			Me.notesTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.notesTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Notes", System.Drawing.Color.Empty, 11, Nothing, "", True, True, "XPTaskBarItem8", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0)})
			Me.notesTaskBarBox.Location = New System.Drawing.Point(0, 0)
			Me.notesTaskBarBox.Name = "notesTaskBarBox"
			Me.notesTaskBarBox.Size = New System.Drawing.Size(205, 54)
			Me.notesTaskBarBox.TabIndex = 0
			Me.notesTaskBarBox.Text = "My Notes"
'			Me.notesTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' currentViewTaskBarBox2
			' 
			Me.currentViewTaskBarBox2.Controls.Add(Me.panel9)
			Me.currentViewTaskBarBox2.DrawFocusRect = False
			Me.currentViewTaskBarBox2.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.currentViewTaskBarBox2.HeaderFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.currentViewTaskBarBox2.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.currentViewTaskBarBox2.HeaderImageIndex = -1
			Me.currentViewTaskBarBox2.HitTaskBoxArea = False
			Me.currentViewTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty
			Me.currentViewTaskBarBox2.ItemBackColor = System.Drawing.Color.White
			Me.currentViewTaskBarBox2.Location = New System.Drawing.Point(0, 54)
			Me.currentViewTaskBarBox2.Name = "currentViewTaskBarBox2"
			Me.currentViewTaskBarBox2.PreferredChildPanelHeight = 125
			Me.currentViewTaskBarBox2.Size = New System.Drawing.Size(205, 156)
			Me.currentViewTaskBarBox2.TabIndex = 1
			Me.currentViewTaskBarBox2.Text = "Current View"
'			Me.currentViewTaskBarBox2.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' panel9
			' 
			Me.panel9.BackColor = System.Drawing.Color.White
			Me.panel9.Controls.Add(Me.radioButton13)
			Me.panel9.Controls.Add(Me.radioButton14)
			Me.panel9.Controls.Add(Me.radioButton15)
			Me.panel9.Controls.Add(Me.radioButton16)
			Me.panel9.Controls.Add(Me.radioButton17)
			Me.panel9.Location = New System.Drawing.Point(2, 29)
			Me.panel9.Name = "panel9"
			Me.panel9.Size = New System.Drawing.Size(201, 125)
			Me.panel9.TabIndex = 6
			' 
			' radioButton13
			' 
			Me.radioButton13.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton13.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton13.Location = New System.Drawing.Point(8, 98)
			Me.radioButton13.Name = "radioButton13"
			Me.radioButton13.Size = New System.Drawing.Size(176, 24)
			Me.radioButton13.TabIndex = 4
			Me.radioButton13.Text = "Outlook Data Files"
			' 
			' radioButton14
			' 
			Me.radioButton14.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton14.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton14.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton14.Location = New System.Drawing.Point(8, 75)
			Me.radioButton14.Name = "radioButton14"
			Me.radioButton14.Size = New System.Drawing.Size(176, 24)
			Me.radioButton14.TabIndex = 3
			Me.radioButton14.Text = "By Category"
			Me.radioButton14.UseVisualStyleBackColor = False
			' 
			' radioButton15
			' 
			Me.radioButton15.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton15.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton15.Location = New System.Drawing.Point(8, 52)
			Me.radioButton15.Name = "radioButton15"
			Me.radioButton15.Size = New System.Drawing.Size(176, 24)
			Me.radioButton15.TabIndex = 2
			Me.radioButton15.Text = "Last Seven Days"
			' 
			' radioButton16
			' 
			Me.radioButton16.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton16.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton16.Location = New System.Drawing.Point(8, 29)
			Me.radioButton16.Name = "radioButton16"
			Me.radioButton16.Size = New System.Drawing.Size(176, 24)
			Me.radioButton16.TabIndex = 1
			Me.radioButton16.Text = "Notes List"
			' 
			' radioButton17
			' 
			Me.radioButton17.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton17.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton17.Location = New System.Drawing.Point(8, 6)
			Me.radioButton17.Name = "radioButton17"
			Me.radioButton17.Size = New System.Drawing.Size(176, 24)
			Me.radioButton17.TabIndex = 0
			Me.radioButton17.Text = "Icons"
			' 
			' linkLabel5
			' 
			Me.linkLabel5.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel5.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel5.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel5.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel5.Location = New System.Drawing.Point(4, 288)
			Me.linkLabel5.Name = "linkLabel5"
			Me.linkLabel5.Size = New System.Drawing.Size(176, 16)
			Me.linkLabel5.TabIndex = 1
			Me.linkLabel5.TabStop = True
			Me.linkLabel5.Text = "Customize Current View..."
			Me.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel6
			' 
			Me.linkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel6.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel6.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel6.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel6.Location = New System.Drawing.Point(4, 232)
			Me.linkLabel6.Name = "linkLabel6"
			Me.linkLabel6.Size = New System.Drawing.Size(176, 16)
			Me.linkLabel6.TabIndex = 0
			Me.linkLabel6.TabStop = True
			Me.linkLabel6.Text = "Open Shared Notes..."
			Me.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' tasksPanel
			' 
			Me.tasksPanel.BackColor = System.Drawing.SystemColors.Window
			Me.tasksPanel.Controls.Add(Me.gradientPanel6)
			Me.tasksPanel.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.tasksPanel.Location = New System.Drawing.Point(1, 27)
			Me.tasksPanel.Name = "tasksPanel"
			Me.tasksPanel.Size = New System.Drawing.Size(205, 453)
			Me.tasksPanel.TabIndex = 1
			' 
			' gradientPanel6
			' 
			Me.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel6.Controls.Add(Me.panel4)
			Me.gradientPanel6.Controls.Add(Me.linkLabel20)
			Me.gradientPanel6.Controls.Add(Me.xpTaskBar3)
			Me.gradientPanel6.Controls.Add(Me.linkLabel21)
			Me.gradientPanel6.Controls.Add(Me.linkLabel4)
			Me.gradientPanel6.Controls.Add(Me.linkLabel3)
			Me.gradientPanel6.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel6.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel6.Name = "gradientPanel6"
			Me.gradientPanel6.Size = New System.Drawing.Size(205, 453)
			Me.gradientPanel6.TabIndex = 0
			' 
			' panel4
			' 
			Me.panel4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel4.Location = New System.Drawing.Point(0, 359)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(205, 5)
			Me.panel4.TabIndex = 1005
			' 
			' linkLabel20
			' 
			Me.linkLabel20.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel20.AutoSize = True
			Me.linkLabel20.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel20.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel20.Location = New System.Drawing.Point(7, 392)
			Me.linkLabel20.Name = "linkLabel20"
			Me.linkLabel20.Size = New System.Drawing.Size(124, 14)
			Me.linkLabel20.TabIndex = 1003
			Me.linkLabel20.TabStop = True
			Me.linkLabel20.Text = "Share My Tasks Folder..."
			Me.linkLabel20.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' xpTaskBar3
			' 
			Me.xpTaskBar3.BackColor = System.Drawing.Color.White
			Me.xpTaskBar3.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar3.Controls.Add(Me.mytasksTaskBarBox)
			Me.xpTaskBar3.Controls.Add(Me.currentViewTaskBarBox1)
			Me.xpTaskBar3.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskBar3.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar3.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar3.Name = "xpTaskBar3"
			Me.xpTaskBar3.Size = New System.Drawing.Size(205, 359)
			Me.xpTaskBar3.TabIndex = 0
			' 
			' mytasksTaskBarBox
			' 
			Me.mytasksTaskBarBox.DrawFocusRect = False
			Me.mytasksTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.mytasksTaskBarBox.HeaderFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.mytasksTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.mytasksTaskBarBox.HeaderImageIndex = -1
			Me.mytasksTaskBarBox.HitTaskBoxArea = False
			Me.mytasksTaskBarBox.HotTrackColor = System.Drawing.Color.Empty
			Me.mytasksTaskBarBox.ImageList = Me.smallImageList
			Me.mytasksTaskBarBox.ItemBackColor = System.Drawing.Color.White
			Me.mytasksTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("To-Do List", System.Drawing.Color.Empty, 49, Nothing, "", True, True, "XPTaskBarItem5", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks", System.Drawing.Color.Empty, 10, Nothing, "", True, True, "XPTaskBarItem6", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks in Archieve Folders", System.Drawing.Color.Empty, 10, Nothing, "", True, True, "XPTaskBarItem7", New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), 0)})
			Me.mytasksTaskBarBox.Location = New System.Drawing.Point(0, 0)
			Me.mytasksTaskBarBox.Name = "mytasksTaskBarBox"
			Me.mytasksTaskBarBox.Size = New System.Drawing.Size(205, 95)
			Me.mytasksTaskBarBox.TabIndex = 0
			Me.mytasksTaskBarBox.Text = "My Tasks"
'			Me.mytasksTaskBarBox.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' currentViewTaskBarBox1
			' 
			Me.currentViewTaskBarBox1.Controls.Add(Me.panel7)
			Me.currentViewTaskBarBox1.DrawFocusRect = False
			Me.currentViewTaskBarBox1.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(255))))))
			Me.currentViewTaskBarBox1.HeaderFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.currentViewTaskBarBox1.HeaderForeColor = System.Drawing.Color.MidnightBlue
			Me.currentViewTaskBarBox1.HeaderImageIndex = -1
			Me.currentViewTaskBarBox1.HitTaskBoxArea = False
			Me.currentViewTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty
			Me.currentViewTaskBarBox1.ItemBackColor = System.Drawing.Color.White
			Me.currentViewTaskBarBox1.Location = New System.Drawing.Point(0, 95)
			Me.currentViewTaskBarBox1.Name = "currentViewTaskBarBox1"
			Me.currentViewTaskBarBox1.PreferredChildPanelHeight = 232
			Me.currentViewTaskBarBox1.Size = New System.Drawing.Size(205, 263)
			Me.currentViewTaskBarBox1.TabIndex = 1
			Me.currentViewTaskBarBox1.Text = "Current View"
'			Me.currentViewTaskBarBox1.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.TaskBarBox_ProvideHeaderBackgroundBrush)
			' 
			' panel7
			' 
			Me.panel7.BackColor = System.Drawing.Color.White
			Me.panel7.Controls.Add(Me.radioButton31)
			Me.panel7.Controls.Add(Me.radioButton30)
			Me.panel7.Controls.Add(Me.radioButton28)
			Me.panel7.Controls.Add(Me.radioButton27)
			Me.panel7.Controls.Add(Me.radioButton12)
			Me.panel7.Controls.Add(Me.radioButton11)
			Me.panel7.Controls.Add(Me.radioButton6)
			Me.panel7.Controls.Add(Me.radioButton7)
			Me.panel7.Controls.Add(Me.radioButton8)
			Me.panel7.Controls.Add(Me.radioButton9)
			Me.panel7.Controls.Add(Me.radioButton10)
			Me.panel7.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.panel7.Location = New System.Drawing.Point(2, 29)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New System.Drawing.Size(201, 232)
			Me.panel7.TabIndex = 6
			' 
			' radioButton31
			' 
			Me.radioButton31.AutoSize = True
			Me.radioButton31.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton31.Location = New System.Drawing.Point(7, 209)
			Me.radioButton31.Name = "radioButton31"
			Me.radioButton31.Size = New System.Drawing.Size(84, 20)
			Me.radioButton31.TabIndex = 12
			Me.radioButton31.TabStop = True
			Me.radioButton31.Text = "To-Do List"
			Me.radioButton31.UseVisualStyleBackColor = True
			' 
			' radioButton30
			' 
			Me.radioButton30.AutoSize = True
			Me.radioButton30.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton30.Location = New System.Drawing.Point(7, 190)
			Me.radioButton30.Name = "radioButton30"
			Me.radioButton30.Size = New System.Drawing.Size(133, 20)
			Me.radioButton30.TabIndex = 11
			Me.radioButton30.TabStop = True
			Me.radioButton30.Text = "Outlook Data Files"
			Me.radioButton30.UseVisualStyleBackColor = True
			' 
			' radioButton28
			' 
			Me.radioButton28.AutoSize = True
			Me.radioButton28.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton28.Location = New System.Drawing.Point(7, 170)
			Me.radioButton28.Name = "radioButton28"
			Me.radioButton28.Size = New System.Drawing.Size(111, 20)
			Me.radioButton28.TabIndex = 9
			Me.radioButton28.TabStop = True
			Me.radioButton28.Text = "Tasks Timeline"
			Me.radioButton28.UseVisualStyleBackColor = True
			' 
			' radioButton27
			' 
			Me.radioButton27.AutoSize = True
			Me.radioButton27.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton27.Location = New System.Drawing.Point(7, 147)
			Me.radioButton27.Name = "radioButton27"
			Me.radioButton27.Size = New System.Drawing.Size(122, 20)
			Me.radioButton27.TabIndex = 8
			Me.radioButton27.TabStop = True
			Me.radioButton27.Text = "Completed Tasks"
			Me.radioButton27.UseVisualStyleBackColor = True
			' 
			' radioButton12
			' 
			Me.radioButton12.AutoSize = True
			Me.radioButton12.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton12.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton12.Location = New System.Drawing.Point(7, 125)
			Me.radioButton12.Name = "radioButton12"
			Me.radioButton12.Size = New System.Drawing.Size(94, 20)
			Me.radioButton12.TabIndex = 6
			Me.radioButton12.Text = "Assignment"
			' 
			' radioButton11
			' 
			Me.radioButton11.AutoSize = True
			Me.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton11.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton11.Location = New System.Drawing.Point(7, 104)
			Me.radioButton11.Name = "radioButton11"
			Me.radioButton11.Size = New System.Drawing.Size(95, 20)
			Me.radioButton11.TabIndex = 5
			Me.radioButton11.Text = "By Category"
			' 
			' radioButton6
			' 
			Me.radioButton6.AutoSize = True
			Me.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton6.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton6.Location = New System.Drawing.Point(7, 83)
			Me.radioButton6.Name = "radioButton6"
			Me.radioButton6.Size = New System.Drawing.Size(110, 20)
			Me.radioButton6.TabIndex = 4
			Me.radioButton6.Text = "Overdue Tasks"
			' 
			' radioButton7
			' 
			Me.radioButton7.AutoSize = True
			Me.radioButton7.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton7.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton7.Location = New System.Drawing.Point(7, 63)
			Me.radioButton7.Name = "radioButton7"
			Me.radioButton7.Size = New System.Drawing.Size(119, 20)
			Me.radioButton7.TabIndex = 3
			Me.radioButton7.Text = "Next Seven Days"
			Me.radioButton7.UseVisualStyleBackColor = False
			' 
			' radioButton8
			' 
			Me.radioButton8.AutoSize = True
			Me.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton8.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton8.Location = New System.Drawing.Point(7, 43)
			Me.radioButton8.Name = "radioButton8"
			Me.radioButton8.Size = New System.Drawing.Size(96, 20)
			Me.radioButton8.TabIndex = 2
			Me.radioButton8.Text = "Active Tasks"
			' 
			' radioButton9
			' 
			Me.radioButton9.AutoSize = True
			Me.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton9.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton9.Location = New System.Drawing.Point(7, 23)
			Me.radioButton9.Name = "radioButton9"
			Me.radioButton9.Size = New System.Drawing.Size(99, 20)
			Me.radioButton9.TabIndex = 1
			Me.radioButton9.Text = "Detailed List"
			' 
			' radioButton10
			' 
			Me.radioButton10.AutoSize = True
			Me.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton10.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton10.Location = New System.Drawing.Point(7, 4)
			Me.radioButton10.Name = "radioButton10"
			Me.radioButton10.Size = New System.Drawing.Size(90, 20)
			Me.radioButton10.TabIndex = 0
			Me.radioButton10.Text = "Simple List"
			' 
			' linkLabel21
			' 
			Me.linkLabel21.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel21.AutoSize = True
			Me.linkLabel21.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel21.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel21.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel21.Location = New System.Drawing.Point(7, 409)
			Me.linkLabel21.Name = "linkLabel21"
			Me.linkLabel21.Size = New System.Drawing.Size(84, 14)
			Me.linkLabel21.TabIndex = 1004
			Me.linkLabel21.TabStop = True
			Me.linkLabel21.Text = "Add New Group"
			Me.linkLabel21.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel4
			' 
			Me.linkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel4.AutoSize = True
			Me.linkLabel4.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel4.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel4.Location = New System.Drawing.Point(7, 374)
			Me.linkLabel4.Name = "linkLabel4"
			Me.linkLabel4.Size = New System.Drawing.Size(109, 14)
			Me.linkLabel4.TabIndex = 0
			Me.linkLabel4.TabStop = True
			Me.linkLabel4.Text = "Open Shared Tasks..."
			Me.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' linkLabel3
			' 
			Me.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel3.AutoSize = True
			Me.linkLabel3.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel3.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			Me.linkLabel3.Location = New System.Drawing.Point(7, 428)
			Me.linkLabel3.Name = "linkLabel3"
			Me.linkLabel3.Size = New System.Drawing.Size(133, 14)
			Me.linkLabel3.TabIndex = 1
			Me.linkLabel3.TabStop = True
			Me.linkLabel3.Text = "Customize Current View..."
			Me.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(61))))), (CInt(Fix((CByte(178))))))
			' 
			' groupBarItem1
			' 
			Me.groupBarItem1.Client = Me.mailPanel
			Me.groupBarItem1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem1.Icon = (CType(resources.GetObject("groupBarItem1.Icon"), System.Drawing.Icon))
			Me.groupBarItem1.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem1.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem1.Padding = 4
			Me.groupBarItem1.Text = "Mail"
			' 
			' groupBarItem7
			' 
			Me.groupBarItem7.Client = Me.calendarPanel
			Me.groupBarItem7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem7.Icon = (CType(resources.GetObject("groupBarItem7.Icon"), System.Drawing.Icon))
			Me.groupBarItem7.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem7.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem7.Padding = 4
			Me.groupBarItem7.Text = "Calendar"
			' 
			' groupBarItem3
			' 
			Me.groupBarItem3.Client = Me.contactsPanel
			Me.groupBarItem3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem3.Icon = (CType(resources.GetObject("groupBarItem3.Icon"), System.Drawing.Icon))
			Me.groupBarItem3.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem3.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem3.Padding = 4
			Me.groupBarItem3.Text = "Contacts"
			' 
			' groupBarItem4
			' 
			Me.groupBarItem4.Client = Me.tasksPanel
			Me.groupBarItem4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem4.Icon = (CType(resources.GetObject("groupBarItem4.Icon"), System.Drawing.Icon))
			Me.groupBarItem4.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem4.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem4.Padding = 4
			Me.groupBarItem4.Text = "Tasks"
			' 
			' groupBarItem5
			' 
			Me.groupBarItem5.Client = Me.notesPanel
			Me.groupBarItem5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem5.Icon = (CType(resources.GetObject("groupBarItem5.Icon"), System.Drawing.Icon))
			Me.groupBarItem5.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem5.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem5.Padding = 4
			Me.groupBarItem5.Text = "Notes"
			' 
			' groupBarItem6
			' 
			Me.groupBarItem6.Client = Me.folderlistPanel
			Me.groupBarItem6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem6.Icon = (CType(resources.GetObject("groupBarItem6.Icon"), System.Drawing.Icon))
			Me.groupBarItem6.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem6.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem6.Padding = 4
			Me.groupBarItem6.Text = "Folder List"
			' 
			' groupBarItem2
			' 
			Me.groupBarItem2.Client = Me.journalPanel
			Me.groupBarItem2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.groupBarItem2.Icon = (CType(resources.GetObject("groupBarItem2.Icon"), System.Drawing.Icon))
			Me.groupBarItem2.NavigationPaneIcon = (CType(resources.GetObject("groupBarItem2.NavigationPaneIcon"), System.Drawing.Icon))
			Me.groupBarItem2.Padding = 4
			Me.groupBarItem2.Text = "Journal"
			Me.groupBarItem2.Visible = False
			' 
			' clientPanel
			' 
			Me.clientPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
			Me.clientPanel.Controls.Add(Me.panel16)
			Me.clientPanel.Controls.Add(Me.splitter2)
			Me.clientPanel.Controls.Add(Me.gridContainerPanel)
			Me.clientPanel.Controls.Add(Me.scheduleContainerPanel)
			Me.clientPanel.Controls.Add(Me.contactsGridPanel)
			Me.clientPanel.Controls.Add(Me.gradientPanel1)
			Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clientPanel.Location = New System.Drawing.Point(0, 0)
			Me.clientPanel.Name = "clientPanel"
			Me.clientPanel.Size = New System.Drawing.Size(689, 579)
			Me.clientPanel.TabIndex = 4
			' 
			' panel16
			' 
			Me.panel16.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel16.Controls.Add(Me.Display)
			Me.panel16.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel16.Location = New System.Drawing.Point(0, 357)
			Me.panel16.Name = "panel16"
			Me.panel16.Size = New System.Drawing.Size(689, 222)
			Me.panel16.TabIndex = 4
			' 
			' Display
			' 
			Me.Display.BackColor = System.Drawing.SystemColors.Window
			Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.Display.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Display.Location = New System.Drawing.Point(0, 0)
			Me.Display.Name = "Display"
			Me.Display.ReadOnly = True
			Me.Display.Size = New System.Drawing.Size(687, 220)
			Me.Display.TabIndex = 0
			Me.Display.Text = ""
			' 
			' splitter2
			' 
			Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitter2.Location = New System.Drawing.Point(0, 353)
			Me.splitter2.Name = "splitter2"
			Me.splitter2.Size = New System.Drawing.Size(689, 4)
			Me.splitter2.TabIndex = 3
			Me.splitter2.TabStop = False
			' 
			' gridContainerPanel
			' 
			Me.gridContainerPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.gridContainerPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridContainerPanel.Location = New System.Drawing.Point(0, 28)
			Me.gridContainerPanel.Name = "gridContainerPanel"
			Me.gridContainerPanel.Size = New System.Drawing.Size(689, 325)
			Me.gridContainerPanel.TabIndex = 2
			' 
			' scheduleContainerPanel
			' 
			Me.scheduleContainerPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.scheduleContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.scheduleContainerPanel.Location = New System.Drawing.Point(0, 28)
			Me.scheduleContainerPanel.Name = "scheduleContainerPanel"
			Me.scheduleContainerPanel.Size = New System.Drawing.Size(689, 551)
			Me.scheduleContainerPanel.TabIndex = 2
			' 
			' contactsGridPanel
			' 
			Me.contactsGridPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.contactsGridPanel.Location = New System.Drawing.Point(0, 28)
			Me.contactsGridPanel.Name = "contactsGridPanel"
			Me.contactsGridPanel.Size = New System.Drawing.Size(685, 560)
			Me.contactsGridPanel.TabIndex = 5
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(175))))), (CInt(Fix((CByte(210))))), (CInt(Fix((CByte(255)))))))
			Me.gradientPanel1.BorderColor = System.Drawing.Color.MidnightBlue
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.clientPanelImage)
			Me.gradientPanel1.Controls.Add(Me.clientPanelLabel1)
			Me.gradientPanel1.Controls.Add(Me.clientPanelLabel2)
			Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gradientPanel1.Font = New System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientPanel1.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(689, 28)
			Me.gradientPanel1.TabIndex = 1
			' 
			' clientPanelImage
			' 
			Me.clientPanelImage.BackColor = System.Drawing.Color.Transparent
			Me.clientPanelImage.Dock = System.Windows.Forms.DockStyle.Left
			Me.clientPanelImage.ImageIndex = 2
			Me.clientPanelImage.ImageList = Me.smallImageList
			Me.clientPanelImage.Location = New System.Drawing.Point(0, 0)
			Me.clientPanelImage.Name = "clientPanelImage"
			Me.clientPanelImage.Size = New System.Drawing.Size(32, 26)
			Me.clientPanelImage.TabIndex = 3
			' 
			' clientPanelLabel1
			' 
			Me.clientPanelLabel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.clientPanelLabel1.BackColor = System.Drawing.Color.Transparent
			Me.clientPanelLabel1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.clientPanelLabel1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.clientPanelLabel1.Location = New System.Drawing.Point(38, -1)
			Me.clientPanelLabel1.Name = "clientPanelLabel1"
			Me.clientPanelLabel1.Size = New System.Drawing.Size(554, 28)
			Me.clientPanelLabel1.TabIndex = 5
			Me.clientPanelLabel1.Text = "Inbox"
			Me.clientPanelLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' clientPanelLabel2
			' 
			Me.clientPanelLabel2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.clientPanelLabel2.BackColor = System.Drawing.Color.Transparent
			Me.clientPanelLabel2.ForeColor = System.Drawing.Color.White
			Me.clientPanelLabel2.Location = New System.Drawing.Point(598, 0)
			Me.clientPanelLabel2.Name = "clientPanelLabel2"
			Me.clientPanelLabel2.Size = New System.Drawing.Size(88, 28)
			Me.clientPanelLabel2.TabIndex = 4
			Me.clientPanelLabel2.Text = "label12"
			Me.clientPanelLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' statusStripEx1
			' 
			Me.statusStripEx1.AllowItemReorder = True
			Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripStatusLabel1})
			Me.statusStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.statusStripEx1.Location = New System.Drawing.Point(1, 827)
			Me.statusStripEx1.Name = "statusStripEx1"
			Me.statusStripEx1.Size = New System.Drawing.Size(200, 22)
			Me.statusStripEx1.TabIndex = 1003
			Me.statusStripEx1.Text = "statusStripEx1"
			' 
			' toolStripStatusLabel1
			' 
			Me.toolStripStatusLabel1.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
			Me.toolStripStatusLabel1.Size = New System.Drawing.Size(62, 14)
			Me.toolStripStatusLabel1.Text = "Messages"
			' 
			' listView1
			' 
			Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listView1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5})
			Me.listView1.Location = New System.Drawing.Point(1, 27)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New System.Drawing.Size(302, 246)
			Me.listView1.TabIndex = 1
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = System.Windows.Forms.View.List
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
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
			Me.imageList1.Images.SetKeyName(13, "")
			Me.imageList1.Images.SetKeyName(14, "")
			Me.imageList1.Images.SetKeyName(15, "")
			Me.imageList1.Images.SetKeyName(16, "")
			Me.imageList1.Images.SetKeyName(17, "")
			Me.imageList1.Images.SetKeyName(18, "")
			Me.imageList1.Images.SetKeyName(19, "")
			Me.imageList1.Images.SetKeyName(20, "")
			Me.imageList1.Images.SetKeyName(21, "")
			Me.imageList1.Images.SetKeyName(22, "")
			Me.imageList1.Images.SetKeyName(23, "")
			Me.imageList1.Images.SetKeyName(24, "")
			Me.imageList1.Images.SetKeyName(25, "")
			Me.imageList1.Images.SetKeyName(26, "")
			Me.imageList1.Images.SetKeyName(27, "")
			Me.imageList1.Images.SetKeyName(28, "")
			Me.imageList1.Images.SetKeyName(29, "")
			' 
			' splashControl1
			' 
			Me.splashControl1.AutoMode = False
			Me.splashControl1.HostForm = Me
			Me.splashControl1.SplashImage = (CType(resources.GetObject("splashControl1.SplashImage"), System.Drawing.Image))
			' 
			' ribbonControlAdv1
			' 
			Me.ribbonControlAdv1.BackStageView = Me.backStageView1
			Me.ribbonControlAdv1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripFile)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripEdit)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripView)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripGo)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripAction)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripStyle)
			Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
			Me.ribbonControlAdv1.MaximizeToolTip = "Maximize Ribbon"
			Me.ribbonControlAdv1.MenuButtonImage = (CType(resources.GetObject("ribbonControlAdv1.MenuButtonImage"), System.Drawing.Image))
			Me.ribbonControlAdv1.MenuButtonText = ""
			Me.ribbonControlAdv1.MinimizeToolTip = "Minimize Ribbon"
			Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
			' 
			' ribbonControlAdv1.OfficeMenu
			' 
			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnswitch})
			Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
			Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(137, 68)
			Me.ribbonControlAdv1.SelectedTab = Me.toolStripFile
			Me.ribbonControlAdv1.Size = New System.Drawing.Size(872, 156)
			Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
			Me.ribbonControlAdv1.TabIndex = 5
			Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
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
			Me.backStage1.Controls.Add(Me.backStageTab1)
			Me.backStage1.Controls.Add(Me.backStageTab4)
			Me.backStage1.Controls.Add(Me.backStageTab5)
			Me.backStage1.Controls.Add(Me.backStageButton3)
			Me.backStage1.Controls.Add(Me.backStageButton4)
			Me.backStage1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.backStage1.ItemSize = New System.Drawing.Size(130, 30)
			Me.backStage1.Location = New System.Drawing.Point(6, 58)
			Me.backStage1.Name = "backStage1"
			Me.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
			Me.backStage1.Size = New System.Drawing.Size(862, 678)
			Me.backStage1.TabIndex = 6
			Me.backStage1.Visible = False
			' 
			' backStageTab1
			' 
			Me.backStageTab1.BackColor = System.Drawing.Color.White
			Me.backStageTab1.Controls.Add(Me.pictureBox1)
			Me.backStageTab1.Image = Nothing
			Me.backStageTab1.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab1.Location = New System.Drawing.Point(130, 1)
			Me.backStageTab1.Name = "backStageTab1"
			Me.backStageTab1.ShowCloseButton = True
			Me.backStageTab1.Size = New System.Drawing.Size(730, 675)
			Me.backStageTab1.TabIndex = 2
			Me.backStageTab1.Text = "Info"
			Me.backStageTab1.ThemesEnabled = False
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(730, 675)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' backStageTab4
			' 
			Me.backStageTab4.BackColor = System.Drawing.Color.White
			Me.backStageTab4.Controls.Add(Me.pictureBox4)
			Me.backStageTab4.Image = Nothing
			Me.backStageTab4.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab4.Location = New System.Drawing.Point(130, 1)
			Me.backStageTab4.Name = "backStageTab4"
			Me.backStageTab4.ShowCloseButton = True
			Me.backStageTab4.Size = New System.Drawing.Size(730, 675)
			Me.backStageTab4.TabIndex = 3
			Me.backStageTab4.Text = "Open"
			Me.backStageTab4.ThemesEnabled = False
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox4.Image = (CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image))
			Me.pictureBox4.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(730, 675)
			Me.pictureBox4.TabIndex = 0
			Me.pictureBox4.TabStop = False
			' 
			' backStageTab5
			' 
			Me.backStageTab5.BackColor = System.Drawing.Color.White
			Me.backStageTab5.Controls.Add(Me.pictureBox5)
			Me.backStageTab5.Image = Nothing
			Me.backStageTab5.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab5.Location = New System.Drawing.Point(130, 1)
			Me.backStageTab5.Name = "backStageTab5"
			Me.backStageTab5.ShowCloseButton = True
			Me.backStageTab5.Size = New System.Drawing.Size(730, 675)
			Me.backStageTab5.TabIndex = 4
			Me.backStageTab5.Text = "Help"
			Me.backStageTab5.ThemesEnabled = False
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox5.Image = (CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image))
			Me.pictureBox5.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(730, 675)
			Me.pictureBox5.TabIndex = 0
			Me.pictureBox5.TabStop = False
			' 
			' backStageButton3
			' 
			Me.backStageButton3.BackColor = System.Drawing.Color.Transparent
			Me.backStageButton3.Location = New System.Drawing.Point(-37, 90)
			Me.backStageButton3.Name = "backStageButton3"
			Me.backStageButton3.Size = New System.Drawing.Size(75, 23)
			Me.backStageButton3.TabIndex = 5
			Me.backStageButton3.Text = "Switch Style"
'			Me.backStageButton3.Click += New System.EventHandler(Me.backStageButton3_Click)
			' 
			' backStageButton4
			' 
			Me.backStageButton4.BackColor = System.Drawing.Color.Transparent
			Me.backStageButton4.Location = New System.Drawing.Point(-37, 113)
			Me.backStageButton4.Name = "backStageButton4"
			Me.backStageButton4.Size = New System.Drawing.Size(75, 23)
			Me.backStageButton4.TabIndex = 6
			Me.backStageButton4.Text = "       Exit"
'			Me.backStageButton4.Click += New System.EventHandler(Me.backStageButton4_Click)
			' 
			' toolStripFile
			' 
			Me.toolStripFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripFile.Name = "toolStripFile"
			' 
			' ribbonControlAdv1.ribbonPanel1
			' 
			Me.toolStripFile.Panel.Controls.Add(Me.toolStripFileNew)
			Me.toolStripFile.Panel.Controls.Add(Me.toolStripFileSearch)
			Me.toolStripFile.Panel.Controls.Add(Me.toolStripFilePage)
			Me.toolStripFile.Panel.Controls.Add(Me.toolStripFileHelp)
			Me.toolStripFile.Panel.Name = "ribbonPanel1"
			Me.toolStripFile.Panel.ScrollPosition = 0
			Me.toolStripFile.Panel.TabIndex = 2
			Me.toolStripFile.Panel.Text = "File"
			Me.toolStripFile.Position = 0
			Me.toolStripFile.Size = New System.Drawing.Size(33, 21)
			Me.toolStripFile.Text = "File"
			' 
			' toolStripFileNew
			' 
			Me.toolStripFileNew.AutoSize = False
			Me.toolStripFileNew.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripFileNew.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripFileNew.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripFileNew.Image = Nothing
			Me.toolStripFileNew.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripNewPanel})
			Me.toolStripFileNew.Location = New System.Drawing.Point(0, 1)
			Me.toolStripFileNew.Name = "toolStripFileNew"
			Me.toolStripFileNew.Size = New System.Drawing.Size(192, 94)
			Me.toolStripFileNew.TabIndex = 0
			Me.toolStripFileNew.Text = "New"
			' 
			' toolStripNewPanel
			' 
			Me.toolStripNewPanel.CausesValidation = False
			Me.toolStripNewPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripNewPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnmailMessage, Me.toolbtnappointment, Me.toolbtncontact, Me.toolbtntask, Me.toolbtnjournal, Me.toolbtnnotes})
			Me.toolStripNewPanel.Name = "toolStripNewPanel"
			Me.toolStripNewPanel.Size = New System.Drawing.Size(167, 76)
			Me.toolStripNewPanel.Text = "toolStripPanelItem6"
			Me.toolStripNewPanel.Transparent = True
			' 
			' toolbtnmailMessage
			' 
			Me.toolbtnmailMessage.Image = (CType(resources.GetObject("toolbtnmailMessage.Image"), System.Drawing.Image))
			Me.toolbtnmailMessage.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnmailMessage.Name = "toolbtnmailMessage"
			Me.toolbtnmailMessage.Size = New System.Drawing.Size(96, 20)
			Me.toolbtnmailMessage.Text = "MailMessage"
'			Me.toolbtnmailMessage.Click += New System.EventHandler(Me.toolbtnmailMessage_Click)
			' 
			' toolbtnappointment
			' 
			Me.toolbtnappointment.Image = (CType(resources.GetObject("toolbtnappointment.Image"), System.Drawing.Image))
			Me.toolbtnappointment.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnappointment.Name = "toolbtnappointment"
			Me.toolbtnappointment.Size = New System.Drawing.Size(98, 20)
			Me.toolbtnappointment.Text = "Appointment"
'			Me.toolbtnappointment.Click += New System.EventHandler(Me.toolbtnappointment_Click)
			' 
			' toolbtncontact
			' 
			Me.toolbtncontact.Image = (CType(resources.GetObject("toolbtncontact.Image"), System.Drawing.Image))
			Me.toolbtncontact.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtncontact.Name = "toolbtncontact"
			Me.toolbtncontact.Size = New System.Drawing.Size(69, 20)
			Me.toolbtncontact.Text = "Contact"
'			Me.toolbtncontact.Click += New System.EventHandler(Me.toolbtncontact_Click)
			' 
			' toolbtntask
			' 
			Me.toolbtntask.Image = (CType(resources.GetObject("toolbtntask.Image"), System.Drawing.Image))
			Me.toolbtntask.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtntask.Name = "toolbtntask"
			Me.toolbtntask.Size = New System.Drawing.Size(51, 20)
			Me.toolbtntask.Text = "Task"
			' 
			' toolbtnjournal
			' 
			Me.toolbtnjournal.Image = (CType(resources.GetObject("toolbtnjournal.Image"), System.Drawing.Image))
			Me.toolbtnjournal.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnjournal.Name = "toolbtnjournal"
			Me.toolbtnjournal.Size = New System.Drawing.Size(65, 20)
			Me.toolbtnjournal.Text = "Journal"
			' 
			' toolbtnnotes
			' 
			Me.toolbtnnotes.Image = (CType(resources.GetObject("toolbtnnotes.Image"), System.Drawing.Image))
			Me.toolbtnnotes.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnnotes.Name = "toolbtnnotes"
			Me.toolbtnnotes.Size = New System.Drawing.Size(58, 20)
			Me.toolbtnnotes.Text = "Notes"
			' 
			' toolStripFileSearch
			' 
			Me.toolStripFileSearch.AutoSize = False
			Me.toolStripFileSearch.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripFileSearch.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripFileSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripFileSearch.Image = Nothing
			Me.toolStripFileSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripSearchPanel})
			Me.toolStripFileSearch.Location = New System.Drawing.Point(194, 1)
			Me.toolStripFileSearch.Name = "toolStripFileSearch"
			Me.toolStripFileSearch.Size = New System.Drawing.Size(127, 94)
			Me.toolStripFileSearch.TabIndex = 1
			Me.toolStripFileSearch.Text = "Search"
			' 
			' toolStripSearchPanel
			' 
			Me.toolStripSearchPanel.CausesValidation = False
			Me.toolStripSearchPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripSearchPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnfolder, Me.toolbtnsearch})
			Me.toolStripSearchPanel.Name = "toolStripSearchPanel"
			Me.toolStripSearchPanel.Size = New System.Drawing.Size(102, 76)
			Me.toolStripSearchPanel.Text = "toolStripPanelItem6"
			Me.toolStripSearchPanel.Transparent = True
			' 
			' toolbtnfolder
			' 
			Me.toolbtnfolder.Image = (CType(resources.GetObject("toolbtnfolder.Image"), System.Drawing.Image))
			Me.toolbtnfolder.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnfolder.Name = "toolbtnfolder"
			Me.toolbtnfolder.Size = New System.Drawing.Size(60, 20)
			Me.toolbtnfolder.Text = "Folder"
			' 
			' toolbtnsearch
			' 
			Me.toolbtnsearch.Image = (CType(resources.GetObject("toolbtnsearch.Image"), System.Drawing.Image))
			Me.toolbtnsearch.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnsearch.Name = "toolbtnsearch"
			Me.toolbtnsearch.Size = New System.Drawing.Size(98, 20)
			Me.toolbtnsearch.Text = "Search Folder"
			' 
			' toolStripFilePage
			' 
			Me.toolStripFilePage.AutoSize = False
			Me.toolStripFilePage.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripFilePage.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripFilePage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripFilePage.Image = Nothing
			Me.toolStripFilePage.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPagePanel})
			Me.toolStripFilePage.Location = New System.Drawing.Point(323, 1)
			Me.toolStripFilePage.Name = "toolStripFilePage"
			Me.toolStripFilePage.Size = New System.Drawing.Size(126, 94)
			Me.toolStripFilePage.TabIndex = 2
			Me.toolStripFilePage.Text = "Page Setup"
			' 
			' toolStripPagePanel
			' 
			Me.toolStripPagePanel.CausesValidation = False
			Me.toolStripPagePanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPagePanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnpreview, Me.toolbtnprint})
			Me.toolStripPagePanel.Name = "toolStripPagePanel"
			Me.toolStripPagePanel.Size = New System.Drawing.Size(100, 76)
			Me.toolStripPagePanel.Text = "toolStripPanelItem6"
			Me.toolStripPagePanel.Transparent = True
			' 
			' toolbtnpreview
			' 
			Me.toolbtnpreview.Image = (CType(resources.GetObject("toolbtnpreview.Image"), System.Drawing.Image))
			Me.toolbtnpreview.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnpreview.Name = "toolbtnpreview"
			Me.toolbtnpreview.Size = New System.Drawing.Size(96, 20)
			Me.toolbtnpreview.Text = "Print preview"
			' 
			' toolbtnprint
			' 
			Me.toolbtnprint.Image = (CType(resources.GetObject("toolbtnprint.Image"), System.Drawing.Image))
			Me.toolbtnprint.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnprint.Name = "toolbtnprint"
			Me.toolbtnprint.Size = New System.Drawing.Size(52, 20)
			Me.toolbtnprint.Text = "print"
			' 
			' toolStripFileHelp
			' 
			Me.toolStripFileHelp.AutoSize = False
			Me.toolStripFileHelp.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripFileHelp.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripFileHelp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripFileHelp.Image = Nothing
			Me.toolStripFileHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripHelpPanel})
			Me.toolStripFileHelp.Location = New System.Drawing.Point(451, 1)
			Me.toolStripFileHelp.Name = "toolStripFileHelp"
			Me.toolStripFileHelp.Size = New System.Drawing.Size(106, 94)
			Me.toolStripFileHelp.TabIndex = 3
			Me.toolStripFileHelp.Text = "Help"
			' 
			' toolStripHelpPanel
			' 
			Me.toolStripHelpPanel.CausesValidation = False
			Me.toolStripHelpPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripHelpPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnhelp, Me.toolbtnabout, Me.toolbtnexit})
			Me.toolStripHelpPanel.Name = "toolStripHelpPanel"
			Me.toolStripHelpPanel.Size = New System.Drawing.Size(80, 76)
			Me.toolStripHelpPanel.Text = "toolStripPanelItem6"
			Me.toolStripHelpPanel.Transparent = True
			' 
			' toolbtnhelp
			' 
			Me.toolbtnhelp.Image = (CType(resources.GetObject("toolbtnhelp.Image"), System.Drawing.Image))
			Me.toolbtnhelp.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnhelp.Name = "toolbtnhelp"
			Me.toolbtnhelp.Size = New System.Drawing.Size(52, 20)
			Me.toolbtnhelp.Text = "Help"
'			Me.toolbtnhelp.Click += New System.EventHandler(Me.toolbtnhelp_Click)
			' 
			' toolbtnabout
			' 
			Me.toolbtnabout.Image = (CType(resources.GetObject("toolbtnabout.Image"), System.Drawing.Image))
			Me.toolbtnabout.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnabout.Name = "toolbtnabout"
			Me.toolbtnabout.Size = New System.Drawing.Size(76, 20)
			Me.toolbtnabout.Text = "About Us"
'			Me.toolbtnabout.Click += New System.EventHandler(Me.toolbtnabout_Click)
			' 
			' toolbtnexit
			' 
			Me.toolbtnexit.Image = (CType(resources.GetObject("toolbtnexit.Image"), System.Drawing.Image))
			Me.toolbtnexit.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnexit.Name = "toolbtnexit"
			Me.toolbtnexit.Size = New System.Drawing.Size(45, 20)
			Me.toolbtnexit.Text = "Exit"
'			Me.toolbtnexit.Click += New System.EventHandler(Me.toolbtnexit_Click)
			' 
			' toolStripEdit
			' 
			Me.toolStripEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me.toolStripEdit.Name = "toolStripEdit"
			' 
			' ribbonControlAdv1.ribbonPanel2
			' 
			Me.toolStripEdit.Panel.Controls.Add(Me.toolStripEditAction)
			Me.toolStripEdit.Panel.Controls.Add(Me.toolStripEditClipBoard)
			Me.toolStripEdit.Panel.Controls.Add(Me.toolStripEditDelete)
			Me.toolStripEdit.Panel.Name = "ribbonPanel2"
			Me.toolStripEdit.Panel.ScrollPosition = 0
			Me.toolStripEdit.Panel.TabIndex = 3
			Me.toolStripEdit.Panel.Text = "Edit"
			Me.toolStripEdit.Position = 1
			Me.toolStripEdit.Size = New System.Drawing.Size(34, 21)
			Me.toolStripEdit.Text = "Edit"
			' 
			' toolStripEditAction
			' 
			Me.toolStripEditAction.AutoSize = False
			Me.toolStripEditAction.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEditAction.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEditAction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEditAction.Image = Nothing
			Me.toolStripEditAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripActionPanel})
			Me.toolStripEditAction.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEditAction.Name = "toolStripEditAction"
			Me.toolStripEditAction.Size = New System.Drawing.Size(88, 0)
			Me.toolStripEditAction.TabIndex = 0
			Me.toolStripEditAction.Text = "Actions"
			' 
			' toolStripActionPanel
			' 
			Me.toolStripActionPanel.CausesValidation = False
			Me.toolStripActionPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripActionPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnundo, Me.toolbtnredo})
			Me.toolStripActionPanel.Name = "toolStripActionPanel"
			Me.toolStripActionPanel.Size = New System.Drawing.Size(60, 0)
			Me.toolStripActionPanel.Text = "toolStripPanelItem6"
			Me.toolStripActionPanel.Transparent = True
			' 
			' toolbtnundo
			' 
			Me.toolbtnundo.Image = (CType(resources.GetObject("toolbtnundo.Image"), System.Drawing.Image))
			Me.toolbtnundo.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnundo.Name = "toolbtnundo"
			Me.toolbtnundo.Size = New System.Drawing.Size(56, 20)
			Me.toolbtnundo.Text = "Undo"
			' 
			' toolbtnredo
			' 
			Me.toolbtnredo.Image = (CType(resources.GetObject("toolbtnredo.Image"), System.Drawing.Image))
			Me.toolbtnredo.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnredo.Name = "toolbtnredo"
			Me.toolbtnredo.Size = New System.Drawing.Size(54, 20)
			Me.toolbtnredo.Text = "Redo"
			' 
			' toolStripEditClipBoard
			' 
			Me.toolStripEditClipBoard.AutoSize = False
			Me.toolStripEditClipBoard.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEditClipBoard.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEditClipBoard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEditClipBoard.Image = Nothing
			Me.toolStripEditClipBoard.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripClipbdPanel, Me.toolStripClipbd2Panel})
			Me.toolStripEditClipBoard.Location = New System.Drawing.Point(90, 1)
			Me.toolStripEditClipBoard.Name = "toolStripEditClipBoard"
			Me.toolStripEditClipBoard.Size = New System.Drawing.Size(204, 0)
			Me.toolStripEditClipBoard.TabIndex = 1
			Me.toolStripEditClipBoard.Text = "Clipboard"
			' 
			' toolStripClipbdPanel
			' 
			Me.toolStripClipbdPanel.CausesValidation = False
			Me.toolStripClipbdPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripClipbdPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtncopy, Me.toolbtncut})
			Me.toolStripClipbdPanel.Name = "toolStripClipbdPanel"
			Me.toolStripClipbdPanel.Size = New System.Drawing.Size(59, 0)
			Me.toolStripClipbdPanel.Text = "toolStripPanelItem6"
			Me.toolStripClipbdPanel.Transparent = True
			' 
			' toolbtncopy
			' 
			Me.toolbtncopy.Image = (CType(resources.GetObject("toolbtncopy.Image"), System.Drawing.Image))
			Me.toolbtncopy.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtncopy.Name = "toolbtncopy"
			Me.toolbtncopy.Size = New System.Drawing.Size(55, 20)
			Me.toolbtncopy.Text = "Copy"
			' 
			' toolbtncut
			' 
			Me.toolbtncut.Image = (CType(resources.GetObject("toolbtncut.Image"), System.Drawing.Image))
			Me.toolbtncut.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtncut.Name = "toolbtncut"
			Me.toolbtncut.Size = New System.Drawing.Size(46, 20)
			Me.toolbtncut.Text = "Cut"
			' 
			' toolStripClipbd2Panel
			' 
			Me.toolStripClipbd2Panel.CausesValidation = False
			Me.toolStripClipbd2Panel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripClipbd2Panel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnclipboard, Me.toolbtnpaste})
			Me.toolStripClipbd2Panel.Name = "toolStripClipbd2Panel"
			Me.toolStripClipbd2Panel.Size = New System.Drawing.Size(118, 0)
			Me.toolStripClipbd2Panel.Text = "toolStripPanelItem6"
			Me.toolStripClipbd2Panel.Transparent = True
			' 
			' toolbtnclipboard
			' 
			Me.toolbtnclipboard.Image = (CType(resources.GetObject("toolbtnclipboard.Image"), System.Drawing.Image))
			Me.toolbtnclipboard.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnclipboard.Name = "toolbtnclipboard"
			Me.toolbtnclipboard.Size = New System.Drawing.Size(114, 20)
			Me.toolbtnclipboard.Text = "Office Clipboard"
			' 
			' toolbtnpaste
			' 
			Me.toolbtnpaste.Image = (CType(resources.GetObject("toolbtnpaste.Image"), System.Drawing.Image))
			Me.toolbtnpaste.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnpaste.Name = "toolbtnpaste"
			Me.toolbtnpaste.Size = New System.Drawing.Size(55, 20)
			Me.toolbtnpaste.Text = "Paste"
			' 
			' toolStripEditDelete
			' 
			Me.toolStripEditDelete.AutoSize = False
			Me.toolStripEditDelete.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEditDelete.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEditDelete.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEditDelete.Image = Nothing
			Me.toolStripEditDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDeletePanel, Me.toolStripEditDelete2})
			Me.toolStripEditDelete.Location = New System.Drawing.Point(296, 1)
			Me.toolStripEditDelete.Name = "toolStripEditDelete"
			Me.toolStripEditDelete.Size = New System.Drawing.Size(220, 0)
			Me.toolStripEditDelete.TabIndex = 2
			Me.toolStripEditDelete.Text = "Delete"
			' 
			' toolStripDeletePanel
			' 
			Me.toolStripDeletePanel.CausesValidation = False
			Me.toolStripDeletePanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripDeletePanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtndel, Me.toolbtnundel})
			Me.toolStripDeletePanel.Name = "toolStripDeletePanel"
			Me.toolStripDeletePanel.Size = New System.Drawing.Size(78, 0)
			Me.toolStripDeletePanel.Text = "toolStripPanelItem6"
			Me.toolStripDeletePanel.Transparent = True
			' 
			' toolbtndel
			' 
			Me.toolbtndel.Image = (CType(resources.GetObject("toolbtndel.Image"), System.Drawing.Image))
			Me.toolbtndel.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtndel.Name = "toolbtndel"
			Me.toolbtndel.Size = New System.Drawing.Size(60, 20)
			Me.toolbtndel.Text = "Delete"
			' 
			' toolbtnundel
			' 
			Me.toolbtnundel.Image = (CType(resources.GetObject("toolbtnundel.Image"), System.Drawing.Image))
			Me.toolbtnundel.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnundel.Name = "toolbtnundel"
			Me.toolbtnundel.Size = New System.Drawing.Size(74, 20)
			Me.toolbtnundel.Text = "Undelete"
			' 
			' toolStripEditDelete2
			' 
			Me.toolStripEditDelete2.CausesValidation = False
			Me.toolStripEditDelete2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEditDelete2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnmove, Me.toolbtncopyto})
			Me.toolStripEditDelete2.Name = "toolStripEditDelete2"
			Me.toolStripEditDelete2.Size = New System.Drawing.Size(114, 0)
			Me.toolStripEditDelete2.Text = "toolStripPanelItem6"
			Me.toolStripEditDelete2.Transparent = True
			' 
			' toolbtnmove
			' 
			Me.toolbtnmove.Image = (CType(resources.GetObject("toolbtnmove.Image"), System.Drawing.Image))
			Me.toolbtnmove.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnmove.Name = "toolbtnmove"
			Me.toolbtnmove.Size = New System.Drawing.Size(110, 20)
			Me.toolbtnmove.Text = "Move To Folder"
			' 
			' toolbtncopyto
			' 
			Me.toolbtncopyto.Image = (CType(resources.GetObject("toolbtncopyto.Image"), System.Drawing.Image))
			Me.toolbtncopyto.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtncopyto.Name = "toolbtncopyto"
			Me.toolbtncopyto.Size = New System.Drawing.Size(108, 20)
			Me.toolbtncopyto.Text = "Copy To Folder"
			' 
			' toolStripView
			' 
			Me.toolStripView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me.toolStripView.Name = "toolStripView"
			' 
			' ribbonControlAdv1.ribbonPanel3
			' 
			Me.toolStripView.Panel.Controls.Add(Me.toolStripViewArrange)
			Me.toolStripView.Panel.Controls.Add(Me.toolStripViewSwitch)
			Me.toolStripView.Panel.Controls.Add(Me.toolStripViewExp)
			Me.toolStripView.Panel.Controls.Add(Me.toolStripEx5)
			Me.toolStripView.Panel.Name = "ribbonPanel3"
			Me.toolStripView.Panel.ScrollPosition = 0
			Me.toolStripView.Panel.TabIndex = 4
			Me.toolStripView.Panel.Text = "View"
			Me.toolStripView.Position = 2
			Me.toolStripView.Size = New System.Drawing.Size(39, 21)
			Me.toolStripView.Text = "View"
			' 
			' toolStripViewArrange
			' 
			Me.toolStripViewArrange.AutoSize = False
			Me.toolStripViewArrange.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripViewArrange.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripViewArrange.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripViewArrange.Image = Nothing
			Me.toolStripViewArrange.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton14})
			Me.toolStripViewArrange.Location = New System.Drawing.Point(0, 1)
			Me.toolStripViewArrange.Name = "toolStripViewArrange"
			Me.toolStripViewArrange.Size = New System.Drawing.Size(137, 0)
			Me.toolStripViewArrange.TabIndex = 0
			Me.toolStripViewArrange.Text = "Arrange"
			' 
			' toolStripButton14
			' 
			Me.toolStripButton14.Image = (CType(resources.GetObject("toolStripButton14.Image"), System.Drawing.Image))
			Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton14.Name = "toolStripButton14"
			Me.toolStripButton14.Size = New System.Drawing.Size(112, 0)
			Me.toolStripButton14.Text = "Arrange by Date"
			' 
			' toolStripViewSwitch
			' 
			Me.toolStripViewSwitch.AutoSize = False
			Me.toolStripViewSwitch.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripViewSwitch.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripViewSwitch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripViewSwitch.Image = Nothing
			Me.toolStripViewSwitch.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripViewSwitchPanel})
			Me.toolStripViewSwitch.Location = New System.Drawing.Point(139, 1)
			Me.toolStripViewSwitch.Name = "toolStripViewSwitch"
			Me.toolStripViewSwitch.Size = New System.Drawing.Size(143, 0)
			Me.toolStripViewSwitch.TabIndex = 1
			Me.toolStripViewSwitch.Text = "Switch"
			' 
			' toolStripViewSwitchPanel
			' 
			Me.toolStripViewSwitchPanel.CausesValidation = False
			Me.toolStripViewSwitchPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripViewSwitchPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolchknav, Me.toolbtnautoprev})
			Me.toolStripViewSwitchPanel.Name = "toolStripViewSwitchPanel"
			Me.toolStripViewSwitchPanel.Size = New System.Drawing.Size(117, 0)
			Me.toolStripViewSwitchPanel.Text = "toolStripPanelItem6"
			Me.toolStripViewSwitchPanel.Transparent = True
			' 
			' toolchknav
			' 
			Me.toolchknav.Checked = True
			Me.toolchknav.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolchknav.Name = "toolchknav"
			Me.toolchknav.Size = New System.Drawing.Size(113, 19)
			Me.toolchknav.Text = "Navigation Pane"
'			Me.toolchknav.Click += New System.EventHandler(Me.toolchknav_Click)
			' 
			' toolbtnautoprev
			' 
			Me.toolbtnautoprev.Name = "toolbtnautoprev"
			Me.toolbtnautoprev.Size = New System.Drawing.Size(96, 19)
			Me.toolbtnautoprev.Text = "Auto Preview"
'			Me.toolbtnautoprev.Click += New System.EventHandler(Me.toolbtnautoprev_Click)
			' 
			' toolStripViewExp
			' 
			Me.toolStripViewExp.AutoSize = False
			Me.toolStripViewExp.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripViewExp.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripViewExp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripViewExp.Image = Nothing
			Me.toolStripViewExp.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripViewExpand})
			Me.toolStripViewExp.Location = New System.Drawing.Point(284, 1)
			Me.toolStripViewExp.Name = "toolStripViewExp"
			Me.toolStripViewExp.Size = New System.Drawing.Size(160, 0)
			Me.toolStripViewExp.TabIndex = 2
			Me.toolStripViewExp.Text = "Expand/Collapse"
			' 
			' toolStripViewExpand
			' 
			Me.toolStripViewExpand.CausesValidation = False
			Me.toolStripViewExpand.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripViewExpand.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnExpAllGroup, Me.toolbtnCollapse, Me.toolbtnExpthisGroup})
			Me.toolStripViewExpand.Name = "toolStripViewExpand"
			Me.toolStripViewExpand.Size = New System.Drawing.Size(132, 0)
			Me.toolStripViewExpand.Text = "toolStripPanelItem6"
			Me.toolStripViewExpand.Transparent = True
			' 
			' toolbtnExpAllGroup
			' 
			Me.toolbtnExpAllGroup.Image = (CType(resources.GetObject("toolbtnExpAllGroup.Image"), System.Drawing.Image))
			Me.toolbtnExpAllGroup.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnExpAllGroup.Name = "toolbtnExpAllGroup"
			Me.toolbtnExpAllGroup.Size = New System.Drawing.Size(121, 20)
			Me.toolbtnExpAllGroup.Text = "Expand all Groups"
'			Me.toolbtnExpAllGroup.Click += New System.EventHandler(Me.toolbtnExpAllGroup_Click)
			' 
			' toolbtnCollapse
			' 
			Me.toolbtnCollapse.Image = (CType(resources.GetObject("toolbtnCollapse.Image"), System.Drawing.Image))
			Me.toolbtnCollapse.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnCollapse.Name = "toolbtnCollapse"
			Me.toolbtnCollapse.Size = New System.Drawing.Size(128, 20)
			Me.toolbtnCollapse.Text = "Collapse all Groups"
'			Me.toolbtnCollapse.Click += New System.EventHandler(Me.toolbtnCollapse_Click_1)
			' 
			' toolbtnExpthisGroup
			' 
			Me.toolbtnExpthisGroup.Image = (CType(resources.GetObject("toolbtnExpthisGroup.Image"), System.Drawing.Image))
			Me.toolbtnExpthisGroup.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnExpthisGroup.Name = "toolbtnExpthisGroup"
			Me.toolbtnExpthisGroup.Size = New System.Drawing.Size(123, 20)
			Me.toolbtnExpthisGroup.Text = "Expand this Group"
'			Me.toolbtnExpthisGroup.Click += New System.EventHandler(Me.toolbtnExpthisGroup_Click)
			' 
			' toolStripEx5
			' 
			Me.toolStripEx5.AutoSize = False
			Me.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx5.Image = Nothing
			Me.toolStripEx5.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripReadPane})
			Me.toolStripEx5.Location = New System.Drawing.Point(446, 1)
			Me.toolStripEx5.Name = "toolStripEx5"
			Me.toolStripEx5.Size = New System.Drawing.Size(80, 0)
			Me.toolStripEx5.TabIndex = 3
			Me.toolStripEx5.Text = "Reading Pane"
			' 
			' toolStripReadPane
			' 
			Me.toolStripReadPane.CausesValidation = False
			Me.toolStripReadPane.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripReadPane.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnRight, Me.toolbtnBottom, Me.toolbtnTop})
			Me.toolStripReadPane.Name = "toolStripReadPane"
			Me.toolStripReadPane.Size = New System.Drawing.Size(55, 0)
			Me.toolStripReadPane.Text = "toolStripPanelItem6"
			Me.toolStripReadPane.Transparent = True
			' 
			' toolbtnRight
			' 
			Me.toolbtnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolbtnRight.Image = (CType(resources.GetObject("toolbtnRight.Image"), System.Drawing.Image))
			Me.toolbtnRight.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnRight.Name = "toolbtnRight"
			Me.toolbtnRight.Size = New System.Drawing.Size(39, 19)
			Me.toolbtnRight.Text = "Right"
'			Me.toolbtnRight.Click += New System.EventHandler(Me.toolbtnRight_Click)
			' 
			' toolbtnBottom
			' 
			Me.toolbtnBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolbtnBottom.Image = (CType(resources.GetObject("toolbtnBottom.Image"), System.Drawing.Image))
			Me.toolbtnBottom.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnBottom.Name = "toolbtnBottom"
			Me.toolbtnBottom.Size = New System.Drawing.Size(51, 19)
			Me.toolbtnBottom.Text = "Bottom"
'			Me.toolbtnBottom.Click += New System.EventHandler(Me.toolbtnBottom_Click)
			' 
			' toolbtnTop
			' 
			Me.toolbtnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolbtnTop.Image = (CType(resources.GetObject("toolbtnTop.Image"), System.Drawing.Image))
			Me.toolbtnTop.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnTop.Name = "toolbtnTop"
			Me.toolbtnTop.Size = New System.Drawing.Size(28, 19)
			Me.toolbtnTop.Text = "Off"
'			Me.toolbtnTop.Click += New System.EventHandler(Me.toolbtnTop_Click)
			' 
			' toolStripGo
			' 
			Me.toolStripGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me.toolStripGo.Name = "toolStripGo"
			' 
			' ribbonControlAdv1.ribbonPanel4
			' 
			Me.toolStripGo.Panel.Controls.Add(Me.toolStripGoItems)
			Me.toolStripGo.Panel.Controls.Add(Me.toolStripGoMisc)
			Me.toolStripGo.Panel.Name = "ribbonPanel4"
			Me.toolStripGo.Panel.ScrollPosition = 0
			Me.toolStripGo.Panel.TabIndex = 5
			Me.toolStripGo.Panel.Text = "Go"
			Me.toolStripGo.Position = 3
			Me.toolStripGo.Size = New System.Drawing.Size(29, 21)
			Me.toolStripGo.Text = "Go"
			' 
			' toolStripGoItems
			' 
			Me.toolStripGoItems.AutoSize = False
			Me.toolStripGoItems.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripGoItems.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripGoItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripGoItems.Image = Nothing
			Me.toolStripGoItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripGoItemsPanel})
			Me.toolStripGoItems.Location = New System.Drawing.Point(0, 1)
			Me.toolStripGoItems.Name = "toolStripGoItems"
			Me.toolStripGoItems.Size = New System.Drawing.Size(176, 0)
			Me.toolStripGoItems.TabIndex = 0
			Me.toolStripGoItems.Text = "Items"
			' 
			' toolStripGoItemsPanel
			' 
			Me.toolStripGoItemsPanel.CausesValidation = False
			Me.toolStripGoItemsPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripGoItemsPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnmail, Me.toolbtncalndr, Me.toolbtncnt, Me.toolbtntasks, Me.toolbtnGonote})
			Me.toolStripGoItemsPanel.Name = "toolStripGoItemsPanel"
			Me.toolStripGoItemsPanel.Size = New System.Drawing.Size(136, 0)
			Me.toolStripGoItemsPanel.Text = "toolStripPanelItem6"
			Me.toolStripGoItemsPanel.Transparent = True
			' 
			' toolbtnmail
			' 
			Me.toolbtnmail.CheckOnClick = True
			Me.toolbtnmail.Image = (CType(resources.GetObject("toolbtnmail.Image"), System.Drawing.Image))
			Me.toolbtnmail.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnmail.Name = "toolbtnmail"
			Me.toolbtnmail.Size = New System.Drawing.Size(50, 20)
			Me.toolbtnmail.Text = "Mail"
'			Me.toolbtnmail.Click += New System.EventHandler(Me.toolbtnmail_Click)
			' 
			' toolbtncalndr
			' 
			Me.toolbtncalndr.CheckOnClick = True
			Me.toolbtncalndr.Image = (CType(resources.GetObject("toolbtncalndr.Image"), System.Drawing.Image))
			Me.toolbtncalndr.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtncalndr.Name = "toolbtncalndr"
			Me.toolbtncalndr.Size = New System.Drawing.Size(74, 20)
			Me.toolbtncalndr.Text = "Calendar"
'			Me.toolbtncalndr.Click += New System.EventHandler(Me.toolbtncalndr_Click)
			' 
			' toolbtncnt
			' 
			Me.toolbtncnt.CheckOnClick = True
			Me.toolbtncnt.Image = (CType(resources.GetObject("toolbtncnt.Image"), System.Drawing.Image))
			Me.toolbtncnt.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtncnt.Name = "toolbtncnt"
			Me.toolbtncnt.Size = New System.Drawing.Size(74, 20)
			Me.toolbtncnt.Text = "Contacts"
'			Me.toolbtncnt.Click += New System.EventHandler(Me.toolbtncnt_Click)
			' 
			' toolbtntasks
			' 
			Me.toolbtntasks.CheckOnClick = True
			Me.toolbtntasks.Image = (CType(resources.GetObject("toolbtntasks.Image"), System.Drawing.Image))
			Me.toolbtntasks.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtntasks.Name = "toolbtntasks"
			Me.toolbtntasks.Size = New System.Drawing.Size(56, 20)
			Me.toolbtntasks.Text = "Tasks"
'			Me.toolbtntasks.Click += New System.EventHandler(Me.toolbtntasks_Click)
			' 
			' toolbtnGonote
			' 
			Me.toolbtnGonote.CheckOnClick = True
			Me.toolbtnGonote.Image = (CType(resources.GetObject("toolbtnGonote.Image"), System.Drawing.Image))
			Me.toolbtnGonote.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnGonote.Name = "toolbtnGonote"
			Me.toolbtnGonote.Size = New System.Drawing.Size(58, 20)
			Me.toolbtnGonote.Text = "Notes"
'			Me.toolbtnGonote.Click += New System.EventHandler(Me.toolbtnGonote_Click)
			' 
			' toolStripGoMisc
			' 
			Me.toolStripGoMisc.AutoSize = False
			Me.toolStripGoMisc.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripGoMisc.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripGoMisc.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripGoMisc.Image = Nothing
			Me.toolStripGoMisc.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripGoMiscPanel})
			Me.toolStripGoMisc.Location = New System.Drawing.Point(178, 1)
			Me.toolStripGoMisc.Name = "toolStripGoMisc"
			Me.toolStripGoMisc.Size = New System.Drawing.Size(100, 0)
			Me.toolStripGoMisc.TabIndex = 1
			Me.toolStripGoMisc.Text = "Misc"
			' 
			' toolStripGoMiscPanel
			' 
			Me.toolStripGoMiscPanel.CausesValidation = False
			Me.toolStripGoMiscPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripGoMiscPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnfolderlist, Me.toolbtnGojournal})
			Me.toolStripGoMiscPanel.Name = "toolStripGoMiscPanel"
			Me.toolStripGoMiscPanel.Size = New System.Drawing.Size(85, 0)
			Me.toolStripGoMiscPanel.Text = "toolStripPanelItem6"
			Me.toolStripGoMiscPanel.Transparent = True
			' 
			' toolbtnfolderlist
			' 
			Me.toolbtnfolderlist.CheckOnClick = True
			Me.toolbtnfolderlist.Image = (CType(resources.GetObject("toolbtnfolderlist.Image"), System.Drawing.Image))
			Me.toolbtnfolderlist.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnfolderlist.Name = "toolbtnfolderlist"
			Me.toolbtnfolderlist.Size = New System.Drawing.Size(81, 20)
			Me.toolbtnfolderlist.Text = "Folder List"
'			Me.toolbtnfolderlist.Click += New System.EventHandler(Me.toolbtnfolderlist_Click)
			' 
			' toolbtnGojournal
			' 
			Me.toolbtnGojournal.CheckOnClick = True
			Me.toolbtnGojournal.Image = (CType(resources.GetObject("toolbtnGojournal.Image"), System.Drawing.Image))
			Me.toolbtnGojournal.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnGojournal.Name = "toolbtnGojournal"
			Me.toolbtnGojournal.Size = New System.Drawing.Size(70, 20)
			Me.toolbtnGojournal.Text = "Journals"
'			Me.toolbtnGojournal.Click += New System.EventHandler(Me.toolbtnGojournal_Click)
			' 
			' toolStripAction
			' 
			Me.toolStripAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me.toolStripAction.Name = "toolStripAction"
			' 
			' ribbonControlAdv1.ribbonPanel5
			' 
			Me.toolStripAction.Panel.Controls.Add(Me.toolStripActionsMail)
			Me.toolStripAction.Panel.Controls.Add(Me.toolStripActionRespond)
			Me.toolStripAction.Panel.Name = "ribbonPanel5"
			Me.toolStripAction.Panel.ScrollPosition = 0
			Me.toolStripAction.Panel.TabIndex = 6
			Me.toolStripAction.Panel.Text = "Actions"
			Me.toolStripAction.Position = 4
			Me.toolStripAction.Size = New System.Drawing.Size(52, 21)
			Me.toolStripAction.Text = "Actions"
			' 
			' toolStripActionsMail
			' 
			Me.toolStripActionsMail.AutoSize = False
			Me.toolStripActionsMail.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripActionsMail.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripActionsMail.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripActionsMail.Image = Nothing
			Me.toolStripActionsMail.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripActionMailPanel})
			Me.toolStripActionsMail.Location = New System.Drawing.Point(0, 1)
			Me.toolStripActionsMail.Name = "toolStripActionsMail"
			Me.toolStripActionsMail.Size = New System.Drawing.Size(158, 0)
			Me.toolStripActionsMail.TabIndex = 0
			Me.toolStripActionsMail.Text = "Mail"
			' 
			' toolStripActionMailPanel
			' 
			Me.toolStripActionMailPanel.CausesValidation = False
			Me.toolStripActionMailPanel.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripActionMailPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnActionmail, Me.toolbtnJunk})
			Me.toolStripActionMailPanel.Name = "toolStripActionMailPanel"
			Me.toolStripActionMailPanel.Size = New System.Drawing.Size(127, 0)
			Me.toolStripActionMailPanel.Text = "toolStripPanelItem6"
			Me.toolStripActionMailPanel.Transparent = True
			' 
			' toolbtnActionmail
			' 
			Me.toolbtnActionmail.Image = (CType(resources.GetObject("toolbtnActionmail.Image"), System.Drawing.Image))
			Me.toolbtnActionmail.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnActionmail.Name = "toolbtnActionmail"
			Me.toolbtnActionmail.Size = New System.Drawing.Size(123, 20)
			Me.toolbtnActionmail.Text = "New MailMessage"
			' 
			' toolbtnJunk
			' 
			Me.toolbtnJunk.Image = (CType(resources.GetObject("toolbtnJunk.Image"), System.Drawing.Image))
			Me.toolbtnJunk.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnJunk.Name = "toolbtnJunk"
			Me.toolbtnJunk.Size = New System.Drawing.Size(77, 20)
			Me.toolbtnJunk.Text = "Junk Mail"
			' 
			' toolStripActionRespond
			' 
			Me.toolStripActionRespond.AutoSize = False
			Me.toolStripActionRespond.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripActionRespond.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripActionRespond.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripActionRespond.Image = Nothing
			Me.toolStripActionRespond.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnreply, Me.toolStripSeparator2, Me.toolbtnreplyall, Me.toolStripSeparator1, Me.toolbtnfwd, Me.toolStripSeparator5, Me.toolStripPanelItem6})
			Me.toolStripActionRespond.Location = New System.Drawing.Point(160, 1)
			Me.toolStripActionRespond.Name = "toolStripActionRespond"
			Me.toolStripActionRespond.Size = New System.Drawing.Size(284, 0)
			Me.toolStripActionRespond.TabIndex = 1
			Me.toolStripActionRespond.Text = "Respond"
			' 
			' toolbtnreply
			' 
			Me.toolbtnreply.Image = (CType(resources.GetObject("toolbtnreply.Image"), System.Drawing.Image))
			Me.toolbtnreply.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnreply.Name = "toolbtnreply"
			Me.toolbtnreply.Size = New System.Drawing.Size(40, 0)
			Me.toolbtnreply.Text = "Reply"
			Me.toolbtnreply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 0)
			' 
			' toolbtnreplyall
			' 
			Me.toolbtnreplyall.Image = (CType(resources.GetObject("toolbtnreplyall.Image"), System.Drawing.Image))
			Me.toolbtnreplyall.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnreplyall.Name = "toolbtnreplyall"
			Me.toolbtnreplyall.Size = New System.Drawing.Size(71, 0)
			Me.toolbtnreplyall.Text = "Reply to All"
			Me.toolbtnreplyall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 0)
			' 
			' toolbtnfwd
			' 
			Me.toolbtnfwd.Image = (CType(resources.GetObject("toolbtnfwd.Image"), System.Drawing.Image))
			Me.toolbtnfwd.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnfwd.Name = "toolbtnfwd"
			Me.toolbtnfwd.Size = New System.Drawing.Size(54, 0)
			Me.toolbtnfwd.Text = "Forward"
			Me.toolbtnfwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripSeparator5
			' 
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 0)
			' 
			' toolStripPanelItem6
			' 
			Me.toolStripPanelItem6.CausesValidation = False
			Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnMeeting, Me.toolbtnMore})
			Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
			Me.toolStripPanelItem6.Size = New System.Drawing.Size(75, 0)
			Me.toolStripPanelItem6.Text = "toolStripActionsPanel"
			Me.toolStripPanelItem6.Transparent = True
			' 
			' toolbtnMeeting
			' 
			Me.toolbtnMeeting.Image = (CType(resources.GetObject("toolbtnMeeting.Image"), System.Drawing.Image))
			Me.toolbtnMeeting.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnMeeting.Name = "toolbtnMeeting"
			Me.toolbtnMeeting.Size = New System.Drawing.Size(71, 20)
			Me.toolbtnMeeting.Text = "Meeting"
			' 
			' toolbtnMore
			' 
			Me.toolbtnMore.Image = (CType(resources.GetObject("toolbtnMore.Image"), System.Drawing.Image))
			Me.toolbtnMore.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnMore.Name = "toolbtnMore"
			Me.toolbtnMore.Size = New System.Drawing.Size(55, 20)
			Me.toolbtnMore.Text = "More"
			' 
			' toolStripStyle
			' 
			Me.toolStripStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me.toolStripStyle.Name = "toolStripStyle"
			' 
			' ribbonControlAdv1.ribbonPanel6
			' 
			Me.toolStripStyle.Panel.Controls.Add(Me.toolStripStyles)
			Me.toolStripStyle.Panel.Name = "ribbonPanel6"
			Me.toolStripStyle.Panel.ScrollPosition = 0
			Me.toolStripStyle.Panel.TabIndex = 7
			Me.toolStripStyle.Panel.Text = "OfficeThemeStyles"
			Me.toolStripStyle.Position = 5
			Me.toolStripStyle.Size = New System.Drawing.Size(115, 21)
			Me.toolStripStyle.Text = "OfficeThemeStyles"
			' 
			' toolStripStyles
			' 
			Me.toolStripStyles.AutoSize = False
			Me.toolStripStyles.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripStyles.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripStyles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripStyles.Image = Nothing
			Me.toolStripStyles.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolbtnstyleBlue, Me.toolStripSeparator3, Me.toolbtnstyleBlack, Me.toolStripSeparator4, Me.toolbtnstyleSilver})
			Me.toolStripStyles.Location = New System.Drawing.Point(0, 1)
			Me.toolStripStyles.Name = "toolStripStyles"
			Me.toolStripStyles.Size = New System.Drawing.Size(203, 0)
			Me.toolStripStyles.TabIndex = 0
			Me.toolStripStyles.Text = "Skins"
			' 
			' toolbtnstyleBlue
			' 
			Me.toolbtnstyleBlue.CheckOnClick = True
			Me.toolbtnstyleBlue.Image = (CType(resources.GetObject("toolbtnstyleBlue.Image"), System.Drawing.Image))
			Me.toolbtnstyleBlue.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnstyleBlue.Name = "toolbtnstyleBlue"
			Me.toolbtnstyleBlue.Size = New System.Drawing.Size(50, 0)
			Me.toolbtnstyleBlue.Text = "Blue"
'			Me.toolbtnstyleBlue.Click += New System.EventHandler(Me.toolbtnstyleBlue_Click)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 0)
			' 
			' toolbtnstyleBlack
			' 
			Me.toolbtnstyleBlack.CheckOnClick = True
			Me.toolbtnstyleBlack.Image = (CType(resources.GetObject("toolbtnstyleBlack.Image"), System.Drawing.Image))
			Me.toolbtnstyleBlack.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnstyleBlack.Name = "toolbtnstyleBlack"
			Me.toolbtnstyleBlack.Size = New System.Drawing.Size(55, 0)
			Me.toolbtnstyleBlack.Text = "Black"
'			Me.toolbtnstyleBlack.Click += New System.EventHandler(Me.toolbtnstyleBlack_Click)
			' 
			' toolStripSeparator4
			' 
			Me.toolStripSeparator4.Name = "toolStripSeparator4"
			Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 0)
			' 
			' toolbtnstyleSilver
			' 
			Me.toolbtnstyleSilver.CheckOnClick = True
			Me.toolbtnstyleSilver.Image = (CType(resources.GetObject("toolbtnstyleSilver.Image"), System.Drawing.Image))
			Me.toolbtnstyleSilver.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnstyleSilver.Name = "toolbtnstyleSilver"
			Me.toolbtnstyleSilver.Size = New System.Drawing.Size(55, 0)
			Me.toolbtnstyleSilver.Text = "Silver"
'			Me.toolbtnstyleSilver.Click += New System.EventHandler(Me.toolbtnstyleSilver_Click)
			' 
			' toolbtnswitch
			' 
			Me.toolbtnswitch.BackColor = System.Drawing.Color.Transparent
			Me.toolbtnswitch.Image = (CType(resources.GetObject("toolbtnswitch.Image"), System.Drawing.Image))
			Me.toolbtnswitch.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolbtnswitch.Name = "toolbtnswitch"
			Me.toolbtnswitch.Size = New System.Drawing.Size(125, 20)
			Me.toolbtnswitch.Text = "Switch Office Style"
'			Me.toolbtnswitch.Click += New System.EventHandler(Me.toolStripButton13_Click)
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.AutoSize = False
			Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx1.Image = Nothing
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem1})
			Me.toolStripEx1.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.Size = New System.Drawing.Size(94, 91)
			Me.toolStripEx1.TabIndex = 0
			' 
			' toolStripPanelItem1
			' 
			Me.toolStripPanelItem1.CausesValidation = False
			Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripButton2})
			Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
			Me.toolStripPanelItem1.Size = New System.Drawing.Size(60, 76)
			Me.toolStripPanelItem1.Transparent = True
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(56, 20)
			Me.toolStripButton1.Text = "Undo"
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(54, 20)
			Me.toolStripButton2.Text = "Redo"
			' 
			' toolStripEx2
			' 
			Me.toolStripEx2.AutoSize = False
			Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx2.Image = Nothing
			Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem2})
			Me.toolStripEx2.Location = New System.Drawing.Point(96, 1)
			Me.toolStripEx2.Name = "toolStripEx2"
			Me.toolStripEx2.Size = New System.Drawing.Size(201, 91)
			Me.toolStripEx2.TabIndex = 1
			' 
			' toolStripPanelItem2
			' 
			Me.toolStripPanelItem2.CausesValidation = False
			Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton3, Me.toolStripButton4, Me.toolStripButton5, Me.toolStripButton6, Me.toolStripLabel1})
			Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
			Me.toolStripPanelItem2.Size = New System.Drawing.Size(173, 76)
			Me.toolStripPanelItem2.Transparent = True
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(46, 20)
			Me.toolStripButton3.Text = "Cut"
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(55, 20)
			Me.toolStripButton4.Text = "Copy"
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(55, 20)
			Me.toolStripButton5.Text = "Paste"
			' 
			' toolStripButton6
			' 
			Me.toolStripButton6.Image = (CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image))
			Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton6.Name = "toolStripButton6"
			Me.toolStripButton6.Size = New System.Drawing.Size(114, 20)
			Me.toolStripButton6.Text = "Office Clipboard"
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Image = (CType(resources.GetObject("toolStripLabel1.Image"), System.Drawing.Image))
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(71, 16)
			Me.toolStripLabel1.Text = "Select All"
			' 
			' toolStripEx3
			' 
			Me.toolStripEx3.AutoSize = False
			Me.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx3.Image = Nothing
			Me.toolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem3, Me.toolStripPanelItem4})
			Me.toolStripEx3.Location = New System.Drawing.Point(299, 1)
			Me.toolStripEx3.Name = "toolStripEx3"
			Me.toolStripEx3.Size = New System.Drawing.Size(220, 91)
			Me.toolStripEx3.TabIndex = 2
			' 
			' toolStripPanelItem3
			' 
			Me.toolStripPanelItem3.CausesValidation = False
			Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton7, Me.toolStripButton10})
			Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
			Me.toolStripPanelItem3.Size = New System.Drawing.Size(79, 76)
			Me.toolStripPanelItem3.Transparent = True
			' 
			' toolStripButton7
			' 
			Me.toolStripButton7.Image = (CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image))
			Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton7.Name = "toolStripButton7"
			Me.toolStripButton7.Size = New System.Drawing.Size(60, 20)
			Me.toolStripButton7.Text = "Delete"
			' 
			' toolStripButton10
			' 
			Me.toolStripButton10.Image = (CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image))
			Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton10.Name = "toolStripButton10"
			Me.toolStripButton10.Size = New System.Drawing.Size(75, 20)
			Me.toolStripButton10.Text = "UnDelete"
			' 
			' toolStripPanelItem4
			' 
			Me.toolStripPanelItem4.CausesValidation = False
			Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton8, Me.toolStripButton9})
			Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
			Me.toolStripPanelItem4.Size = New System.Drawing.Size(114, 76)
			Me.toolStripPanelItem4.Transparent = True
			' 
			' toolStripButton8
			' 
			Me.toolStripButton8.Image = (CType(resources.GetObject("toolStripButton8.Image"), System.Drawing.Image))
			Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton8.Name = "toolStripButton8"
			Me.toolStripButton8.Size = New System.Drawing.Size(110, 20)
			Me.toolStripButton8.Text = "Move To Folder"
			' 
			' toolStripButton9
			' 
			Me.toolStripButton9.Image = (CType(resources.GetObject("toolStripButton9.Image"), System.Drawing.Image))
			Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton9.Name = "toolStripButton9"
			Me.toolStripButton9.Size = New System.Drawing.Size(108, 20)
			Me.toolStripButton9.Text = "Copy To Folder"
			' 
			' toolStripEx4
			' 
			Me.toolStripEx4.AutoSize = False
			Me.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx4.Image = Nothing
			Me.toolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem5})
			Me.toolStripEx4.Location = New System.Drawing.Point(521, 1)
			Me.toolStripEx4.Name = "toolStripEx4"
			Me.toolStripEx4.Size = New System.Drawing.Size(144, 91)
			Me.toolStripEx4.TabIndex = 3
			' 
			' toolStripPanelItem5
			' 
			Me.toolStripPanelItem5.CausesValidation = False
			Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton11, Me.toolStripButton12})
			Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
			Me.toolStripPanelItem5.Size = New System.Drawing.Size(113, 76)
			Me.toolStripPanelItem5.Transparent = True
			' 
			' toolStripButton11
			' 
			Me.toolStripButton11.Image = (CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image))
			Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton11.Name = "toolStripButton11"
			Me.toolStripButton11.Size = New System.Drawing.Size(97, 20)
			Me.toolStripButton11.Text = "Mark as Read"
			' 
			' toolStripButton12
			' 
			Me.toolStripButton12.Image = (CType(resources.GetObject("toolStripButton12.Image"), System.Drawing.Image))
			Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton12.Name = "toolStripButton12"
			Me.toolStripButton12.Size = New System.Drawing.Size(109, 20)
			Me.toolStripButton12.Text = "Mark as Unread"
			' 
			' backStageTab2
			' 
			Me.backStageTab2.BackColor = System.Drawing.Color.White
			Me.backStageTab2.Controls.Add(Me.pictureBox2)
			Me.backStageTab2.Image = Nothing
			Me.backStageTab2.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab2.Location = New System.Drawing.Point(130, 1)
			Me.backStageTab2.Name = "backStageTab2"
			Me.backStageTab2.ShowCloseButton = True
			Me.backStageTab2.Size = New System.Drawing.Size(742, 686)
			Me.backStageTab2.TabFont = Nothing
			Me.backStageTab2.TabIndex = 3
			Me.backStageTab2.Text = "Open"
			Me.backStageTab2.ThemesEnabled = False
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox2.Image = (CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image))
			Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(742, 686)
			Me.pictureBox2.TabIndex = 0
			Me.pictureBox2.TabStop = False
			' 
			' backStageTab3
			' 
			Me.backStageTab3.BackColor = System.Drawing.Color.White
			Me.backStageTab3.Controls.Add(Me.pictureBox3)
			Me.backStageTab3.Image = Nothing
			Me.backStageTab3.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab3.Location = New System.Drawing.Point(130, 1)
			Me.backStageTab3.Name = "backStageTab3"
			Me.backStageTab3.ShowCloseButton = True
			Me.backStageTab3.Size = New System.Drawing.Size(742, 686)
			Me.backStageTab3.TabFont = Nothing
			Me.backStageTab3.TabIndex = 4
			Me.backStageTab3.Text = "Help"
			Me.backStageTab3.ThemesEnabled = False
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox3.Image = (CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image))
			Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(742, 686)
			Me.pictureBox3.TabIndex = 0
			Me.pictureBox3.TabStop = False
			' 
			' backStageButton1
			' 
			Me.backStageButton1.BackColor = System.Drawing.Color.Transparent
			Me.backStageButton1.Location = New System.Drawing.Point(27, 90)
			Me.backStageButton1.Name = "backStageButton1"
			Me.backStageButton1.Size = New System.Drawing.Size(75, 23)
			Me.backStageButton1.TabIndex = 5
			Me.backStageButton1.Text = "Switch Style"
			' 
			' backStageButton2
			' 
			Me.backStageButton2.BackColor = System.Drawing.Color.Transparent
			Me.backStageButton2.Location = New System.Drawing.Point(27, 113)
			Me.backStageButton2.Name = "backStageButton2"
			Me.backStageButton2.Size = New System.Drawing.Size(75, 23)
			Me.backStageButton2.TabIndex = 6
			Me.backStageButton2.Text = "       Exit"
'			Me.backStageButton2.Click += New System.EventHandler(Me.backStageButton2_Click)
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(874, 742)
			Me.Controls.Add(Me.backStage1)
			Me.Controls.Add(Me.parentPanel)
			Me.Controls.Add(Me.ribbonControlAdv1)
			Me.HelpButtonImage = (CType(resources.GetObject("$this.HelpButtonImage"), System.Drawing.Image))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Outlook Demo"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.parentPanel.ResumeLayout(False)
			Me.parentPanel.PerformLayout()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			'((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBar1.ResumeLayout(False)
			Me.contactsPanel.ResumeLayout(False)
			CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel5.ResumeLayout(False)
			Me.gradientPanel5.PerformLayout()
			CType(Me.xpTaskBar2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar2.ResumeLayout(False)
			Me.currentViewTaskBarBox.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.journalPanel.ResumeLayout(False)
			CType(Me.gradientPanel10, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel10.ResumeLayout(False)
			Me.gradientPanel10.PerformLayout()
			CType(Me.xpTaskBar6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar6.ResumeLayout(False)
			Me.currentViewTaskBarBox3.ResumeLayout(False)
			Me.panel14.ResumeLayout(False)
			Me.panel14.PerformLayout()
			Me.folderlistPanel.ResumeLayout(False)
			CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel8.ResumeLayout(False)
			Me.panel6.ResumeLayout(False)
			CType(Me.xpTaskBar5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar5.ResumeLayout(False)
			Me.allFoldersTaskBarBox.ResumeLayout(False)
			CType(Me.gradientPanel9, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel9.ResumeLayout(False)
			Me.calendarPanel.ResumeLayout(False)
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel3.ResumeLayout(False)
			Me.gradientPanel3.PerformLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			Me.myCalendarsTaskBarBox1.ResumeLayout(False)
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel4.ResumeLayout(False)
			Me.gradientPanel4.PerformLayout()
			Me.mailPanel.ResumeLayout(False)
			CType(Me.mailTaskBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mailTaskBar.ResumeLayout(False)
			Me.mailTaskBarBox.ResumeLayout(False)
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel2.ResumeLayout(False)
			Me.notesPanel.ResumeLayout(False)
			CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel7.ResumeLayout(False)
			Me.gradientPanel7.PerformLayout()
			CType(Me.xpTaskBar4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar4.ResumeLayout(False)
			Me.currentViewTaskBarBox2.ResumeLayout(False)
			Me.panel9.ResumeLayout(False)
			Me.tasksPanel.ResumeLayout(False)
			CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel6.ResumeLayout(False)
			Me.gradientPanel6.PerformLayout()
			CType(Me.xpTaskBar3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar3.ResumeLayout(False)
			Me.currentViewTaskBarBox1.ResumeLayout(False)
			Me.panel7.ResumeLayout(False)
			Me.panel7.PerformLayout()
			Me.clientPanel.ResumeLayout(False)
			Me.panel16.ResumeLayout(False)
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.statusStripEx1.ResumeLayout(False)
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ribbonControlAdv1.ResumeLayout(False)
			Me.ribbonControlAdv1.PerformLayout()
			CType(Me.backStage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backStage1.ResumeLayout(False)
			Me.backStageTab1.ResumeLayout(False)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backStageTab4.ResumeLayout(False)
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backStageTab5.ResumeLayout(False)
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolStripFile.Panel.ResumeLayout(False)
			Me.toolStripFileNew.ResumeLayout(False)
			Me.toolStripFileNew.PerformLayout()
			Me.toolStripFileSearch.ResumeLayout(False)
			Me.toolStripFileSearch.PerformLayout()
			Me.toolStripFilePage.ResumeLayout(False)
			Me.toolStripFilePage.PerformLayout()
			Me.toolStripFileHelp.ResumeLayout(False)
			Me.toolStripFileHelp.PerformLayout()
			Me.toolStripEdit.Panel.ResumeLayout(False)
			Me.toolStripEditAction.ResumeLayout(False)
			Me.toolStripEditAction.PerformLayout()
			Me.toolStripEditClipBoard.ResumeLayout(False)
			Me.toolStripEditClipBoard.PerformLayout()
			Me.toolStripEditDelete.ResumeLayout(False)
			Me.toolStripEditDelete.PerformLayout()
			Me.toolStripView.Panel.ResumeLayout(False)
			Me.toolStripViewArrange.ResumeLayout(False)
			Me.toolStripViewArrange.PerformLayout()
			Me.toolStripViewSwitch.ResumeLayout(False)
			Me.toolStripViewSwitch.PerformLayout()
			Me.toolStripViewExp.ResumeLayout(False)
			Me.toolStripViewExp.PerformLayout()
			Me.toolStripEx5.ResumeLayout(False)
			Me.toolStripEx5.PerformLayout()
			Me.toolStripGo.Panel.ResumeLayout(False)
			Me.toolStripGoItems.ResumeLayout(False)
			Me.toolStripGoItems.PerformLayout()
			Me.toolStripGoMisc.ResumeLayout(False)
			Me.toolStripGoMisc.PerformLayout()
			Me.toolStripAction.Panel.ResumeLayout(False)
			Me.toolStripActionsMail.ResumeLayout(False)
			Me.toolStripActionsMail.PerformLayout()
			Me.toolStripActionRespond.ResumeLayout(False)
			Me.toolStripActionRespond.PerformLayout()
			Me.toolStripStyle.Panel.ResumeLayout(False)
			Me.toolStripStyles.ResumeLayout(False)
			Me.toolStripStyles.PerformLayout()
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.toolStripEx2.ResumeLayout(False)
			Me.toolStripEx2.PerformLayout()
			Me.toolStripEx3.ResumeLayout(False)
			Me.toolStripEx3.PerformLayout()
			Me.toolStripEx4.ResumeLayout(False)
			Me.toolStripEx4.PerformLayout()
			Me.backStageTab2.ResumeLayout(False)
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backStageTab3.ResumeLayout(False)
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Theme Changes"

		Private themeStyle As String = "Blue"
		Public Shared r As Integer = 189, g As Integer = 215, b As Integer = 252, r1 As Integer = 220, g1 As Integer = 235, b1 As Integer = 254


		Private Sub SetBackGroundTheme()
			Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
			Me.gridContainerPanel.BackColor = Color.FromArgb(r, g, b)
			Me.splitContainer1.BackColor = Color.FromArgb(r, g, b)
			Me.gridGroupingPanel.BackColor = Color.FromArgb(r, g, b)
			Me.splitter2.BackColor = Color.FromArgb(r, g, b)
			Me.panel16.BackColor = Color.FromArgb(r1, g1, b1)
			Me.panel3.BackColor = Color.FromArgb(r, g, b)
			Me.panel4.BackColor = Color.FromArgb(r, g, b)
			Me.panel5.BackColor = Color.FromArgb(r, g, b)
			Me.panel1.BackColor = Color.FromArgb(r, g, b)
			Me.panel8.BackColor = Color.FromArgb(r, g, b)
			Me.panel11.BackColor = Color.FromArgb(r, g, b)
			Me.calForm.BackColor = Color.FromArgb(r, g, b)

		End Sub


		#End Region

		#Region "Event Handlers"
		Private Sub OnNewMailMessageClick(ByVal sender As Object, ByVal e As EventArgs)
			CType(New NewMailForm(Me, Me.themeStyle), NewMailForm).Show()
		End Sub

		Private Sub TaskBarBox_ProvideHeaderBackgroundBrush(ByVal sender As Object, ByVal args As ProvideBrushEventArgs) Handles myContactsTaskBarBox.ProvideHeaderBackgroundBrush, currentViewTaskBarBox.ProvideHeaderBackgroundBrush, myJournalTaskBarBox.ProvideHeaderBackgroundBrush, currentViewTaskBarBox3.ProvideHeaderBackgroundBrush, allFoldersTaskBarBox.ProvideHeaderBackgroundBrush, myCalendarsTaskBarBox1.ProvideHeaderBackgroundBrush, favouritesTaskBarBox.ProvideHeaderBackgroundBrush, mailTaskBarBox.ProvideHeaderBackgroundBrush, notesTaskBarBox.ProvideHeaderBackgroundBrush, currentViewTaskBarBox2.ProvideHeaderBackgroundBrush, mytasksTaskBarBox.ProvideHeaderBackgroundBrush, currentViewTaskBarBox1.ProvideHeaderBackgroundBrush
			Dim blend As New System.Drawing.Drawing2D.Blend()
			blend.Factors = New Single() { 0.0f, 0.25F, 0.5f, 1.0F }
			blend.Positions = New Single() { 0.0F, 0.25F, 0.5F, 1.0F, 1.5F }
			' Estimate the GroupBarItem bounds

			Dim rcgroupbaritem As Rectangle = args.Bounds
			' Create and initialize the LinearGradientBrush
			Dim lgbrush As New System.Drawing.Drawing2D.LinearGradientBrush(rcgroupbaritem, Color.White, Color.FromArgb(r, g, b), 90, True)
			lgbrush.Blend = blend
			args.Brush = lgbrush
		End Sub

		Private Sub mailTaskBar_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			'this.mailTaskBarBox.PreferredChildPanelHeight = this.mailTaskBar.Height - this.favouritesTaskBarBox.Height;
		End Sub

		Private Sub groupBar1_NavigationPaneDropDownClick(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventArgs) Handles groupBar1.NavigationPaneDropDownClick
			' Add the 'Navigation Pane Options' and 'Add and Remove Buttons' menu commands to the GroupBar's dropdown menu
			args.ContextMenuProvider.AddContextMenuItem(String.Empty, "Navigation Pane Options...", New EventHandler(AddressOf Me.NavPaneOptions_Click))
			Dim addremove As String = "Add or Remove Buttons"

			' Create and add a BarItem for each GroupBarItem in the GroupBar control
			For Each item As GroupBarItem In Me.groupBar1.GroupBarItems
				args.ContextMenuProvider.AddContextMenuItem(addremove, item.Text, New EventHandler(AddressOf Me.AddRemoveButtons_Click))
				args.ContextMenuProvider.SetContextMenuItemChecked(item.Text, item.Visible)
				args.ContextMenuProvider.SetContextMenuItemImage(item.Text, Me.smallImageList, CInt(Fix(Me.htLabelToImageIndex(item.Text))))
			Next item
		End Sub

		Public Sub SetTheme(ByVal theme As String)
			Select Case theme
				Case "Blue"
					themeStyle = "Blue"
					r = 189
					g = 215
					b = 252
					r1 = 220
					g1 = 235
					b1 = 254
					SetBackGroundTheme()
					Me.groupBar1.Office2007Theme = Office2007Theme.Blue
					Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
					Me.ColorScheme = ColorSchemeType.Blue

					Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Blue
					Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Blue
					Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Blue
					Me.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue
					Me.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue
				Case "Black"
					themeStyle = "Black"
					SetBackGroundTheme()
					r = 109
					g = 109
					b = 109
					r1 = 61
					g1 = 61
					b1 = 61
					SetBackGroundTheme()
					Me.groupBar1.Office2007Theme = Office2007Theme.Black
					Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
					Me.ColorScheme = ColorSchemeType.Black
					Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Black
					Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Black
					Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Black
					Me.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Black
					Me.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Black
				Case "Silver"
					themeStyle = "Silver"
					r = 212
					g = 214
					b = 219
					r1 = 178
					g1 = 183
					b1 = 190
					SetBackGroundTheme()
					Me.groupBar1.Office2007Theme = Office2007Theme.Silver
					Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					Me.ColorScheme = ColorSchemeType.Silver
					Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Silver
					Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Silver
					Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Silver
					Me.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Silver
					Me.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Silver
			End Select
			Me.Refresh()
		End Sub

		Private Sub NavPaneOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim optform As New OutlookDemo.OptionsForm(Me)
			optform.ShowDialog(Me)
		End Sub

		Private Sub AddRemoveButtons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			' Hide or show the GroupBarItem that was clicked on the PopupMenu
			Dim cntxtitem As Syncfusion.Windows.Forms.ContextMenuItem = TryCast(sender, ContextMenuItem)
			Dim itemtext As String = cntxtitem.ContextMenuItemText
			For Each item As GroupBarItem In Me.groupBar1.GroupBarItems
				If item.Text = itemtext Then
					item.Visible = Not item.Visible
					Exit For
				End If
			Next item
		End Sub

		Protected Overrides Sub OnSystemColorsChanged(ByVal e As EventArgs)
			MyBase.OnSystemColorsChanged(e)
			Me.InitializeGroupBarClientColors()
		End Sub



		Private Sub groupBar1_GroupBarItemSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles groupBar1.GroupBarItemSelected
			' Set the text for the ClientPanel labels
			Dim selitem As GroupBarItem = Me.groupBar1.GroupBarItems(Me.groupBar1.SelectedItem)
			If selitem.Text = "Mail" Then
				Me.clientPanelLabel1.Text = "Inbox"
			Else
				Me.clientPanelLabel1.Text = selitem.Text
			End If
			Me.clientPanelLabel2.Text = String.Empty
			If htLabelToImageIndex.Count > 0 Then
			Me.clientPanelImage.ImageIndex = CInt(Fix(Me.htLabelToImageIndex(selitem.Text)))
			End If
		End Sub

		Private Sub mailBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.SetGroupBarSelectedItem("Mail")
		End Sub

		Private Sub calendarBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.groupBar1.SelectedItem = 1
		End Sub

		Private Sub contactsBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.SetGroupBarSelectedItem("Contacts")
		End Sub

		Private Sub tasksBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.SetGroupBarSelectedItem("Tasks")
		End Sub

		Private Sub notesBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.SetGroupBarSelectedItem("Notes")
		End Sub

		Private Sub folderlistBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.SetGroupBarSelectedItem("Folder List")
		End Sub

		Private Sub journalBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.SetGroupBarSelectedItem("Journal")
		End Sub

		Private Sub SetGroupBarSelectedItem(ByVal itemtext As String)
			Dim selecteditem As Integer = -1
			For Each item As GroupBarItem In Me.groupBar1.GroupBarItems
				If item.Text = itemtext Then
					If item.Visible = True Then
						selecteditem = Me.groupBar1.GroupBarItems.IndexOf(item)
					End If
					Exit For
				End If
			Next item
			If selecteditem <> -1 Then
				Me.groupBar1.SelectedItem = selecteditem
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.gridGroupingPanel.Grid.Table.ExpandAllGroups()

		End Sub

		Private Sub Form1_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.gridGroupingPanel.Close()
		End Sub

		Private gridBottomBorderhide As GridBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
		Private gridBottomBorderShow As GridBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)

		Private Sub Model_SelectionChanging(ByVal sender As Object, ByVal e As GridSelectionChangingEventArgs)
			' use the Nested display elements to know the selection is of record or caption
			Dim row As Integer = 0
			If Control.MouseButtons = MouseButtons.Right Then
				e.Cancel = True
			End If

			If e.Reason <> GridSelectionReason.MouseMove Then
				row = e.Range.Top
			End If

			If Me.gridGroupingPanel.Grid.Table.NestedDisplayElements.Count > row Then
				' If the selection is of caption hide the reading pane
				If Me.gridGroupingPanel.Grid.Table.NestedDisplayElements(row).IsCaption() Then
					Me.Display.Hide()
				End If
				If Me.gridGroupingPanel.Grid.Table.NestedDisplayElements(row).IsRecord() Then
					Me.Display.Show()

					Dim rec As Record = Me.gridGroupingPanel.Grid.Table.CurrentRecord
					Dim drv As DataRowView = TryCast(Me.gridGroupingPanel.Grid.Table.NestedDisplayElements(row).GetData(), DataRowView)

						' font table
						' third line
						' closing bracket
					Dim rtf2 As String = "{\rtf1\ansi" & "{\fonttbl" & "\f0\fswiss Calibri;} " & "\highlight0\ql\f3\f0\fs28   " & drv("Subject") & "\plain\par" & "\highlight\ql\f0\f0\fs26    " & drv("From") & "\plain\par" & "\highlight1\ql\cf0\f0\fs20 {\b     To :}" & drv("To") & "\plain\par" & Environment.NewLine & "\highlight1\ql\f0\f2\fs20 " & "\plain\par" & "\highlight1\ql\cf0\f0\fs20     " & drv("Content") & "\plain\par" & "}"

					' Use display to show the content..
					If e.Reason = GridSelectionReason.MouseDown OrElse e.Reason = GridSelectionReason.ArrowKey Then
						Display.Rtf = rtf2
					End If
				End If
			End If
		End Sub

		Private Sub groupBar1_GroupBarItemSelectionChanging(ByVal sender As Object, ByVal args As GroupBarItemSelectionChangingEventArgs)
			If Me.groupBar1.GroupBarItems(args.NewSelected).Text = "Calendar" Then
				Me.gradientPanel1.Hide()
				Me.gridContainerPanel.Hide()
				Me.panel16.Hide()
				scheduleContainerPanel.Show()
				Me.calendarPanel.Controls.Add(Me.calForm.Scheduler.Calendar)
				Me.toolStripStatusLabel1.Text = Me.calForm.Scheduler.Calendar.DateValue.ToLongDateString()
				Me.clientPanel.BorderStyle = BorderStyle.FixedSingle
			ElseIf Me.groupBar1.GroupBarItems(args.NewSelected).Text = "Contacts" Then
				Me.clientPanel.BorderStyle = BorderStyle.None
				Me.gridContainerPanel.Hide()
				Me.panel16.Hide()
				Me.scheduleContainerPanel.Hide()
				Me.gradientPanel1.Show()
				Me.contactsGridPanel.Show()
				Dim count As Integer = Me.contactForm.Grid.TableModel.RowCount - 1
				Me.toolStripStatusLabel1.Text = count.ToString() & " Items"
			Else
				Me.clientPanel.BorderStyle = BorderStyle.None
				Me.scheduleContainerPanel.Hide()
				Me.gridContainerPanel.Show()
				Me.panel16.Show()
				Me.contactsGridPanel.Hide()
				Me.gradientPanel1.Show()
				Me.toolStripStatusLabel1.Text = Me.gridGroupingPanel.Grid.Table.Records.Count.ToString() & " Messages"
			End If
		End Sub

		Private Sub Table_RecordDeleted(ByVal sender As Object, ByVal e As RecordEventArgs)
			Me.toolStripStatusLabel1.Text = Me.gridGroupingPanel.Grid.Table.Records.Count.ToString() & " Messages"
		End Sub

		Private Sub radioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton5.CheckedChanged
			If radioButton5.Checked Then
				Me.contactForm.Grid.TableDescriptor.GroupedColumns.Add("CompanyName")
			Else
				Me.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("CompanyName")
			End If
		End Sub

		Private Sub radioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton4.CheckedChanged
			If radioButton4.Checked Then
				Me.contactForm.Grid.TableDescriptor.GroupedColumns.Add("ContactTitle")
			Else
				Me.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("ContactTitle")
			End If
		End Sub

		Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged
			If radioButton3.Checked Then
				Me.contactForm.Grid.TableDescriptor.GroupedColumns.Add("Phone")
			Else
				Me.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("Phone")
			End If
		End Sub

		#End Region

		Private Sub toolStripButton13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnswitch.Click
			If Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2010 Then
				Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2007
				Me.ribbonControlAdv1.MenuButtonImage = Image.FromFile("..\..\res\outlook2007_small.jpg")
			Else
				Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2010
				Me.ribbonControlAdv1.MenuButtonImage = Image.FromFile("..\..\res\Outlook2010IconSmall.jpg")
			End If
		End Sub

		Private Sub toolbtnexit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnexit.Click
			Me.Close()
		End Sub

		Private Sub toolchknav_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolchknav.Click
			If Me.toolchknav.Checked Then
				Me.groupBar1.Show()
			Else
				Me.groupBar1.Hide()
			End If
		End Sub

		Private Sub toolbtnautoprev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnautoprev.Click
			If Me.groupBar1.SelectedItem = 0 Then
				Dim barItem As ToolStripCheckBox = CType(sender, ToolStripCheckBox)
				Me.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow = Not Me.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow
				If barItem.Checked Then
					'Turning Preview On
					Me.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide
					Me.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderhide
					For Each gcd As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor In Me.gridGroupingPanel.Grid.TableDescriptor.Columns
						gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide
						gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderhide
					Next gcd
					Me.gridGroupingPanel.PreviewSelected = True
				Else
					'Turning Preview Off
					Me.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow
					Me.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderShow
					For Each gcd As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor In Me.gridGroupingPanel.Grid.TableDescriptor.Columns
						gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow
						gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderShow
					Next gcd
					Me.gridGroupingPanel.PreviewSelected = False
				End If
			ElseIf Me.groupBar1.SelectedItem = 2 Then
				Me.contactForm.Grid.TableModel.Properties.DisplayVertLines = Not Me.contactForm.Grid.TableModel.Properties.DisplayVertLines
			End If
		End Sub


		Private Sub toolbtnRight_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnRight.Click
			' Toggle the reading pane to dock right

			Me.gridContainerPanel.Width = 700
			Me.gridContainerPanel.Dock = DockStyle.Left
			Me.splitter2.Dock = DockStyle.Left
			'this.panel16.Width=280;
			Me.panel16.Width = 310
			Me.panel16.Dock = DockStyle.Right
			Me.panel16.Show()
		End Sub

		Private Sub toolbtnBottom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnBottom.Click
			' Toggle the reading pane to dock bottom
			Me.gridContainerPanel.Height = 325
			Me.gridContainerPanel.Dock = DockStyle.Top
			Me.splitter2.Dock = DockStyle.Top
			Me.panel16.Dock = DockStyle.Fill
			Me.panel16.Show()
		End Sub

		Private Sub toolbtnTop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnTop.Click
			Me.panel16.Hide()
			Me.gridContainerPanel.Dock = DockStyle.Fill
		End Sub

		Private Sub toolbtnstyleBlue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnstyleBlue.Click
			Me.toolbtnstyleBlack.Checked = False
			Me.toolbtnstyleSilver.Checked = False
			themeStyle = "Blue"
			r = 189
			g = 215
			b = 252
			r1 = 220
			g1 = 235
			b1 = 254
			SetBackGroundTheme()
			Me.groupBar1.Office2007Theme = Office2007Theme.Blue
			Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
			Me.ColorScheme = ColorSchemeType.Blue

			Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Blue
			Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Blue
			Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Blue
			Me.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue
			Me.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
			Me.Refresh()
		End Sub

		Private Sub toolbtnstyleBlack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnstyleBlack.Click
			Me.toolbtnstyleBlue.Checked = False
			Me.toolbtnstyleSilver.Checked = False
			themeStyle = "Black"
			SetBackGroundTheme()
			r = 109
			g = 109
			b = 109
			r1 = 61
			g1 = 61
			b1 = 61
			SetBackGroundTheme()
			Me.groupBar1.Office2007Theme = Office2007Theme.Black
			Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
			Me.ColorScheme = ColorSchemeType.Black

			Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Black
			Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Black
			Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Black
			Me.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Black
			Me.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Black
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
			Me.Refresh()
		End Sub

		Private Sub toolbtnstyleSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnstyleSilver.Click
			Me.toolbtnstyleBlack.Checked = False
			Me.toolbtnstyleBlue.Checked = False
			themeStyle = "Silver"
			r = 212
			g = 214
			b = 219
			r1 = 178
			g1 = 183
			b1 = 190
			SetBackGroundTheme()
			Me.groupBar1.Office2007Theme = Office2007Theme.Silver
			Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
			Me.ColorScheme = ColorSchemeType.Silver
			Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Silver
			Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Silver
			Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Silver
			Me.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Silver
			Me.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Silver
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
			Me.Refresh()
		End Sub

		Private Sub toolbtnmail_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnmail.Click
			Me.SetGroupBarSelectedItem("Mail")
			Me.toolbtncalndr.Checked = False
			Me.toolbtncnt.Checked = False
			Me.toolbtntasks.Checked = False
			Me.toolbtnGonote.Checked = False
			Me.toolbtnfolderlist.Checked = False
			Me.toolbtnGojournal.Checked = False
		End Sub

		Private Sub toolbtncalndr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtncalndr.Click
			Me.groupBar1.SelectedItem = 1
			Me.toolbtnmail.Checked = False
			Me.toolbtncnt.Checked = False
			Me.toolbtntasks.Checked = False
			Me.toolbtnGonote.Checked = False
			Me.toolbtnfolderlist.Checked = False
			Me.toolbtnGojournal.Checked = False
		End Sub

		Private Sub toolbtncnt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtncnt.Click
			Me.SetGroupBarSelectedItem("Contacts")
			Me.toolbtnmail.Checked = False
			Me.toolbtncalndr.Checked = False
			Me.toolbtntasks.Checked = False
			Me.toolbtnGonote.Checked = False
			Me.toolbtnfolderlist.Checked = False
			Me.toolbtnGojournal.Checked = False
		End Sub

		Private Sub toolbtntasks_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtntasks.Click
			Me.SetGroupBarSelectedItem("Tasks")
			Me.toolbtnmail.Checked = False
			Me.toolbtncalndr.Checked = False
			Me.toolbtncnt.Checked = False
			Me.toolbtnGonote.Checked = False
			Me.toolbtnfolderlist.Checked = False
			Me.toolbtnGojournal.Checked = False
		End Sub

		Private Sub toolbtnGonote_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnGonote.Click
			Me.SetGroupBarSelectedItem("Notes")
			Me.toolbtnmail.Checked = False
			Me.toolbtncalndr.Checked = False
			Me.toolbtncnt.Checked = False
			Me.toolbtntasks.Checked = False
			Me.toolbtnfolderlist.Checked = False
			Me.toolbtnGojournal.Checked = False
		End Sub

		Private Sub toolbtnfolderlist_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnfolderlist.Click
			Me.SetGroupBarSelectedItem("Folder List")
			Me.toolbtnmail.Checked = False
			Me.toolbtncalndr.Checked = False
			Me.toolbtncnt.Checked = False
			Me.toolbtntasks.Checked = False
			Me.toolbtnGonote.Checked = False
			Me.toolbtnGojournal.Checked = False
		End Sub

		Private Sub toolbtnGojournal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnGojournal.Click
			Me.SetGroupBarSelectedItem("Journal")
			Me.toolbtnmail.Checked = False
			Me.toolbtncalndr.Checked = False
			Me.toolbtncnt.Checked = False
			Me.toolbtntasks.Checked = False
			Me.toolbtnGonote.Checked = False
			Me.toolbtnfolderlist.Checked = False
		End Sub

		Private Sub toolbtnhelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnhelp.Click

		End Sub

		Private Sub toolbtnabout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnabout.Click
			Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			abtForm.ShowDialog()
		End Sub

		Private Sub toolbtnmailMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnmailMessage.Click
			Dim mailForm As New NewMailForm(Me, themeStyle)
			mailForm.Show()
		End Sub

		Private Sub toolbtnappointment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnappointment.Click
			Dim appointmentForm As New CalendarForm()
			appointmentForm.Show()
		End Sub

		Private Sub toolbtncontact_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtncontact.Click
			Dim contactDialog As New NewContactDialog()
			contactDialog.ShowDialog()
		End Sub


		Private Sub backStageButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton2.Click
			Me.Close()
		End Sub

		Private Sub backStageButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton3.Click
			Me.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2007
			Me.ribbonControlAdv1.MenuButtonImage = Image.FromFile("..\..\res\outlook2007_small.jpg")
			Me.ribbonControlAdv1.BackStageView.BackStage.Hide()
		End Sub

		Private Sub backStageButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton4.Click
			Me.Close()
		End Sub

		Private Sub toolbtnExpAllGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnExpAllGroup.Click
			Me.gridGroupingPanel.ExpandAllGroupsBarItem.PerformClick()
		End Sub

		Private Sub toolbtnCollapse_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnCollapse.Click
			Me.gridGroupingPanel.collapseAllGroupsBarItem.PerformClick()
		End Sub

		Private Sub toolbtnExpthisGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolbtnExpthisGroup.Click
			Me.gridGroupingPanel.ExpandthisGroup()
		End Sub




	End Class
	#End Region

	#Region "GroupBarItem class"
	' Serves as a temporary store for the GroupBarItem state - Used by the Options Form 'Restore' functionality
	Public Class GroupBarItemState
		Private strItemText As String
		Private bInNavPane As Boolean = False
		Private bVisible As Boolean = True

		Public ReadOnly Property ItemText() As String
			Get
				Return Me.strItemText
			End Get
		End Property
		Public ReadOnly Property InNavPane() As Boolean
			Get
				Return Me.bInNavPane
			End Get
		End Property
		Public ReadOnly Property Visible() As Boolean
			Get
				Return Me.bVisible
			End Get
		End Property

		Public Sub New(ByVal text As String, ByVal navpane As Boolean, ByVal visible As Boolean)
			Me.strItemText = text
			Me.bInNavPane = navpane
			Me.bVisible = visible
		End Sub
	End Class
	#End Region

End Namespace
