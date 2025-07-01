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
    Public Class Form1 : Inherits Office2007Form
#Region "Members"
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
        Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
        Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private splitter1 As System.Windows.Forms.Splitter
        Private clientPanel As System.Windows.Forms.Panel
        Private clientPanelImage As System.Windows.Forms.Label
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private clientPanelLabel2 As System.Windows.Forms.Label
        Private clientPanelLabel1 As System.Windows.Forms.Label
        Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem31 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem32 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem33 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem34 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem35 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem36 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem37 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem38 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem39 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem40 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem42 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem43 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem44 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem46 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem45 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem29 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem41 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem47 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem48 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem49 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem50 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem51 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem52 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem53 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem54 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem55 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem56 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem57 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem58 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem59 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem60 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents mailBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents calendarBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents contactsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents tasksBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents notesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents folderlistBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents journalBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem24 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem25 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem26 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem27 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem28 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem30 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private gridContainerPanel As System.Windows.Forms.Panel
        Private restoreList As System.Collections.ArrayList = New ArrayList()
        Private splitter2 As System.Windows.Forms.Splitter
        Private panel16 As System.Windows.Forms.Panel
        Private bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private toolbarListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
        Private barItem61 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private listBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
        Private textBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem
        Private staticBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
        Private WithEvents barItem62 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem_AutoPreview As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private Display As System.Windows.Forms.RichTextBox
        Private scheduleContainerPanel As System.Windows.Forms.Panel
        Private WithEvents barItem63 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem64 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem65 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem66 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem67 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private contactsGridPanel As System.Windows.Forms.Panel
        Private WithEvents barItem68 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private contactForm As ContactsPaneForm = Nothing
        Private calForm As CalendarForm = Nothing
        Private mailTaskBar As XPTaskBar
        Private favouritesTaskBarBox As XPTaskBarBox
        Private mailTaskBarBox As XPTaskBarBox
        Private gradientPanel2 As GradientPanel
        Private gradientPanel3 As GradientPanel
        Private xpTaskBar1 As XPTaskBar
        Private myCalendarsTaskBarBox1 As XPTaskBarBox
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
        Private myContactsTaskBarBox As XPTaskBarBox
        Private currentViewTaskBarBox As XPTaskBarBox
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
        Private mytasksTaskBarBox As XPTaskBarBox
        Private currentViewTaskBarBox1 As XPTaskBarBox
        Private radioButton31 As RadioButton
        Private radioButton30 As RadioButton
        Private radioButton28 As RadioButton
        Private radioButton27 As RadioButton
        Private linkLabel20 As LinkLabel
        Private linkLabel21 As LinkLabel
        Private panel4 As Panel
        Private gradientPanel7 As GradientPanel
        Private xpTaskBar4 As XPTaskBar
        Private notesTaskBarBox As XPTaskBarBox
        Private currentViewTaskBarBox2 As XPTaskBarBox
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
        Private myJournalTaskBarBox As XPTaskBarBox
        Private currentViewTaskBarBox3 As XPTaskBarBox
        Private radioButton29 As RadioButton
        Private radioButton26 As RadioButton
        Private linkLabel25 As LinkLabel
        Private linkLabel24 As LinkLabel
        Private folderlistPanel As Panel
        Private gradientPanel8 As GradientPanel
        Private panel8 As Panel
        Private WithEvents blueStyleBarItem As BarItem
        Private WithEvents blackStyleBarItem As BarItem
        Private WithEvents silverStyleBarItem As BarItem
        Private parentBarItem17 As ParentBarItem
        Private statusStripEx1 As StatusStripEx
        Private toolStripStatusLabel1 As ToolStripStatusLabel
        Friend WithEvents SplashControl1 As Syncfusion.Windows.Forms.Tools.SplashControl
        Friend WithEvents ScrollersFrame1 As Syncfusion.Windows.Forms.ScrollersFrame
        Friend WithEvents SplitContainerAdv1 As Syncfusion.Windows.Forms.Tools.SplitContainerAdv
        Dim distance As Integer = 300
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
            Me.SplashControl1.ShowDialogSplash(Me)


            Dim clrDefault As Color() = New Color() {Color.FromArgb(192, 219, 255), Color.FromArgb(188, 217, 255), Color.FromArgb(184, 215, 255), Color.FromArgb(181, 213, 255), Color.FromArgb(177, 211, 255), Color.FromArgb(173, 209, 255), Color.FromArgb(198, 222, 255), Color.FromArgb(204, 225, 255), Color.FromArgb(210, 229, 255), Color.FromArgb(215, 232, 255), Color.FromArgb(221, 236, 255), Color.FromArgb(227, 239, 255)}
            Me.Display.Hide()
            scheduleContainerPanel.Hide()
            contactsGridPanel.Hide()
            Me.barItem64.Enabled = False
            Me.barItem65.Enabled = False
            Me.barItem66.Enabled = False
            Me.barItem67.Enabled = False

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
            Me.clientPanelImage.ImageIndex = CInt(Me.htLabelToImageIndex(selitem.Text))

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
            AddHandler Me.gridGroupingPanel.Grid.TableControl.Model.SelectionChanging, AddressOf Model_SelectionChanging
            Me.barItem47.PerformClick()
            AddHandler Me.groupBar1.GroupBarItemSelectionChanging, AddressOf groupBar1_GroupBarItemSelectionChanging
            Me.toolStripStatusLabel1.Text = Me.gridGroupingPanel.Grid.Table.Records.Count.ToString() & " Messages"

            AddHandler Me.gridGroupingPanel.Grid.Table.RecordDeleted, AddressOf Table_RecordDeleted
            AddHandler mailTaskBar.SizeChanged, AddressOf mailTaskBar_SizeChanged
            SetGradientColors()
            Me.groupBar1.HeaderForeColor = Color.MidnightBlue

           
            Me.gridContainerPanel.Height = 325
            Me.gridContainerPanel.Dock = DockStyle.Top
            Me.splitter2.Dock = DockStyle.Top
            Me.panel16.Dock = DockStyle.Fill
            Me.panel16.Show()
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
            'this.gradientPanel1.BackgroundColor = new BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.GroupBarHeaderColorDark, Office2003Colors.GroupBarHeaderColorLight); 
        End Sub

#End Region

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inbox", 2, 2)
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Folders", 7, 7, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9})
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts", 5, 5)
            Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inbox", 2, 2)
            Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outbox", 3, 3)
            Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
            Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Public")
            Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15})
            Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Junk Mail", 3, 3)
            Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode17})
            Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
            Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("InBox", 2, 2)
            Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
            Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
            Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Calendar")
            Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contacts", 9, 9)
            Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts", 5, 5)
            Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Journal", 13, 13)
            Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Folders", 7, 7, New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26})
            Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
            Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
            Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
            Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30})
            Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts", 5, 5)
            Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("InBox", 2, 2)
            Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OutBox", 3, 3)
            Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
            Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Public")
            Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36})
            Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("For Follow Up", 4, 4)
            Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Large Mail", 4, 4)
            Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Folders", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39})
            Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ListViewItem0"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ListViewItem1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ListViewItem2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ListViewItem3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ListViewItem4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar
            Me.mailPanel = New System.Windows.Forms.Panel
            Me.mailTaskBar = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.favouritesTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.smallImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.mailTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.treeView3 = New System.Windows.Forms.TreeView
            Me.journalPanel = New System.Windows.Forms.Panel
            Me.gradientPanel10 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel8 = New System.Windows.Forms.Panel
            Me.linkLabel25 = New System.Windows.Forms.LinkLabel
            Me.xpTaskBar6 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.myJournalTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.currentViewTaskBarBox3 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.panel14 = New System.Windows.Forms.Panel
            Me.radioButton29 = New System.Windows.Forms.RadioButton
            Me.radioButton18 = New System.Windows.Forms.RadioButton
            Me.radioButton26 = New System.Windows.Forms.RadioButton
            Me.radioButton19 = New System.Windows.Forms.RadioButton
            Me.radioButton20 = New System.Windows.Forms.RadioButton
            Me.radioButton21 = New System.Windows.Forms.RadioButton
            Me.radioButton22 = New System.Windows.Forms.RadioButton
            Me.linkLabel24 = New System.Windows.Forms.LinkLabel
            Me.linkLabel11 = New System.Windows.Forms.LinkLabel
            Me.linkLabel9 = New System.Windows.Forms.LinkLabel
            Me.notesPanel = New System.Windows.Forms.Panel
            Me.gradientPanel7 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.linkLabel22 = New System.Windows.Forms.LinkLabel
            Me.panel5 = New System.Windows.Forms.Panel
            Me.linkLabel23 = New System.Windows.Forms.LinkLabel
            Me.xpTaskBar4 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.notesTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.currentViewTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.panel9 = New System.Windows.Forms.Panel
            Me.radioButton13 = New System.Windows.Forms.RadioButton
            Me.radioButton14 = New System.Windows.Forms.RadioButton
            Me.radioButton15 = New System.Windows.Forms.RadioButton
            Me.radioButton16 = New System.Windows.Forms.RadioButton
            Me.radioButton17 = New System.Windows.Forms.RadioButton
            Me.linkLabel5 = New System.Windows.Forms.LinkLabel
            Me.linkLabel6 = New System.Windows.Forms.LinkLabel
            Me.tasksPanel = New System.Windows.Forms.Panel
            Me.gradientPanel6 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel4 = New System.Windows.Forms.Panel
            Me.linkLabel20 = New System.Windows.Forms.LinkLabel
            Me.xpTaskBar3 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.mytasksTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.currentViewTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.panel7 = New System.Windows.Forms.Panel
            Me.radioButton31 = New System.Windows.Forms.RadioButton
            Me.radioButton30 = New System.Windows.Forms.RadioButton
            Me.radioButton28 = New System.Windows.Forms.RadioButton
            Me.radioButton27 = New System.Windows.Forms.RadioButton
            Me.radioButton12 = New System.Windows.Forms.RadioButton
            Me.radioButton11 = New System.Windows.Forms.RadioButton
            Me.radioButton6 = New System.Windows.Forms.RadioButton
            Me.radioButton7 = New System.Windows.Forms.RadioButton
            Me.radioButton8 = New System.Windows.Forms.RadioButton
            Me.radioButton9 = New System.Windows.Forms.RadioButton
            Me.radioButton10 = New System.Windows.Forms.RadioButton
            Me.linkLabel21 = New System.Windows.Forms.LinkLabel
            Me.linkLabel4 = New System.Windows.Forms.LinkLabel
            Me.linkLabel3 = New System.Windows.Forms.LinkLabel
            Me.contactsPanel = New System.Windows.Forms.Panel
            Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel
            Me.panel3 = New System.Windows.Forms.Panel
            Me.linkLabel2 = New System.Windows.Forms.LinkLabel
            Me.xpTaskBar2 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.myContactsTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.currentViewTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.panel2 = New System.Windows.Forms.Panel
            Me.radioButton25 = New System.Windows.Forms.RadioButton
            Me.radioButton5 = New System.Windows.Forms.RadioButton
            Me.radioButton24 = New System.Windows.Forms.RadioButton
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.radioButton23 = New System.Windows.Forms.RadioButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.linkLabel18 = New System.Windows.Forms.LinkLabel
            Me.linkLabel19 = New System.Windows.Forms.LinkLabel
            Me.calendarPanel = New System.Windows.Forms.Panel
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.linkLabel10 = New System.Windows.Forms.LinkLabel
            Me.panel11 = New System.Windows.Forms.Panel
            Me.linkLabel12 = New System.Windows.Forms.LinkLabel
            Me.linkLabel13 = New System.Windows.Forms.LinkLabel
            Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.myCalendarsTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.linkLabel14 = New System.Windows.Forms.LinkLabel
            Me.linkLabel17 = New System.Windows.Forms.LinkLabel
            Me.linkLabel15 = New System.Windows.Forms.LinkLabel
            Me.linkLabel16 = New System.Windows.Forms.LinkLabel
            Me.folderlistPanel = New System.Windows.Forms.Panel
            Me.gradientPanel8 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel6 = New System.Windows.Forms.Panel
            Me.linkLabel7 = New System.Windows.Forms.LinkLabel
            Me.panel1 = New System.Windows.Forms.Panel
            Me.linkLabel8 = New System.Windows.Forms.LinkLabel
            Me.xpTaskBar5 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.allFoldersTaskBarBox = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.gradientPanel9 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.treeView1 = New System.Windows.Forms.TreeView
            Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem7 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem4 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem5 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem6 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
            Me.listView1 = New System.Windows.Forms.ListView
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem29 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem37 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem38 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem39 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem40 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem42 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem43 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem44 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem46 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem45 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem52 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem53 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
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
            Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem41 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem47 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem48 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem63 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem49 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem50 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem68 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem51 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.mailBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.calendarBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.contactsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.tasksBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.notesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.folderlistBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.journalBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem31 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem32 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem54 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem55 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem56 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem57 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem58 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem59 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem60 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem33 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem34 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem35 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem36 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.blueStyleBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.blackStyleBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.silverStyleBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Standard")
            Me.barItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem30 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Advanced")
            Me.barItem62 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem_AutoPreview = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem26 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem27 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem28 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem64 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem65 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem66 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem67 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.splitter1 = New System.Windows.Forms.Splitter
            Me.clientPanel = New System.Windows.Forms.Panel
            Me.panel16 = New System.Windows.Forms.Panel
            Me.Display = New System.Windows.Forms.RichTextBox
            Me.splitter2 = New System.Windows.Forms.Splitter
            Me.gridContainerPanel = New System.Windows.Forms.Panel
            Me.scheduleContainerPanel = New System.Windows.Forms.Panel
            Me.contactsGridPanel = New System.Windows.Forms.Panel
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.clientPanelLabel1 = New System.Windows.Forms.Label
            Me.clientPanelImage = New System.Windows.Forms.Label
            Me.clientPanelLabel2 = New System.Windows.Forms.Label
            Me.toolbarListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
            Me.barItem61 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.listBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
            Me.textBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem
            Me.staticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
            Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx
            Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
            Me.SplashControl1 = New Syncfusion.Windows.Forms.Tools.SplashControl
            Me.ScrollersFrame1 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
            Me.SplitContainerAdv1 = New Syncfusion.Windows.Forms.Tools.SplitContainerAdv
            CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBar1.SuspendLayout()
            Me.mailPanel.SuspendLayout()
            CType(Me.mailTaskBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mailTaskBar.SuspendLayout()
            Me.mailTaskBarBox.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.journalPanel.SuspendLayout()
            CType(Me.gradientPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel10.SuspendLayout()
            CType(Me.xpTaskBar6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar6.SuspendLayout()
            Me.currentViewTaskBarBox3.SuspendLayout()
            Me.panel14.SuspendLayout()
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
            Me.contactsPanel.SuspendLayout()
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel5.SuspendLayout()
            CType(Me.xpTaskBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar2.SuspendLayout()
            Me.currentViewTaskBarBox.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.calendarPanel.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar1.SuspendLayout()
            Me.myCalendarsTaskBarBox1.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            Me.folderlistPanel.SuspendLayout()
            CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel8.SuspendLayout()
            Me.panel6.SuspendLayout()
            CType(Me.xpTaskBar5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar5.SuspendLayout()
            Me.allFoldersTaskBarBox.SuspendLayout()
            CType(Me.gradientPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel9.SuspendLayout()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.clientPanel.SuspendLayout()
            Me.panel16.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.statusStripEx1.SuspendLayout()
            CType(Me.SplitContainerAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerAdv1.Panel1.SuspendLayout()
            Me.SplitContainerAdv1.Panel2.SuspendLayout()
            Me.SplitContainerAdv1.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupBar1
            '
            Me.groupBar1.AllowCollapse = True
            Me.groupBar1.AllowDrop = True
            Me.groupBar1.AnimatedSelection = False
            Me.groupBar1.BackColor = System.Drawing.SystemColors.Control
            Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.groupBar1.Controls.Add(Me.mailPanel)
            Me.groupBar1.Controls.Add(Me.journalPanel)
            Me.groupBar1.Controls.Add(Me.notesPanel)
            Me.groupBar1.Controls.Add(Me.tasksPanel)
            Me.groupBar1.Controls.Add(Me.contactsPanel)
            Me.groupBar1.Controls.Add(Me.calendarPanel)
            Me.groupBar1.Controls.Add(Me.folderlistPanel)
            Me.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBar1.GroupBarItemCursor = System.Windows.Forms.Cursors.Hand
            Me.groupBar1.GroupBarItemHeight = 32
            Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() {Me.groupBarItem1, Me.groupBarItem7, Me.groupBarItem3, Me.groupBarItem4, Me.groupBarItem5, Me.groupBarItem6, Me.groupBarItem2})
            Me.groupBar1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBar1.Location = New System.Drawing.Point(0, 0)
            Me.groupBar1.Name = "groupBar1"
            Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
            Me.groupBar1.SelectedItem = 0
            Me.groupBar1.Size = New System.Drawing.Size(188, 786)
            Me.groupBar1.StackedMode = True
            Me.groupBar1.TabIndex = 0
            Me.groupBar1.Text = "groupBar1"
            Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'mailPanel
            '
            Me.mailPanel.Controls.Add(Me.mailTaskBar)
            Me.mailPanel.Location = New System.Drawing.Point(1, 27)
            Me.mailPanel.Name = "mailPanel"
            Me.mailPanel.Size = New System.Drawing.Size(186, 496)
            Me.mailPanel.TabIndex = 1
            '
            'mailTaskBar
            '
            Me.mailTaskBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.mailTaskBar.Controls.Add(Me.favouritesTaskBarBox)
            Me.mailTaskBar.Controls.Add(Me.mailTaskBarBox)
            Me.mailTaskBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mailTaskBar.Location = New System.Drawing.Point(0, 0)
            Me.mailTaskBar.MinimumSize = New System.Drawing.Size(0, 0)
            Me.mailTaskBar.Name = "mailTaskBar"
            Me.mailTaskBar.Size = New System.Drawing.Size(186, 496)
            Me.mailTaskBar.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.mailTaskBar.TabIndex = 4
            Me.mailTaskBar.VerticalPadding = 4
            '
            'favouritesTaskBarBox
            '
            Me.favouritesTaskBarBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.favouritesTaskBarBox.DrawFocusRect = False
            Me.favouritesTaskBarBox.FocusOnClick = False
            Me.favouritesTaskBarBox.ForeColor = System.Drawing.SystemColors.ControlText
            Me.favouritesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.favouritesTaskBarBox.HeaderImageIndex = -1
            Me.favouritesTaskBarBox.HitTaskBoxArea = False
            Me.favouritesTaskBarBox.ImageList = Me.smallImageList
            Me.favouritesTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Inbox", System.Drawing.Color.Empty, 2, Nothing, "", True, True, "XPTaskBarItem0", New System.Drawing.Font("Microsoft Sans Serif", 8.25!), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Unread Mail", System.Drawing.Color.Empty, 4, Nothing, "", True, True, "XPTaskBarItem1", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sent Items", System.Drawing.Color.Empty, 6, Nothing, "", True, True, "XPTaskBarItem2", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0)})
            Me.favouritesTaskBarBox.Location = New System.Drawing.Point(0, 0)
            Me.favouritesTaskBarBox.Name = "favouritesTaskBarBox"
            Me.favouritesTaskBarBox.Size = New System.Drawing.Size(184, 76)
            Me.favouritesTaskBarBox.TabIndex = 0
            Me.favouritesTaskBarBox.Text = "Favourite Folders"
            '
            'smallImageList
            '
            Me.smallImageList.ImageStream = CType(resources.GetObject("smallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
            'mailTaskBarBox
            '
            Me.mailTaskBarBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.mailTaskBarBox.Controls.Add(Me.gradientPanel2)
            Me.mailTaskBarBox.DrawFocusRect = False
            Me.mailTaskBarBox.FocusOnClick = False
            Me.mailTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.mailTaskBarBox.HeaderImageIndex = -1
            Me.mailTaskBarBox.HitTaskBoxArea = False
            Me.mailTaskBarBox.Location = New System.Drawing.Point(0, 80)
            Me.mailTaskBarBox.Name = "mailTaskBarBox"
            Me.mailTaskBarBox.PreferredChildPanelHeight = 270
            Me.mailTaskBarBox.Size = New System.Drawing.Size(184, 294)
            Me.mailTaskBarBox.TabIndex = 1
            Me.mailTaskBarBox.Text = "Mail Folders"
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel2.Controls.Add(Me.treeView3)
            Me.gradientPanel2.Location = New System.Drawing.Point(2, 22)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(180, 270)
            Me.gradientPanel2.TabIndex = 4
            '
            'treeView3
            '
            Me.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.treeView3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.treeView3.ImageIndex = 0
            Me.treeView3.ImageList = Me.smallImageList
            Me.treeView3.Indent = 25
            Me.treeView3.Location = New System.Drawing.Point(0, 0)
            Me.treeView3.Name = "treeView3"
            TreeNode1.ImageIndex = 1
            TreeNode1.Name = ""
            TreeNode1.SelectedImageIndex = 1
            TreeNode1.Text = "Deleted Items"
            TreeNode2.ImageIndex = 0
            TreeNode2.Name = ""
            TreeNode2.SelectedImageIndex = 0
            TreeNode2.Text = "Junk Email"
            TreeNode3.ImageIndex = 2
            TreeNode3.Name = ""
            TreeNode3.SelectedImageIndex = 2
            TreeNode3.Text = "Inbox"
            TreeNode4.ImageIndex = 6
            TreeNode4.Name = ""
            TreeNode4.SelectedImageIndex = 6
            TreeNode4.Text = "Sent Items"
            TreeNode5.ImageIndex = 4
            TreeNode5.Name = ""
            TreeNode5.SelectedImageIndex = 4
            TreeNode5.Text = "Search Folders"
            TreeNode6.ImageIndex = 7
            TreeNode6.Name = ""
            TreeNode6.SelectedImageIndex = 7
            TreeNode6.Text = "Personal Folders"
            TreeNode7.ImageIndex = 4
            TreeNode7.Name = ""
            TreeNode7.SelectedImageIndex = 4
            TreeNode7.Text = "Search Folders"
            TreeNode8.ImageIndex = 6
            TreeNode8.Name = ""
            TreeNode8.SelectedImageIndex = 6
            TreeNode8.Text = "Sent Items"
            TreeNode9.ImageIndex = 1
            TreeNode9.Name = ""
            TreeNode9.SelectedImageIndex = 1
            TreeNode9.Text = "Deleted Items"
            TreeNode10.ImageIndex = 8
            TreeNode10.Name = ""
            TreeNode10.SelectedImageIndex = 8
            TreeNode10.Text = "Archive Folders"
            TreeNode11.ImageIndex = 5
            TreeNode11.Name = ""
            TreeNode11.SelectedImageIndex = 5
            TreeNode11.Text = "Drafts"
            TreeNode12.ImageIndex = 2
            TreeNode12.Name = ""
            TreeNode12.SelectedImageIndex = 2
            TreeNode12.Text = "Inbox"
            TreeNode13.ImageIndex = 3
            TreeNode13.Name = ""
            TreeNode13.SelectedImageIndex = 3
            TreeNode13.Text = "Outbox"
            TreeNode14.ImageIndex = 6
            TreeNode14.Name = ""
            TreeNode14.SelectedImageIndex = 6
            TreeNode14.Text = "Sent Items"
            TreeNode15.Name = ""
            TreeNode15.Text = "Public"
            TreeNode16.ImageIndex = 8
            TreeNode16.Name = ""
            TreeNode16.SelectedImageIndex = 8
            TreeNode16.Text = "Syncfusion Email"
            Me.treeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode10, TreeNode16})
            Me.treeView3.SelectedImageIndex = 0
            Me.treeView3.ShowLines = False
            Me.treeView3.Size = New System.Drawing.Size(180, 270)
            Me.treeView3.TabIndex = 3
            '
            'journalPanel
            '
            Me.journalPanel.BackColor = System.Drawing.SystemColors.Window
            Me.journalPanel.Controls.Add(Me.gradientPanel10)
            Me.journalPanel.Location = New System.Drawing.Point(1, 225)
            Me.journalPanel.Name = "journalPanel"
            Me.journalPanel.Size = New System.Drawing.Size(218, 74)
            Me.journalPanel.TabIndex = 4
            '
            'gradientPanel10
            '
            Me.gradientPanel10.BorderColor = System.Drawing.Color.Black
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
            'panel8
            '
            Me.panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel8.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel8.Location = New System.Drawing.Point(0, 263)
            Me.panel8.Name = "panel8"
            Me.panel8.Size = New System.Drawing.Size(218, 5)
            Me.panel8.TabIndex = 4
            '
            'linkLabel25
            '
            Me.linkLabel25.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel25.AutoSize = True
            Me.linkLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel25.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel25.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel25.Location = New System.Drawing.Point(15, 309)
            Me.linkLabel25.Name = "linkLabel25"
            Me.linkLabel25.Size = New System.Drawing.Size(83, 13)
            Me.linkLabel25.TabIndex = 3
            Me.linkLabel25.TabStop = True
            Me.linkLabel25.Text = "Add New Group"
            Me.linkLabel25.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'xpTaskBar6
            '
            Me.xpTaskBar6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar6.Controls.Add(Me.myJournalTaskBarBox)
            Me.xpTaskBar6.Controls.Add(Me.currentViewTaskBarBox3)
            Me.xpTaskBar6.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpTaskBar6.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar6.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar6.Name = "xpTaskBar6"
            Me.xpTaskBar6.Size = New System.Drawing.Size(218, 263)
            Me.xpTaskBar6.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar6.TabIndex = 0
            Me.xpTaskBar6.VerticalPadding = 4
            '
            'myJournalTaskBarBox
            '
            Me.myJournalTaskBarBox.DrawFocusRect = False
            Me.myJournalTaskBarBox.FocusOnClick = False
            Me.myJournalTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.myJournalTaskBarBox.HeaderImageIndex = -1
            Me.myJournalTaskBarBox.HitTaskBoxArea = False
            Me.myJournalTaskBarBox.ImageList = Me.smallImageList
            Me.myJournalTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal", System.Drawing.Color.Empty, 13, Nothing, "", True, True, "XPTaskBarItem9", New System.Drawing.Font("Microsoft Sans Serif", 8.25!), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal in Archive Folders", System.Drawing.Color.Empty, 13, Nothing, "", True, True, "XPTaskBarItem10", New System.Drawing.Font("Microsoft Sans Serif", 8.25!), 0)})
            Me.myJournalTaskBarBox.Location = New System.Drawing.Point(0, 0)
            Me.myJournalTaskBarBox.Name = "myJournalTaskBarBox"
            Me.myJournalTaskBarBox.Size = New System.Drawing.Size(216, 58)
            Me.myJournalTaskBarBox.TabIndex = 0
            Me.myJournalTaskBarBox.Text = "My Journal"
            '
            'currentViewTaskBarBox3
            '
            Me.currentViewTaskBarBox3.Controls.Add(Me.panel14)
            Me.currentViewTaskBarBox3.DrawFocusRect = False
            Me.currentViewTaskBarBox3.FocusOnClick = False
            Me.currentViewTaskBarBox3.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.currentViewTaskBarBox3.HeaderImageIndex = -1
            Me.currentViewTaskBarBox3.HitTaskBoxArea = False
            Me.currentViewTaskBarBox3.Location = New System.Drawing.Point(0, 62)
            Me.currentViewTaskBarBox3.Name = "currentViewTaskBarBox3"
            Me.currentViewTaskBarBox3.PreferredChildPanelHeight = 150
            Me.currentViewTaskBarBox3.Size = New System.Drawing.Size(216, 174)
            Me.currentViewTaskBarBox3.TabIndex = 1
            Me.currentViewTaskBarBox3.Text = "Current View"
            '
            'panel14
            '
            Me.panel14.BackColor = System.Drawing.Color.White
            Me.panel14.Controls.Add(Me.radioButton29)
            Me.panel14.Controls.Add(Me.radioButton18)
            Me.panel14.Controls.Add(Me.radioButton26)
            Me.panel14.Controls.Add(Me.radioButton19)
            Me.panel14.Controls.Add(Me.radioButton20)
            Me.panel14.Controls.Add(Me.radioButton21)
            Me.panel14.Controls.Add(Me.radioButton22)
            Me.panel14.Location = New System.Drawing.Point(2, 22)
            Me.panel14.Name = "panel14"
            Me.panel14.Size = New System.Drawing.Size(212, 150)
            Me.panel14.TabIndex = 6
            '
            'radioButton29
            '
            Me.radioButton29.AutoSize = True
            Me.radioButton29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton29.Location = New System.Drawing.Point(16, 128)
            Me.radioButton29.Name = "radioButton29"
            Me.radioButton29.Size = New System.Drawing.Size(112, 17)
            Me.radioButton29.TabIndex = 3
            Me.radioButton29.TabStop = True
            Me.radioButton29.Text = "Outlook Data Files"
            Me.radioButton29.UseVisualStyleBackColor = True
            '
            'radioButton18
            '
            Me.radioButton18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton18.Location = New System.Drawing.Point(16, 107)
            Me.radioButton18.Name = "radioButton18"
            Me.radioButton18.Size = New System.Drawing.Size(176, 24)
            Me.radioButton18.TabIndex = 4
            Me.radioButton18.Text = "Phone Calls"
            '
            'radioButton26
            '
            Me.radioButton26.AutoSize = True
            Me.radioButton26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton26.Location = New System.Drawing.Point(16, 90)
            Me.radioButton26.Name = "radioButton26"
            Me.radioButton26.Size = New System.Drawing.Size(106, 17)
            Me.radioButton26.TabIndex = 2
            Me.radioButton26.TabStop = True
            Me.radioButton26.Text = "Last Seven Days"
            Me.radioButton26.UseVisualStyleBackColor = True
            '
            'radioButton19
            '
            Me.radioButton19.BackColor = System.Drawing.SystemColors.Window
            Me.radioButton19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton19.Location = New System.Drawing.Point(16, 68)
            Me.radioButton19.Name = "radioButton19"
            Me.radioButton19.Size = New System.Drawing.Size(176, 24)
            Me.radioButton19.TabIndex = 3
            Me.radioButton19.Text = "Entry List"
            Me.radioButton19.UseVisualStyleBackColor = False
            '
            'radioButton20
            '
            Me.radioButton20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton20.Location = New System.Drawing.Point(16, 46)
            Me.radioButton20.Name = "radioButton20"
            Me.radioButton20.Size = New System.Drawing.Size(176, 24)
            Me.radioButton20.TabIndex = 2
            Me.radioButton20.Text = "By Category"
            '
            'radioButton21
            '
            Me.radioButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton21.Location = New System.Drawing.Point(16, 24)
            Me.radioButton21.Name = "radioButton21"
            Me.radioButton21.Size = New System.Drawing.Size(176, 24)
            Me.radioButton21.TabIndex = 1
            Me.radioButton21.Text = "By Contact"
            '
            'radioButton22
            '
            Me.radioButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton22.Location = New System.Drawing.Point(16, 2)
            Me.radioButton22.Name = "radioButton22"
            Me.radioButton22.Size = New System.Drawing.Size(176, 24)
            Me.radioButton22.TabIndex = 0
            Me.radioButton22.Text = "By Type"
            '
            'linkLabel24
            '
            Me.linkLabel24.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel24.AutoSize = True
            Me.linkLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel24.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel24.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel24.Location = New System.Drawing.Point(15, 293)
            Me.linkLabel24.Name = "linkLabel24"
            Me.linkLabel24.Size = New System.Drawing.Size(121, 13)
            Me.linkLabel24.TabIndex = 2
            Me.linkLabel24.TabStop = True
            Me.linkLabel24.Text = "Share My Journal Folder"
            Me.linkLabel24.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel11
            '
            Me.linkLabel11.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel11.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel11.Location = New System.Drawing.Point(15, 276)
            Me.linkLabel11.Name = "linkLabel11"
            Me.linkLabel11.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel11.TabIndex = 0
            Me.linkLabel11.TabStop = True
            Me.linkLabel11.Text = "Open a Shared Journal..."
            Me.linkLabel11.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel9
            '
            Me.linkLabel9.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel9.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel9.Location = New System.Drawing.Point(15, 327)
            Me.linkLabel9.Name = "linkLabel9"
            Me.linkLabel9.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel9.TabIndex = 1
            Me.linkLabel9.TabStop = True
            Me.linkLabel9.Text = "Customize Current View..."
            Me.linkLabel9.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'notesPanel
            '
            Me.notesPanel.Controls.Add(Me.gradientPanel7)
            Me.notesPanel.Location = New System.Drawing.Point(1, 27)
            Me.notesPanel.Name = "notesPanel"
            Me.notesPanel.Size = New System.Drawing.Size(200, 409)
            Me.notesPanel.TabIndex = 1
            '
            'gradientPanel7
            '
            Me.gradientPanel7.BackColor = System.Drawing.Color.White
            Me.gradientPanel7.BorderColor = System.Drawing.Color.Black
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
            Me.gradientPanel7.Size = New System.Drawing.Size(200, 409)
            Me.gradientPanel7.TabIndex = 0
            '
            'linkLabel22
            '
            Me.linkLabel22.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel22.AutoSize = True
            Me.linkLabel22.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel22.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel22.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel22.Location = New System.Drawing.Point(15, 249)
            Me.linkLabel22.Name = "linkLabel22"
            Me.linkLabel22.Size = New System.Drawing.Size(124, 13)
            Me.linkLabel22.TabIndex = 0
            Me.linkLabel22.TabStop = True
            Me.linkLabel22.Text = "Share My Notes Folder..."
            Me.linkLabel22.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'panel5
            '
            Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel5.Location = New System.Drawing.Point(0, 215)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(200, 5)
            Me.panel5.TabIndex = 1
            '
            'linkLabel23
            '
            Me.linkLabel23.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel23.AutoSize = True
            Me.linkLabel23.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel23.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel23.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel23.Location = New System.Drawing.Point(15, 267)
            Me.linkLabel23.Name = "linkLabel23"
            Me.linkLabel23.Size = New System.Drawing.Size(83, 13)
            Me.linkLabel23.TabIndex = 1
            Me.linkLabel23.TabStop = True
            Me.linkLabel23.Text = "Add New Group"
            Me.linkLabel23.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'xpTaskBar4
            '
            Me.xpTaskBar4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar4.Controls.Add(Me.notesTaskBarBox)
            Me.xpTaskBar4.Controls.Add(Me.currentViewTaskBarBox2)
            Me.xpTaskBar4.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpTaskBar4.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar4.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar4.Name = "xpTaskBar4"
            Me.xpTaskBar4.Size = New System.Drawing.Size(200, 215)
            Me.xpTaskBar4.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar4.TabIndex = 0
            Me.xpTaskBar4.VerticalPadding = 4
            '
            'notesTaskBarBox
            '
            Me.notesTaskBarBox.DrawFocusRect = False
            Me.notesTaskBarBox.FocusOnClick = False
            Me.notesTaskBarBox.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.notesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.notesTaskBarBox.HeaderImageIndex = -1
            Me.notesTaskBarBox.HitTaskBoxArea = False
            Me.notesTaskBarBox.ImageList = Me.smallImageList
            Me.notesTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Notes", System.Drawing.Color.Empty, 11, Nothing, "", True, True, "XPTaskBarItem8", New System.Drawing.Font("Microsoft Sans Serif", 8.25!), 0)})
            Me.notesTaskBarBox.Location = New System.Drawing.Point(0, 0)
            Me.notesTaskBarBox.Name = "notesTaskBarBox"
            Me.notesTaskBarBox.Size = New System.Drawing.Size(198, 40)
            Me.notesTaskBarBox.TabIndex = 0
            Me.notesTaskBarBox.Text = "My Notes"
            '
            'currentViewTaskBarBox2
            '
            Me.currentViewTaskBarBox2.Controls.Add(Me.panel9)
            Me.currentViewTaskBarBox2.DrawFocusRect = False
            Me.currentViewTaskBarBox2.FocusOnClick = False
            Me.currentViewTaskBarBox2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.currentViewTaskBarBox2.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.currentViewTaskBarBox2.HeaderImageIndex = -1
            Me.currentViewTaskBarBox2.HitTaskBoxArea = False
            Me.currentViewTaskBarBox2.Location = New System.Drawing.Point(0, 44)
            Me.currentViewTaskBarBox2.Name = "currentViewTaskBarBox2"
            Me.currentViewTaskBarBox2.PreferredChildPanelHeight = 125
            Me.currentViewTaskBarBox2.Size = New System.Drawing.Size(198, 149)
            Me.currentViewTaskBarBox2.TabIndex = 1
            Me.currentViewTaskBarBox2.Text = "Current View"
            '
            'panel9
            '
            Me.panel9.BackColor = System.Drawing.Color.White
            Me.panel9.Controls.Add(Me.radioButton13)
            Me.panel9.Controls.Add(Me.radioButton14)
            Me.panel9.Controls.Add(Me.radioButton15)
            Me.panel9.Controls.Add(Me.radioButton16)
            Me.panel9.Controls.Add(Me.radioButton17)
            Me.panel9.Location = New System.Drawing.Point(2, 22)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(194, 125)
            Me.panel9.TabIndex = 6
            '
            'radioButton13
            '
            Me.radioButton13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton13.Location = New System.Drawing.Point(16, 98)
            Me.radioButton13.Name = "radioButton13"
            Me.radioButton13.Size = New System.Drawing.Size(176, 24)
            Me.radioButton13.TabIndex = 4
            Me.radioButton13.Text = "Outlook Data Files"
            '
            'radioButton14
            '
            Me.radioButton14.BackColor = System.Drawing.SystemColors.Window
            Me.radioButton14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton14.Location = New System.Drawing.Point(16, 75)
            Me.radioButton14.Name = "radioButton14"
            Me.radioButton14.Size = New System.Drawing.Size(176, 24)
            Me.radioButton14.TabIndex = 3
            Me.radioButton14.Text = "By Category"
            Me.radioButton14.UseVisualStyleBackColor = False
            '
            'radioButton15
            '
            Me.radioButton15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton15.Location = New System.Drawing.Point(16, 52)
            Me.radioButton15.Name = "radioButton15"
            Me.radioButton15.Size = New System.Drawing.Size(176, 24)
            Me.radioButton15.TabIndex = 2
            Me.radioButton15.Text = "Last Seven Days"
            '
            'radioButton16
            '
            Me.radioButton16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton16.Location = New System.Drawing.Point(16, 29)
            Me.radioButton16.Name = "radioButton16"
            Me.radioButton16.Size = New System.Drawing.Size(176, 24)
            Me.radioButton16.TabIndex = 1
            Me.radioButton16.Text = "Notes List"
            '
            'radioButton17
            '
            Me.radioButton17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton17.Location = New System.Drawing.Point(16, 6)
            Me.radioButton17.Name = "radioButton17"
            Me.radioButton17.Size = New System.Drawing.Size(176, 24)
            Me.radioButton17.TabIndex = 0
            Me.radioButton17.Text = "Icons"
            '
            'linkLabel5
            '
            Me.linkLabel5.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel5.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel5.Location = New System.Drawing.Point(15, 288)
            Me.linkLabel5.Name = "linkLabel5"
            Me.linkLabel5.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel5.TabIndex = 1
            Me.linkLabel5.TabStop = True
            Me.linkLabel5.Text = "Customize Current View..."
            Me.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel6
            '
            Me.linkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel6.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel6.Location = New System.Drawing.Point(15, 232)
            Me.linkLabel6.Name = "linkLabel6"
            Me.linkLabel6.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel6.TabIndex = 0
            Me.linkLabel6.TabStop = True
            Me.linkLabel6.Text = "Open Shared Notes..."
            Me.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'tasksPanel
            '
            Me.tasksPanel.BackColor = System.Drawing.SystemColors.Window
            Me.tasksPanel.Controls.Add(Me.gradientPanel6)
            Me.tasksPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tasksPanel.Location = New System.Drawing.Point(1, 27)
            Me.tasksPanel.Name = "tasksPanel"
            Me.tasksPanel.Size = New System.Drawing.Size(200, 409)
            Me.tasksPanel.TabIndex = 1
            '
            'gradientPanel6
            '
            Me.gradientPanel6.BorderColor = System.Drawing.Color.Black
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
            Me.gradientPanel6.Size = New System.Drawing.Size(200, 409)
            Me.gradientPanel6.TabIndex = 0
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel4.Location = New System.Drawing.Point(0, 359)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(200, 5)
            Me.panel4.TabIndex = 1005
            '
            'linkLabel20
            '
            Me.linkLabel20.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel20.AutoSize = True
            Me.linkLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel20.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel20.Location = New System.Drawing.Point(15, 392)
            Me.linkLabel20.Name = "linkLabel20"
            Me.linkLabel20.Size = New System.Drawing.Size(125, 13)
            Me.linkLabel20.TabIndex = 1003
            Me.linkLabel20.TabStop = True
            Me.linkLabel20.Text = "Share My Tasks Folder..."
            Me.linkLabel20.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'xpTaskBar3
            '
            Me.xpTaskBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar3.Controls.Add(Me.mytasksTaskBarBox)
            Me.xpTaskBar3.Controls.Add(Me.currentViewTaskBarBox1)
            Me.xpTaskBar3.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpTaskBar3.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar3.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar3.Name = "xpTaskBar3"
            Me.xpTaskBar3.Size = New System.Drawing.Size(200, 359)
            Me.xpTaskBar3.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar3.TabIndex = 0
            Me.xpTaskBar3.VerticalPadding = 4
            '
            'mytasksTaskBarBox
            '
            Me.mytasksTaskBarBox.DrawFocusRect = False
            Me.mytasksTaskBarBox.FocusOnClick = False
            Me.mytasksTaskBarBox.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mytasksTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.mytasksTaskBarBox.HeaderImageIndex = -1
            Me.mytasksTaskBarBox.HitTaskBoxArea = False
            Me.mytasksTaskBarBox.ImageList = Me.smallImageList
            Me.mytasksTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("To-Do List", System.Drawing.Color.Empty, 49, Nothing, "", True, True, "XPTaskBarItem5", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks", System.Drawing.Color.Empty, 10, Nothing, "", True, True, "XPTaskBarItem6", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks in Archive Folders", System.Drawing.Color.Empty, 10, Nothing, "", True, True, "XPTaskBarItem7", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0)})
            Me.mytasksTaskBarBox.Location = New System.Drawing.Point(0, 0)
            Me.mytasksTaskBarBox.Name = "mytasksTaskBarBox"
            Me.mytasksTaskBarBox.Size = New System.Drawing.Size(198, 76)
            Me.mytasksTaskBarBox.TabIndex = 0
            Me.mytasksTaskBarBox.Text = "My Tasks"
            '
            'currentViewTaskBarBox1
            '
            Me.currentViewTaskBarBox1.Controls.Add(Me.panel7)
            Me.currentViewTaskBarBox1.DrawFocusRect = False
            Me.currentViewTaskBarBox1.FocusOnClick = False
            Me.currentViewTaskBarBox1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.currentViewTaskBarBox1.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.currentViewTaskBarBox1.HeaderImageIndex = -1
            Me.currentViewTaskBarBox1.HitTaskBoxArea = False
            Me.currentViewTaskBarBox1.Location = New System.Drawing.Point(0, 80)
            Me.currentViewTaskBarBox1.Name = "currentViewTaskBarBox1"
            Me.currentViewTaskBarBox1.PreferredChildPanelHeight = 232
            Me.currentViewTaskBarBox1.Size = New System.Drawing.Size(198, 256)
            Me.currentViewTaskBarBox1.TabIndex = 1
            Me.currentViewTaskBarBox1.Text = "Current View"
            '
            'panel7
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
            Me.panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel7.Location = New System.Drawing.Point(2, 22)
            Me.panel7.Name = "panel7"
            Me.panel7.Size = New System.Drawing.Size(194, 232)
            Me.panel7.TabIndex = 6
            '
            'radioButton31
            '
            Me.radioButton31.AutoSize = True
            Me.radioButton31.Location = New System.Drawing.Point(16, 209)
            Me.radioButton31.Name = "radioButton31"
            Me.radioButton31.Size = New System.Drawing.Size(74, 17)
            Me.radioButton31.TabIndex = 12
            Me.radioButton31.TabStop = True
            Me.radioButton31.Text = "To-Do List"
            Me.radioButton31.UseVisualStyleBackColor = True
            '
            'radioButton30
            '
            Me.radioButton30.AutoSize = True
            Me.radioButton30.Location = New System.Drawing.Point(16, 190)
            Me.radioButton30.Name = "radioButton30"
            Me.radioButton30.Size = New System.Drawing.Size(112, 17)
            Me.radioButton30.TabIndex = 11
            Me.radioButton30.TabStop = True
            Me.radioButton30.Text = "Outlook Data Files"
            Me.radioButton30.UseVisualStyleBackColor = True
            '
            'radioButton28
            '
            Me.radioButton28.AutoSize = True
            Me.radioButton28.Location = New System.Drawing.Point(16, 170)
            Me.radioButton28.Name = "radioButton28"
            Me.radioButton28.Size = New System.Drawing.Size(96, 17)
            Me.radioButton28.TabIndex = 9
            Me.radioButton28.TabStop = True
            Me.radioButton28.Text = "Tasks Timeline"
            Me.radioButton28.UseVisualStyleBackColor = True
            '
            'radioButton27
            '
            Me.radioButton27.AutoSize = True
            Me.radioButton27.Location = New System.Drawing.Point(16, 147)
            Me.radioButton27.Name = "radioButton27"
            Me.radioButton27.Size = New System.Drawing.Size(107, 17)
            Me.radioButton27.TabIndex = 8
            Me.radioButton27.TabStop = True
            Me.radioButton27.Text = "Completed Tasks"
            Me.radioButton27.UseVisualStyleBackColor = True
            '
            'radioButton12
            '
            Me.radioButton12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton12.Location = New System.Drawing.Point(16, 125)
            Me.radioButton12.Name = "radioButton12"
            Me.radioButton12.Size = New System.Drawing.Size(176, 24)
            Me.radioButton12.TabIndex = 6
            Me.radioButton12.Text = "Assignment"
            '
            'radioButton11
            '
            Me.radioButton11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton11.Location = New System.Drawing.Point(16, 104)
            Me.radioButton11.Name = "radioButton11"
            Me.radioButton11.Size = New System.Drawing.Size(176, 24)
            Me.radioButton11.TabIndex = 5
            Me.radioButton11.Text = "By Category"
            '
            'radioButton6
            '
            Me.radioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton6.Location = New System.Drawing.Point(16, 83)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.Size = New System.Drawing.Size(176, 24)
            Me.radioButton6.TabIndex = 4
            Me.radioButton6.Text = "Overdue Tasks"
            '
            'radioButton7
            '
            Me.radioButton7.BackColor = System.Drawing.SystemColors.Window
            Me.radioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton7.Location = New System.Drawing.Point(16, 63)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.Size = New System.Drawing.Size(176, 24)
            Me.radioButton7.TabIndex = 3
            Me.radioButton7.Text = "Next Seven Days"
            Me.radioButton7.UseVisualStyleBackColor = False
            '
            'radioButton8
            '
            Me.radioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton8.Location = New System.Drawing.Point(16, 43)
            Me.radioButton8.Name = "radioButton8"
            Me.radioButton8.Size = New System.Drawing.Size(176, 24)
            Me.radioButton8.TabIndex = 2
            Me.radioButton8.Text = "Active Tasks"
            '
            'radioButton9
            '
            Me.radioButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton9.Location = New System.Drawing.Point(16, 23)
            Me.radioButton9.Name = "radioButton9"
            Me.radioButton9.Size = New System.Drawing.Size(176, 24)
            Me.radioButton9.TabIndex = 1
            Me.radioButton9.Text = "Detailed List"
            '
            'radioButton10
            '
            Me.radioButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton10.Location = New System.Drawing.Point(16, 4)
            Me.radioButton10.Name = "radioButton10"
            Me.radioButton10.Size = New System.Drawing.Size(176, 24)
            Me.radioButton10.TabIndex = 0
            Me.radioButton10.Text = "Simple List"
            '
            'linkLabel21
            '
            Me.linkLabel21.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel21.AutoSize = True
            Me.linkLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel21.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel21.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel21.Location = New System.Drawing.Point(15, 411)
            Me.linkLabel21.Name = "linkLabel21"
            Me.linkLabel21.Size = New System.Drawing.Size(83, 13)
            Me.linkLabel21.TabIndex = 1004
            Me.linkLabel21.TabStop = True
            Me.linkLabel21.Text = "Add New Group"
            Me.linkLabel21.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel4
            '
            Me.linkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel4.Location = New System.Drawing.Point(15, 374)
            Me.linkLabel4.Name = "linkLabel4"
            Me.linkLabel4.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel4.TabIndex = 0
            Me.linkLabel4.TabStop = True
            Me.linkLabel4.Text = "Open Shared Tasks..."
            Me.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel3
            '
            Me.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel3.Location = New System.Drawing.Point(15, 430)
            Me.linkLabel3.Name = "linkLabel3"
            Me.linkLabel3.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel3.TabIndex = 1
            Me.linkLabel3.TabStop = True
            Me.linkLabel3.Text = "Customize Current View..."
            Me.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'contactsPanel
            '
            Me.contactsPanel.Controls.Add(Me.gradientPanel5)
            Me.contactsPanel.Location = New System.Drawing.Point(1, 27)
            Me.contactsPanel.Name = "contactsPanel"
            Me.contactsPanel.Size = New System.Drawing.Size(200, 409)
            Me.contactsPanel.TabIndex = 1
            '
            'gradientPanel5
            '
            Me.gradientPanel5.BackColor = System.Drawing.Color.White
            Me.gradientPanel5.BorderColor = System.Drawing.Color.Black
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
            Me.gradientPanel5.Size = New System.Drawing.Size(200, 409)
            Me.gradientPanel5.TabIndex = 0
            '
            'linkLabel1
            '
            Me.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel1.Location = New System.Drawing.Point(15, 263)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(124, 13)
            Me.linkLabel1.TabIndex = 1003
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Text = "Open Shared Contacts..."
            Me.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(0, 253)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(200, 5)
            Me.panel3.TabIndex = 1
            '
            'linkLabel2
            '
            Me.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel2.AutoSize = True
            Me.linkLabel2.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel2.Location = New System.Drawing.Point(15, 281)
            Me.linkLabel2.Name = "linkLabel2"
            Me.linkLabel2.Size = New System.Drawing.Size(138, 13)
            Me.linkLabel2.TabIndex = 1004
            Me.linkLabel2.TabStop = True
            Me.linkLabel2.Text = "Share My Contacts Folder..."
            Me.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'xpTaskBar2
            '
            Me.xpTaskBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar2.Controls.Add(Me.myContactsTaskBarBox)
            Me.xpTaskBar2.Controls.Add(Me.currentViewTaskBarBox)
            Me.xpTaskBar2.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpTaskBar2.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar2.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar2.Name = "xpTaskBar2"
            Me.xpTaskBar2.Size = New System.Drawing.Size(200, 253)
            Me.xpTaskBar2.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar2.TabIndex = 0
            Me.xpTaskBar2.VerticalPadding = 4
            '
            'myContactsTaskBarBox
            '
            Me.myContactsTaskBarBox.BackColor = System.Drawing.SystemColors.Control
            Me.myContactsTaskBarBox.DrawFocusRect = False
            Me.myContactsTaskBarBox.FocusOnClick = False
            Me.myContactsTaskBarBox.HeaderImageIndex = -1
            Me.myContactsTaskBarBox.HitTaskBoxArea = False
            Me.myContactsTaskBarBox.ImageList = Me.smallImageList
            Me.myContactsTaskBarBox.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Contacts", System.Drawing.Color.Empty, 38, Nothing, "", True, True, "XPTaskBarItem4", New System.Drawing.Font("Microsoft Sans Serif", 8.25!), 0)})
            Me.myContactsTaskBarBox.Location = New System.Drawing.Point(0, 0)
            Me.myContactsTaskBarBox.Name = "myContactsTaskBarBox"
            Me.myContactsTaskBarBox.Size = New System.Drawing.Size(198, 40)
            Me.myContactsTaskBarBox.TabIndex = 0
            Me.myContactsTaskBarBox.Text = "MyContacts"
            '
            'currentViewTaskBarBox
            '
            Me.currentViewTaskBarBox.Controls.Add(Me.panel2)
            Me.currentViewTaskBarBox.DrawFocusRect = False
            Me.currentViewTaskBarBox.FocusOnClick = False
            Me.currentViewTaskBarBox.HeaderImageIndex = -1
            Me.currentViewTaskBarBox.HitTaskBoxArea = False
            Me.currentViewTaskBarBox.Location = New System.Drawing.Point(0, 44)
            Me.currentViewTaskBarBox.Name = "currentViewTaskBarBox"
            Me.currentViewTaskBarBox.PreferredChildPanelHeight = 165
            Me.currentViewTaskBarBox.Size = New System.Drawing.Size(198, 189)
            Me.currentViewTaskBarBox.TabIndex = 1
            Me.currentViewTaskBarBox.Text = "Current View"
            '
            'panel2
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
            Me.panel2.Location = New System.Drawing.Point(2, 22)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(194, 165)
            Me.panel2.TabIndex = 2
            '
            'radioButton25
            '
            Me.radioButton25.AutoSize = True
            Me.radioButton25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton25.Location = New System.Drawing.Point(16, 143)
            Me.radioButton25.Name = "radioButton25"
            Me.radioButton25.Size = New System.Drawing.Size(112, 17)
            Me.radioButton25.TabIndex = 2
            Me.radioButton25.TabStop = True
            Me.radioButton25.Text = "Outlook Data Files"
            Me.radioButton25.UseVisualStyleBackColor = True
            '
            'radioButton5
            '
            Me.radioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton5.Location = New System.Drawing.Point(16, 102)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.Size = New System.Drawing.Size(176, 24)
            Me.radioButton5.TabIndex = 4
            Me.radioButton5.Text = "By Company"
            '
            'radioButton24
            '
            Me.radioButton24.AutoSize = True
            Me.radioButton24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton24.Location = New System.Drawing.Point(16, 123)
            Me.radioButton24.Name = "radioButton24"
            Me.radioButton24.Size = New System.Drawing.Size(81, 17)
            Me.radioButton24.TabIndex = 1
            Me.radioButton24.TabStop = True
            Me.radioButton24.Text = "By Location"
            Me.radioButton24.UseVisualStyleBackColor = True
            '
            'radioButton4
            '
            Me.radioButton4.BackColor = System.Drawing.SystemColors.Window
            Me.radioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton4.Location = New System.Drawing.Point(16, 82)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(176, 24)
            Me.radioButton4.TabIndex = 3
            Me.radioButton4.Text = "By Category"
            Me.radioButton4.UseVisualStyleBackColor = False
            '
            'radioButton23
            '
            Me.radioButton23.AutoSize = True
            Me.radioButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton23.Location = New System.Drawing.Point(16, 7)
            Me.radioButton23.Name = "radioButton23"
            Me.radioButton23.Size = New System.Drawing.Size(97, 17)
            Me.radioButton23.TabIndex = 0
            Me.radioButton23.TabStop = True
            Me.radioButton23.Text = "Business Cards"
            Me.radioButton23.UseVisualStyleBackColor = True
            '
            'radioButton3
            '
            Me.radioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton3.Location = New System.Drawing.Point(16, 62)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(176, 24)
            Me.radioButton3.TabIndex = 2
            Me.radioButton3.Text = "Phone List"
            '
            'radioButton2
            '
            Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton2.Location = New System.Drawing.Point(16, 42)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(176, 24)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "Detailed Address Cards"
            '
            'radioButton1
            '
            Me.radioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton1.Location = New System.Drawing.Point(16, 23)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(176, 24)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.Text = "Address Cards"
            '
            'linkLabel18
            '
            Me.linkLabel18.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel18.AutoSize = True
            Me.linkLabel18.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel18.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel18.Location = New System.Drawing.Point(15, 298)
            Me.linkLabel18.Name = "linkLabel18"
            Me.linkLabel18.Size = New System.Drawing.Size(83, 13)
            Me.linkLabel18.TabIndex = 1005
            Me.linkLabel18.TabStop = True
            Me.linkLabel18.Text = "Add New Group"
            Me.linkLabel18.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel19
            '
            Me.linkLabel19.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel19.AutoSize = True
            Me.linkLabel19.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel19.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel19.Location = New System.Drawing.Point(15, 316)
            Me.linkLabel19.Name = "linkLabel19"
            Me.linkLabel19.Size = New System.Drawing.Size(127, 13)
            Me.linkLabel19.TabIndex = 1006
            Me.linkLabel19.TabStop = True
            Me.linkLabel19.Text = "Customize Current View..."
            Me.linkLabel19.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'calendarPanel
            '
            Me.calendarPanel.BackColor = System.Drawing.Color.White
            Me.calendarPanel.Controls.Add(Me.gradientPanel3)
            Me.calendarPanel.Location = New System.Drawing.Point(1, 27)
            Me.calendarPanel.Name = "calendarPanel"
            Me.calendarPanel.Size = New System.Drawing.Size(200, 409)
            Me.calendarPanel.TabIndex = 1
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.gradientPanel3.BorderColor = System.Drawing.Color.Black
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
            Me.gradientPanel3.Location = New System.Drawing.Point(0, 171)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(200, 238)
            Me.gradientPanel3.TabIndex = 0
            '
            'linkLabel10
            '
            Me.linkLabel10.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel10.AutoSize = True
            Me.linkLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel10.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel10.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel10.Location = New System.Drawing.Point(9, 96)
            Me.linkLabel10.Name = "linkLabel10"
            Me.linkLabel10.Size = New System.Drawing.Size(122, 13)
            Me.linkLabel10.TabIndex = 2
            Me.linkLabel10.TabStop = True
            Me.linkLabel10.Text = "How to Share Calendars"
            Me.linkLabel10.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'panel11
            '
            Me.panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel11.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel11.Location = New System.Drawing.Point(0, 79)
            Me.panel11.Name = "panel11"
            Me.panel11.Size = New System.Drawing.Size(196, 5)
            Me.panel11.TabIndex = 1
            '
            'linkLabel12
            '
            Me.linkLabel12.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel12.AutoSize = True
            Me.linkLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel12.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel12.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel12.Location = New System.Drawing.Point(9, 117)
            Me.linkLabel12.Name = "linkLabel12"
            Me.linkLabel12.Size = New System.Drawing.Size(133, 13)
            Me.linkLabel12.TabIndex = 3
            Me.linkLabel12.TabStop = True
            Me.linkLabel12.Text = "Open a Shared Calendar..."
            Me.linkLabel12.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel13
            '
            Me.linkLabel13.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel13.AutoSize = True
            Me.linkLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel13.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel13.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel13.Location = New System.Drawing.Point(10, 134)
            Me.linkLabel13.Name = "linkLabel13"
            Me.linkLabel13.Size = New System.Drawing.Size(124, 13)
            Me.linkLabel13.TabIndex = 4
            Me.linkLabel13.TabStop = True
            Me.linkLabel13.Text = "Search Calendars Online"
            Me.linkLabel13.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'xpTaskBar1
            '
            Me.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar1.Controls.Add(Me.myCalendarsTaskBarBox1)
            Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpTaskBar1.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar1.Name = "xpTaskBar1"
            Me.xpTaskBar1.Size = New System.Drawing.Size(196, 79)
            Me.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar1.TabIndex = 0
            Me.xpTaskBar1.VerticalPadding = 4
            '
            'myCalendarsTaskBarBox1
            '
            Me.myCalendarsTaskBarBox1.Controls.Add(Me.gradientPanel4)
            Me.myCalendarsTaskBarBox1.DrawFocusRect = False
            Me.myCalendarsTaskBarBox1.FocusOnClick = False
            Me.myCalendarsTaskBarBox1.HeaderForeColor = System.Drawing.Color.DarkBlue
            Me.myCalendarsTaskBarBox1.HeaderImageIndex = -1
            Me.myCalendarsTaskBarBox1.HitTaskBoxArea = False
            Me.myCalendarsTaskBarBox1.Location = New System.Drawing.Point(0, 0)
            Me.myCalendarsTaskBarBox1.Name = "myCalendarsTaskBarBox1"
            Me.myCalendarsTaskBarBox1.PreferredChildPanelHeight = 45
            Me.myCalendarsTaskBarBox1.Size = New System.Drawing.Size(194, 69)
            Me.myCalendarsTaskBarBox1.TabIndex = 0
            Me.myCalendarsTaskBarBox1.Text = "My Calendars"
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel4.Controls.Add(Me.checkBox2)
            Me.gradientPanel4.Controls.Add(Me.checkBox1)
            Me.gradientPanel4.Location = New System.Drawing.Point(2, 22)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(190, 45)
            Me.gradientPanel4.TabIndex = 0
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.BackColor = System.Drawing.Color.White
            Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.ImageIndex = 12
            Me.checkBox2.ImageList = Me.smallImageList
            Me.checkBox2.Location = New System.Drawing.Point(3, 23)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(166, 17)
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "Calendar in Archive Folder"
            Me.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.checkBox2.UseVisualStyleBackColor = False
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.BackColor = System.Drawing.Color.White
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.ImageIndex = 12
            Me.checkBox1.ImageList = Me.smallImageList
            Me.checkBox1.Location = New System.Drawing.Point(3, 3)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(84, 17)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Calendar"
            Me.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.checkBox1.UseVisualStyleBackColor = False
            '
            'linkLabel14
            '
            Me.linkLabel14.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel14.AutoSize = True
            Me.linkLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel14.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel14.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel14.Location = New System.Drawing.Point(9, 158)
            Me.linkLabel14.Name = "linkLabel14"
            Me.linkLabel14.Size = New System.Drawing.Size(106, 13)
            Me.linkLabel14.TabIndex = 5
            Me.linkLabel14.TabStop = True
            Me.linkLabel14.Text = "Share My Calendar..."
            Me.linkLabel14.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel17
            '
            Me.linkLabel17.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel17.AutoSize = True
            Me.linkLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel17.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel17.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel17.Location = New System.Drawing.Point(9, 217)
            Me.linkLabel17.Name = "linkLabel17"
            Me.linkLabel17.Size = New System.Drawing.Size(83, 13)
            Me.linkLabel17.TabIndex = 8
            Me.linkLabel17.TabStop = True
            Me.linkLabel17.Text = "Add New Group"
            Me.linkLabel17.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel15
            '
            Me.linkLabel15.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel15.AutoSize = True
            Me.linkLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel15.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel15.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel15.Location = New System.Drawing.Point(9, 175)
            Me.linkLabel15.Name = "linkLabel15"
            Me.linkLabel15.Size = New System.Drawing.Size(143, 13)
            Me.linkLabel15.TabIndex = 6
            Me.linkLabel15.TabStop = True
            Me.linkLabel15.Text = "Send a Calendar via E-mail..."
            Me.linkLabel15.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'linkLabel16
            '
            Me.linkLabel16.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel16.AutoSize = True
            Me.linkLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel16.ForeColor = System.Drawing.SystemColors.Desktop
            Me.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel16.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel16.Location = New System.Drawing.Point(9, 190)
            Me.linkLabel16.Name = "linkLabel16"
            Me.linkLabel16.Size = New System.Drawing.Size(112, 13)
            Me.linkLabel16.TabIndex = 7
            Me.linkLabel16.TabStop = True
            Me.linkLabel16.Text = "Publish My Calendar..."
            Me.linkLabel16.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'folderlistPanel
            '
            Me.folderlistPanel.Controls.Add(Me.gradientPanel8)
            Me.folderlistPanel.Location = New System.Drawing.Point(1, 27)
            Me.folderlistPanel.Name = "folderlistPanel"
            Me.folderlistPanel.Size = New System.Drawing.Size(200, 409)
            Me.folderlistPanel.TabIndex = 1
            '
            'gradientPanel8
            '
            Me.gradientPanel8.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel8.Controls.Add(Me.panel6)
            Me.gradientPanel8.Controls.Add(Me.xpTaskBar5)
            Me.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel8.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel8.Name = "gradientPanel8"
            Me.gradientPanel8.Size = New System.Drawing.Size(200, 409)
            Me.gradientPanel8.TabIndex = 0
            '
            'panel6
            '
            Me.panel6.BackColor = System.Drawing.Color.White
            Me.panel6.Controls.Add(Me.linkLabel7)
            Me.panel6.Controls.Add(Me.panel1)
            Me.panel6.Controls.Add(Me.linkLabel8)
            Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel6.Location = New System.Drawing.Point(0, 347)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(200, 62)
            Me.panel6.TabIndex = 2
            '
            'linkLabel7
            '
            Me.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel7.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel7.Location = New System.Drawing.Point(11, 31)
            Me.linkLabel7.Name = "linkLabel7"
            Me.linkLabel7.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel7.TabIndex = 1
            Me.linkLabel7.TabStop = True
            Me.linkLabel7.Text = "Data File Management..."
            Me.linkLabel7.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 5)
            Me.panel1.TabIndex = 1
            '
            'linkLabel8
            '
            Me.linkLabel8.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel8.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.linkLabel8.Location = New System.Drawing.Point(11, 10)
            Me.linkLabel8.Name = "linkLabel8"
            Me.linkLabel8.Size = New System.Drawing.Size(176, 16)
            Me.linkLabel8.TabIndex = 0
            Me.linkLabel8.TabStop = True
            Me.linkLabel8.Text = "Folder Sizes"
            Me.linkLabel8.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(178, Byte), Integer))
            '
            'xpTaskBar5
            '
            Me.xpTaskBar5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.xpTaskBar5.Controls.Add(Me.allFoldersTaskBarBox)
            Me.xpTaskBar5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xpTaskBar5.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar5.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar5.Name = "xpTaskBar5"
            Me.xpTaskBar5.Size = New System.Drawing.Size(200, 409)
            Me.xpTaskBar5.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
            Me.xpTaskBar5.TabIndex = 0
            Me.xpTaskBar5.VerticalPadding = 4
            '
            'allFoldersTaskBarBox
            '
            Me.allFoldersTaskBarBox.Controls.Add(Me.gradientPanel9)
            Me.allFoldersTaskBarBox.DrawFocusRect = False
            Me.allFoldersTaskBarBox.FocusOnClick = False
            Me.allFoldersTaskBarBox.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.allFoldersTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.allFoldersTaskBarBox.HeaderImageIndex = -1
            Me.allFoldersTaskBarBox.HitTaskBoxArea = False
            Me.allFoldersTaskBarBox.Location = New System.Drawing.Point(0, 0)
            Me.allFoldersTaskBarBox.Name = "allFoldersTaskBarBox"
            Me.allFoldersTaskBarBox.PreferredChildPanelHeight = 200
            Me.allFoldersTaskBarBox.Size = New System.Drawing.Size(198, 224)
            Me.allFoldersTaskBarBox.TabIndex = 0
            Me.allFoldersTaskBarBox.Text = "All Folders"
            '
            'gradientPanel9
            '
            Me.gradientPanel9.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel9.Controls.Add(Me.treeView1)
            Me.gradientPanel9.Location = New System.Drawing.Point(2, 22)
            Me.gradientPanel9.Name = "gradientPanel9"
            Me.gradientPanel9.Size = New System.Drawing.Size(194, 200)
            Me.gradientPanel9.TabIndex = 5
            '
            'treeView1
            '
            Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.treeView1.ImageIndex = 0
            Me.treeView1.ImageList = Me.smallImageList
            Me.treeView1.Indent = 25
            Me.treeView1.Location = New System.Drawing.Point(0, 0)
            Me.treeView1.Name = "treeView1"
            TreeNode17.ImageIndex = 3
            TreeNode17.Name = ""
            TreeNode17.SelectedImageIndex = 3
            TreeNode17.Text = "Junk Mail"
            TreeNode18.ImageIndex = 1
            TreeNode18.Name = ""
            TreeNode18.SelectedImageIndex = 1
            TreeNode18.Text = "Deleted Items"
            TreeNode19.ImageIndex = 0
            TreeNode19.Name = ""
            TreeNode19.SelectedImageIndex = 0
            TreeNode19.Text = "Junk Email"
            TreeNode20.ImageIndex = 2
            TreeNode20.Name = ""
            TreeNode20.SelectedImageIndex = 2
            TreeNode20.Text = "InBox"
            TreeNode21.ImageIndex = 6
            TreeNode21.Name = ""
            TreeNode21.SelectedImageIndex = 6
            TreeNode21.Text = "Sent Items"
            TreeNode22.ImageIndex = 4
            TreeNode22.Name = ""
            TreeNode22.SelectedImageIndex = 4
            TreeNode22.Text = "Search Folders"
            TreeNode23.Name = ""
            TreeNode23.Text = "Calendar"
            TreeNode24.ImageIndex = 9
            TreeNode24.Name = ""
            TreeNode24.SelectedImageIndex = 9
            TreeNode24.Text = "Contacts"
            TreeNode25.ImageIndex = 5
            TreeNode25.Name = ""
            TreeNode25.SelectedImageIndex = 5
            TreeNode25.Text = "Drafts"
            TreeNode26.ImageIndex = 13
            TreeNode26.Name = ""
            TreeNode26.SelectedImageIndex = 13
            TreeNode26.Text = "Journal"
            TreeNode27.ImageIndex = 7
            TreeNode27.Name = ""
            TreeNode27.SelectedImageIndex = 7
            TreeNode27.Text = "Personal Folders"
            TreeNode28.ImageIndex = 4
            TreeNode28.Name = ""
            TreeNode28.SelectedImageIndex = 4
            TreeNode28.Text = "Search Folders"
            TreeNode29.ImageIndex = 6
            TreeNode29.Name = ""
            TreeNode29.SelectedImageIndex = 6
            TreeNode29.Text = "Sent Items"
            TreeNode30.ImageIndex = 1
            TreeNode30.Name = ""
            TreeNode30.SelectedImageIndex = 1
            TreeNode30.Text = "Deleted Items"
            TreeNode31.ImageIndex = 8
            TreeNode31.Name = ""
            TreeNode31.SelectedImageIndex = 8
            TreeNode31.Text = "Archive Folders"
            TreeNode32.ImageIndex = 5
            TreeNode32.Name = ""
            TreeNode32.SelectedImageIndex = 5
            TreeNode32.Text = "Drafts"
            TreeNode33.ImageIndex = 2
            TreeNode33.Name = ""
            TreeNode33.SelectedImageIndex = 2
            TreeNode33.Text = "InBox"
            TreeNode34.ImageIndex = 3
            TreeNode34.Name = ""
            TreeNode34.SelectedImageIndex = 3
            TreeNode34.Text = "OutBox"
            TreeNode35.ImageIndex = 6
            TreeNode35.Name = ""
            TreeNode35.SelectedImageIndex = 6
            TreeNode35.Text = "Sent Items"
            TreeNode36.Name = ""
            TreeNode36.Text = "Public"
            TreeNode37.ImageIndex = 8
            TreeNode37.Name = ""
            TreeNode37.SelectedImageIndex = 8
            TreeNode37.Text = "Syncfusion Email"
            TreeNode38.ImageIndex = 4
            TreeNode38.Name = ""
            TreeNode38.SelectedImageIndex = 4
            TreeNode38.Text = "For Follow Up"
            TreeNode39.ImageIndex = 4
            TreeNode39.Name = ""
            TreeNode39.SelectedImageIndex = 4
            TreeNode39.Text = "Large Mail"
            TreeNode40.ImageIndex = 4
            TreeNode40.Name = ""
            TreeNode40.SelectedImageIndex = 4
            TreeNode40.Text = "Search Folders"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode31, TreeNode37, TreeNode40})
            Me.treeView1.SelectedImageIndex = 0
            Me.treeView1.ShowLines = False
            Me.treeView1.Size = New System.Drawing.Size(194, 200)
            Me.treeView1.TabIndex = 4
            '
            'groupBarItem1
            '
            Me.groupBarItem1.Client = Me.mailPanel
            Me.groupBarItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem1.Icon = CType(resources.GetObject("groupBarItem1.Icon"), System.Drawing.Icon)
            Me.groupBarItem1.NavigationPaneIcon = CType(resources.GetObject("groupBarItem1.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem1.Text = "Mail"
            '
            'groupBarItem7
            '
            Me.groupBarItem7.Client = Me.calendarPanel
            Me.groupBarItem7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem7.Icon = CType(resources.GetObject("groupBarItem7.Icon"), System.Drawing.Icon)
            Me.groupBarItem7.NavigationPaneIcon = CType(resources.GetObject("groupBarItem7.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem7.Text = "Calendar"
            '
            'groupBarItem3
            '
            Me.groupBarItem3.Client = Me.contactsPanel
            Me.groupBarItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem3.Icon = CType(resources.GetObject("groupBarItem3.Icon"), System.Drawing.Icon)
            Me.groupBarItem3.NavigationPaneIcon = CType(resources.GetObject("groupBarItem3.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem3.Text = "Contacts"
            '
            'groupBarItem4
            '
            Me.groupBarItem4.Client = Me.tasksPanel
            Me.groupBarItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem4.Icon = CType(resources.GetObject("groupBarItem4.Icon"), System.Drawing.Icon)
            Me.groupBarItem4.NavigationPaneIcon = CType(resources.GetObject("groupBarItem4.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem4.Text = "Tasks"
            '
            'groupBarItem5
            '
            Me.groupBarItem5.Client = Me.notesPanel
            Me.groupBarItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem5.Icon = CType(resources.GetObject("groupBarItem5.Icon"), System.Drawing.Icon)
            Me.groupBarItem5.NavigationPaneIcon = CType(resources.GetObject("groupBarItem5.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem5.Text = "Notes"
            '
            'groupBarItem6
            '
            Me.groupBarItem6.Client = Me.folderlistPanel
            Me.groupBarItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem6.Icon = CType(resources.GetObject("groupBarItem6.Icon"), System.Drawing.Icon)
            Me.groupBarItem6.NavigationPaneIcon = CType(resources.GetObject("groupBarItem6.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem6.Text = "Folder List"
            '
            'groupBarItem2
            '
            Me.groupBarItem2.Client = Me.journalPanel
            Me.groupBarItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.groupBarItem2.Icon = CType(resources.GetObject("groupBarItem2.Icon"), System.Drawing.Icon)
            Me.groupBarItem2.NavigationPaneIcon = CType(resources.GetObject("groupBarItem2.NavigationPaneIcon"), System.Drawing.Icon)
            Me.groupBarItem2.Text = "Journal"
            Me.groupBarItem2.Visible = False
            '
            'listView1
            '
            Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.listView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
            Me.listView1.Location = New System.Drawing.Point(1, 27)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(302, 246)
            Me.listView1.TabIndex = 1
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.List
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Bars.Add(Me.bar3)
            Me.mainFrameBarManager1.Categories.Add("&File")
            Me.mainFrameBarManager1.Categories.Add("&View")
            Me.mainFrameBarManager1.Categories.Add("&Edit")
            Me.mainFrameBarManager1.Categories.Add("&Go")
            Me.mainFrameBarManager1.Categories.Add("&Tools")
            Me.mainFrameBarManager1.Categories.Add("&Actions")
            Me.mainFrameBarManager1.Categories.Add("&Help")
            Me.mainFrameBarManager1.Categories.Add("Popups")
            Me.mainFrameBarManager1.Categories.Add("grid")
            Me.mainFrameBarManager1.Categories.Add("ScheduleView")
            Me.mainFrameBarManager1.Categories.Add("VisualStyles")
            Me.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.ImageList = Me.smallImageList
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2, Me.barItem1, Me.barItem2, Me.parentBarItem3, Me.barItem3, Me.barItem4, Me.barItem5, Me.parentBarItem10, Me.barItem37, Me.barItem38, Me.barItem39, Me.barItem40, Me.parentBarItem4, Me.barItem42, Me.barItem43, Me.barItem44, Me.barItem45, Me.parentBarItem5, Me.barItem46, Me.barItem29, Me.barItem52, Me.parentBarItem6, Me.barItem53, Me.parentBarItem8, Me.parentBarItem9, Me.barItem6, Me.barItem7, Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem15, Me.barItem16, Me.barItem17, Me.barItem18, Me.parentBarItem11, Me.barItem19, Me.parentBarItem12, Me.barItem20, Me.parentBarItem13, Me.barItem21, Me.parentBarItem14, Me.barItem22, Me.mailBarItem, Me.calendarBarItem, Me.contactsBarItem, Me.tasksBarItem, Me.notesBarItem, Me.folderlistBarItem, Me.journalBarItem, Me.barItem31, Me.barItem32, Me.parentBarItem7, Me.parentBarItem15, Me.parentBarItem16, Me.barItem33, Me.barItem34, Me.barItem35, Me.barItem36, Me.barItem41, Me.barItem47, Me.barItem48, Me.barItem49, Me.barItem50, Me.barItem51, Me.barItem54, Me.barItem55, Me.barItem56, Me.barItem57, Me.barItem58, Me.barItem59, Me.barItem60, Me.barItem23, Me.barItem24, Me.barItem25, Me.barItem26, Me.barItem27, Me.barItem28, Me.barItem30, Me.barItem62, Me.barItem_AutoPreview, Me.barItem63, Me.barItem64, Me.barItem65, Me.barItem66, Me.barItem67, Me.barItem68, Me.blueStyleBarItem, Me.blackStyleBarItem, Me.silverStyleBarItem, Me.parentBarItem17})
            Me.mainFrameBarManager1.LargeImageList = Me.imageList1
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem4, Me.parentBarItem5, Me.parentBarItem6, Me.parentBarItem8, Me.parentBarItem9, Me.parentBarItem17})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 0
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem10, Me.parentBarItem2, Me.barItem1, Me.barItem2, Me.parentBarItem3, Me.barItem3, Me.barItem4, Me.barItem5})
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {3, 4, 7})
            Me.parentBarItem1.Text = "&File"
            '
            'parentBarItem10
            '
            Me.parentBarItem10.CategoryIndex = 0
            Me.parentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem10.ID = "Ne&w"
            Me.parentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem29, Me.barItem37, Me.barItem38, Me.barItem39, Me.barItem40, Me.barItem42, Me.barItem43, Me.barItem44})
            Me.parentBarItem10.SeparatorIndices.AddRange(New Integer() {1, 3})
            Me.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
            Me.parentBarItem10.Text = "Ne&w"
            '
            'barItem29
            '
            Me.barItem29.CategoryIndex = 0
            Me.barItem29.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem29.ID = "&Mail Message"
            Me.barItem29.ImageIndex = 25
            Me.barItem29.Text = "&Mail Message"
            '
            'barItem37
            '
            Me.barItem37.CategoryIndex = 0
            Me.barItem37.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem37.ID = "Folder"
            Me.barItem37.ImageIndex = 3
            Me.barItem37.Text = "Folder"
            '
            'barItem38
            '
            Me.barItem38.CategoryIndex = 0
            Me.barItem38.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem38.ID = "Search Folder"
            Me.barItem38.ImageIndex = 4
            Me.barItem38.Text = "Search Folder"
            '
            'barItem39
            '
            Me.barItem39.CategoryIndex = 0
            Me.barItem39.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem39.ID = "Appointment"
            Me.barItem39.ImageIndex = 12
            Me.barItem39.Text = "Appointment"
            '
            'barItem40
            '
            Me.barItem40.CategoryIndex = 0
            Me.barItem40.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem40.ID = "Contact"
            Me.barItem40.ImageIndex = 9
            Me.barItem40.Text = "Contact"
            '
            'barItem42
            '
            Me.barItem42.CategoryIndex = 0
            Me.barItem42.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem42.ID = "Task"
            Me.barItem42.ImageIndex = 10
            Me.barItem42.Text = "Task"
            '
            'barItem43
            '
            Me.barItem43.CategoryIndex = 0
            Me.barItem43.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem43.ID = "Journal Entry"
            Me.barItem43.ImageIndex = 13
            Me.barItem43.Text = "Journal Entry"
            '
            'barItem44
            '
            Me.barItem44.CategoryIndex = 0
            Me.barItem44.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem44.ID = "Note"
            Me.barItem44.ImageIndex = 11
            Me.barItem44.Text = "Note"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 0
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&Open"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem46, Me.barItem45})
            Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem2.Text = "&Open"
            '
            'barItem46
            '
            Me.barItem46.CategoryIndex = 0
            Me.barItem46.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem46.ID = "Outlook Data File"
            Me.barItem46.Text = "Outlook Data File"
            '
            'barItem45
            '
            Me.barItem45.CategoryIndex = 0
            Me.barItem45.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem45.ID = "Selected Items"
            Me.barItem45.Text = "Selected Items"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "Clos&e All Items"
            Me.barItem1.Text = "Clos&e All Items"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "Save &As..."
            Me.barItem2.Text = "Save &As..."
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 0
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "Page Set&up"
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem52, Me.barItem53})
            Me.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem3.Text = "Page Set&up"
            '
            'barItem52
            '
            Me.barItem52.CategoryIndex = 0
            Me.barItem52.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem52.ID = "Page Style"
            Me.barItem52.Text = "Page Style"
            '
            'barItem53
            '
            Me.barItem53.CategoryIndex = 0
            Me.barItem53.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem53.ID = "Memo Style"
            Me.barItem53.Text = "Memo Style"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "Print Pre&view"
            Me.barItem3.ImageIndex = 30
            Me.barItem3.Text = "Print Pre&view"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "&Print"
            Me.barItem4.ImageIndex = 29
            Me.barItem4.Text = "&Print"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 0
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "E&xit"
            Me.barItem5.Text = "E&xit"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 2
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "&Edit"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem6, Me.barItem7, Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem15, Me.barItem16, Me.barItem17, Me.barItem18})
            Me.parentBarItem4.SeparatorIndices.AddRange(New Integer() {1, 5, 6, 10, 12})
            Me.parentBarItem4.Text = "&Edit"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 2
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "&Undo"
            Me.barItem6.ImageIndex = 35
            Me.barItem6.Text = "&Undo"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 2
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "Cu&t"
            Me.barItem7.ImageIndex = 19
            Me.barItem7.Text = "Cu&t"
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 2
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem8.ID = "&Copy"
            Me.barItem8.ImageIndex = 17
            Me.barItem8.Text = "&Copy"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 2
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem9.ID = "Office Clip&board"
            Me.barItem9.ImageIndex = 16
            Me.barItem9.Text = "Office Clip&board"
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 2
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem10.ID = "&Paste"
            Me.barItem10.ImageIndex = 26
            Me.barItem10.Text = "&Paste"
            '
            'barItem11
            '
            Me.barItem11.CategoryIndex = 2
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem11.ID = "Select A&ll"
            Me.barItem11.Text = "Select A&ll"
            '
            'barItem12
            '
            Me.barItem12.CategoryIndex = 2
            Me.barItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem12.ID = "&Delete"
            Me.barItem12.ImageIndex = 20
            Me.barItem12.Text = "&Delete"
            '
            'barItem13
            '
            Me.barItem13.CategoryIndex = 2
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem13.ID = "&Undelete"
            Me.barItem13.Text = "&Undelete"
            '
            'barItem14
            '
            Me.barItem14.CategoryIndex = 2
            Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem14.ID = "&Move To Folder"
            Me.barItem14.ImageIndex = 24
            Me.barItem14.Text = "&Move To Folder"
            '
            'barItem15
            '
            Me.barItem15.CategoryIndex = 2
            Me.barItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem15.ID = "Cop&y To Folder"
            Me.barItem15.Text = "Cop&y To Folder"
            '
            'barItem16
            '
            Me.barItem16.CategoryIndex = 2
            Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem16.ID = "Mark as Read"
            Me.barItem16.ImageIndex = 14
            Me.barItem16.Text = "Mark as Read"
            '
            'barItem17
            '
            Me.barItem17.CategoryIndex = 2
            Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem17.ID = "Mark as Unread"
            Me.barItem17.ImageIndex = 36
            Me.barItem17.Text = "Mark as Unread"
            '
            'barItem18
            '
            Me.barItem18.CategoryIndex = 2
            Me.barItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem18.ID = "Categor&ies..."
            Me.barItem18.Text = "Categor&ies..."
            '
            'parentBarItem5
            '
            Me.parentBarItem5.CategoryIndex = 1
            Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem5.ID = "&View"
            Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem11, Me.barItem19, Me.parentBarItem12, Me.barItem20, Me.parentBarItem13, Me.barItem21, Me.parentBarItem14, Me.barItem22})
            Me.parentBarItem5.SeparatorIndices.AddRange(New Integer() {1, 5, 6})
            Me.parentBarItem5.Text = "&View"
            '
            'parentBarItem11
            '
            Me.parentBarItem11.CategoryIndex = 1
            Me.parentBarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem11.ID = "&Arrange By"
            Me.parentBarItem11.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem41})
            Me.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem11.Text = "&Arrange By"
            '
            'barItem41
            '
            Me.barItem41.CategoryIndex = 1
            Me.barItem41.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem41.ID = "Date"
            Me.barItem41.Text = "Date"
            '
            'barItem19
            '
            Me.barItem19.CategoryIndex = 1
            Me.barItem19.Checked = True
            Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem19.ID = "Na&vigation Pane"
            Me.barItem19.Text = "Na&vigation Pane"
            '
            'parentBarItem12
            '
            Me.parentBarItem12.CategoryIndex = 1
            Me.parentBarItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem12.ID = "Reading Pa&ne"
            Me.parentBarItem12.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem47, Me.barItem48, Me.barItem63})
            Me.parentBarItem12.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem12.Text = "Reading Pa&ne"
            '
            'barItem47
            '
            Me.barItem47.CategoryIndex = 1
            Me.barItem47.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem47.ID = "Right"
            Me.barItem47.ImageIndex = 46
            Me.barItem47.Text = "Right"
            '
            'barItem48
            '
            Me.barItem48.CategoryIndex = 1
            Me.barItem48.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem48.ID = "Bottom"
            Me.barItem48.ImageIndex = 44
            Me.barItem48.Text = "Bottom"
            '
            'barItem63
            '
            Me.barItem63.CategoryIndex = 1
            Me.barItem63.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem63.ID = "&Off"
            Me.barItem63.ImageIndex = 45
            Me.barItem63.Text = "&Off"
            '
            'barItem20
            '
            Me.barItem20.CategoryIndex = 1
            Me.barItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem20.ID = "Auto&Preview"
            Me.barItem20.ImageIndex = 27
            Me.barItem20.Text = "Auto&Preview"
            '
            'parentBarItem13
            '
            Me.parentBarItem13.CategoryIndex = 1
            Me.parentBarItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem13.ID = "Expand/Collapse Groups"
            Me.parentBarItem13.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem49, Me.barItem50, Me.barItem68})
            Me.parentBarItem13.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem13.Text = "Expand/Collapse Groups"
            '
            'barItem49
            '
            Me.barItem49.CategoryIndex = 1
            Me.barItem49.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem49.ID = "Expand All Groups"
            Me.barItem49.Text = "Expand All Groups"
            '
            'barItem50
            '
            Me.barItem50.CategoryIndex = 1
            Me.barItem50.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem50.ID = "Collapse All Groups"
            Me.barItem50.Text = "Collapse All Groups"
            '
            'barItem68
            '
            Me.barItem68.CategoryIndex = 1
            Me.barItem68.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem68.ID = "Expand This Group"
            Me.barItem68.Text = "Expand This Group"
            '
            'barItem21
            '
            Me.barItem21.CategoryIndex = 1
            Me.barItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem21.ID = "&Refresh"
            Me.barItem21.Text = "&Refresh"
            '
            'parentBarItem14
            '
            Me.parentBarItem14.CategoryIndex = 1
            Me.parentBarItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem14.ID = "&Toolbars"
            Me.parentBarItem14.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem51})
            Me.parentBarItem14.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem14.Text = "&Toolbars"
            '
            'barItem51
            '
            Me.barItem51.CategoryIndex = 1
            Me.barItem51.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem51.ID = "Standard"
            Me.barItem51.Text = "Standard"
            '
            'barItem22
            '
            Me.barItem22.CategoryIndex = 1
            Me.barItem22.Checked = True
            Me.barItem22.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem22.ID = "&Status Bar"
            Me.barItem22.Text = "&Status Bar"
            '
            'parentBarItem6
            '
            Me.parentBarItem6.CategoryIndex = 3
            Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem6.ID = "&Go"
            Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.mailBarItem, Me.calendarBarItem, Me.contactsBarItem, Me.tasksBarItem, Me.notesBarItem, Me.folderlistBarItem, Me.journalBarItem, Me.barItem31})
            Me.parentBarItem6.SeparatorIndices.AddRange(New Integer() {5, 7})
            Me.parentBarItem6.Text = "&Go"
            '
            'mailBarItem
            '
            Me.mailBarItem.CategoryIndex = 3
            Me.mailBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mailBarItem.ID = "&Mail"
            Me.mailBarItem.ImageIndex = 14
            Me.mailBarItem.Text = "&Mail"
            '
            'calendarBarItem
            '
            Me.calendarBarItem.CategoryIndex = 3
            Me.calendarBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.calendarBarItem.ID = "&Calendar"
            Me.calendarBarItem.ImageIndex = 12
            Me.calendarBarItem.Text = "&Calendar"
            '
            'contactsBarItem
            '
            Me.contactsBarItem.CategoryIndex = 3
            Me.contactsBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.contactsBarItem.ID = "Cont&acts"
            Me.contactsBarItem.ImageIndex = 9
            Me.contactsBarItem.Text = "Cont&acts"
            '
            'tasksBarItem
            '
            Me.tasksBarItem.CategoryIndex = 3
            Me.tasksBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tasksBarItem.ID = "&Tasks"
            Me.tasksBarItem.ImageIndex = 10
            Me.tasksBarItem.Text = "&Tasks"
            '
            'notesBarItem
            '
            Me.notesBarItem.CategoryIndex = 3
            Me.notesBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.notesBarItem.ID = "&Notes"
            Me.notesBarItem.ImageIndex = 11
            Me.notesBarItem.Text = "&Notes"
            '
            'folderlistBarItem
            '
            Me.folderlistBarItem.CategoryIndex = 3
            Me.folderlistBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.folderlistBarItem.ID = "Folder &List"
            Me.folderlistBarItem.ImageIndex = 3
            Me.folderlistBarItem.Text = "Folder &List"
            '
            'journalBarItem
            '
            Me.journalBarItem.CategoryIndex = 3
            Me.journalBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.journalBarItem.ID = "&Journal"
            Me.journalBarItem.ImageIndex = 13
            Me.journalBarItem.Text = "&Journal"
            '
            'barItem31
            '
            Me.barItem31.CategoryIndex = 3
            Me.barItem31.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem31.ID = "&Folder..."
            Me.barItem31.Text = "&Folder..."
            '
            'parentBarItem8
            '
            Me.parentBarItem8.CategoryIndex = 5
            Me.parentBarItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem8.ID = "&Actions"
            Me.parentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem32, Me.parentBarItem7, Me.parentBarItem15, Me.parentBarItem16, Me.barItem33, Me.barItem34, Me.barItem35})
            Me.parentBarItem8.SeparatorIndices.AddRange(New Integer() {2, 3, 4})
            Me.parentBarItem8.Text = "&Actions"
            '
            'barItem32
            '
            Me.barItem32.CategoryIndex = 5
            Me.barItem32.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem32.ID = "&New Mail Message"
            Me.barItem32.ImageIndex = 25
            Me.barItem32.Text = "&New Mail Message"
            '
            'parentBarItem7
            '
            Me.parentBarItem7.CategoryIndex = 5
            Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem7.ID = "New Mail &Message Using"
            Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem54, Me.barItem55, Me.barItem56})
            Me.parentBarItem7.Text = "New Mail &Message Using"
            '
            'barItem54
            '
            Me.barItem54.CategoryIndex = 5
            Me.barItem54.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem54.ID = "Plain Text"
            Me.barItem54.Text = "Plain Text"
            '
            'barItem55
            '
            Me.barItem55.CategoryIndex = 5
            Me.barItem55.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem55.ID = "Rich Text"
            Me.barItem55.Text = "Rich Text"
            '
            'barItem56
            '
            Me.barItem56.CategoryIndex = 5
            Me.barItem56.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem56.ID = "HTML (No Stationery)"
            Me.barItem56.Text = "HTML (No Stationery)"
            '
            'parentBarItem15
            '
            Me.parentBarItem15.CategoryIndex = 5
            Me.parentBarItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem15.ID = "Follow &Up"
            Me.parentBarItem15.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem57, Me.barItem58, Me.barItem59})
            Me.parentBarItem15.Text = "Follow &Up"
            '
            'barItem57
            '
            Me.barItem57.CategoryIndex = 5
            Me.barItem57.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem57.ID = "Red Flag"
            Me.barItem57.Text = "Red Flag"
            '
            'barItem58
            '
            Me.barItem58.CategoryIndex = 5
            Me.barItem58.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem58.ID = "Blue Flag"
            Me.barItem58.Text = "Blue Flag"
            '
            'barItem59
            '
            Me.barItem59.CategoryIndex = 5
            Me.barItem59.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem59.ID = "Yellow Flag"
            Me.barItem59.Text = "Yellow Flag"
            '
            'parentBarItem16
            '
            Me.parentBarItem16.CategoryIndex = 5
            Me.parentBarItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem16.ID = "&Junk E-mail"
            Me.parentBarItem16.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem60})
            Me.parentBarItem16.Text = "&Junk E-mail"
            '
            'barItem60
            '
            Me.barItem60.CategoryIndex = 5
            Me.barItem60.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem60.ID = "Junk E-mail Options"
            Me.barItem60.Text = "Junk E-mail Options"
            '
            'barItem33
            '
            Me.barItem33.CategoryIndex = 5
            Me.barItem33.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem33.ID = "&Reply"
            Me.barItem33.ImageIndex = 31
            Me.barItem33.Text = "&Reply"
            '
            'barItem34
            '
            Me.barItem34.CategoryIndex = 5
            Me.barItem34.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem34.ID = "Reply to A&ll"
            Me.barItem34.ImageIndex = 32
            Me.barItem34.Text = "Reply to A&ll"
            '
            'barItem35
            '
            Me.barItem35.CategoryIndex = 5
            Me.barItem35.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem35.ID = "For&ward"
            Me.barItem35.ImageIndex = 22
            Me.barItem35.Text = "For&ward"
            '
            'parentBarItem9
            '
            Me.parentBarItem9.CategoryIndex = 6
            Me.parentBarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem9.ID = "&Help"
            Me.parentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem23, Me.barItem36})
            Me.parentBarItem9.Text = "&Help"
            '
            'barItem23
            '
            Me.barItem23.CategoryIndex = 6
            Me.barItem23.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem23.ID = "OutlookDemo Help"
            Me.barItem23.ImageIndex = 23
            Me.barItem23.Text = "OutlookDemo Help"
            '
            'barItem36
            '
            Me.barItem36.CategoryIndex = 6
            Me.barItem36.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem36.ID = "&About OutlookDemo..."
            Me.barItem36.ImageIndex = 37
            Me.barItem36.Text = "&About Syncfusion..."
            '
            'parentBarItem17
            '
            Me.parentBarItem17.CategoryIndex = 10
            Me.parentBarItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem17.ID = "Office Theme Styles"
            Me.parentBarItem17.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.blueStyleBarItem, Me.blackStyleBarItem, Me.silverStyleBarItem})
            Me.parentBarItem17.Text = "&Office Theme Styles"
            '
            'blueStyleBarItem
            '
            Me.blueStyleBarItem.CategoryIndex = 10
            Me.blueStyleBarItem.Checked = True
            Me.blueStyleBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.blueStyleBarItem.ID = "Blue"
            Me.blueStyleBarItem.Text = "Blue"
            '
            'blackStyleBarItem
            '
            Me.blackStyleBarItem.CategoryIndex = 10
            Me.blackStyleBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.blackStyleBarItem.ID = "Black"
            Me.blackStyleBarItem.Text = "Black"
            '
            'silverStyleBarItem
            '
            Me.silverStyleBarItem.CategoryIndex = 10
            Me.silverStyleBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.silverStyleBarItem.ID = "Silver"
            Me.silverStyleBarItem.Text = "Silver"
            '
            'bar2
            '
            Me.bar2.BarName = "Standard"
            Me.bar2.Caption = "Standard"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem10, Me.barItem4, Me.barItem14, Me.barItem33, Me.barItem34, Me.barItem35, Me.barItem12, Me.barItem24, Me.barItem25, Me.barItem30, Me.barItem23})
            Me.bar2.Manager = Me.mainFrameBarManager1
            Me.bar2.SeparatorIndices.AddRange(New Integer() {1, 3, 6, 7, 9})
            '
            'barItem24
            '
            Me.barItem24.CategoryIndex = 4
            Me.barItem24.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem24.ID = "Find"
            Me.barItem24.ImageIndex = 47
            Me.barItem24.Text = "Find"
            '
            'barItem25
            '
            Me.barItem25.CategoryIndex = 4
            Me.barItem25.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem25.ID = "Rules and Alerts"
            Me.barItem25.ImageIndex = 33
            Me.barItem25.Text = "Rules and Alerts"
            '
            'barItem30
            '
            Me.barItem30.CategoryIndex = 4
            Me.barItem30.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem30.ID = "Address Book"
            Me.barItem30.ImageIndex = 15
            Me.barItem30.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem30.Text = "Address Book"
            '
            'bar3
            '
            Me.bar3.BarName = "Advanced"
            Me.bar3.Caption = "Advanced"
            Me.bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem62, Me.barItem_AutoPreview})
            Me.bar3.Manager = Me.mainFrameBarManager1
            '
            'barItem62
            '
            Me.barItem62.CategoryIndex = 8
            Me.barItem62.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem62.ID = "GroupByBox"
            Me.barItem62.ImageIndex = 39
            Me.barItem62.Text = "GroupByBox"
            Me.barItem62.Tooltip = "GroupByBox"
            '
            'barItem_AutoPreview
            '
            Me.barItem_AutoPreview.CategoryIndex = 8
            Me.barItem_AutoPreview.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem_AutoPreview.ID = "AutoPreview"
            Me.barItem_AutoPreview.ImageIndex = 27
            Me.barItem_AutoPreview.Text = "AutoPreview"
            '
            'barItem26
            '
            Me.barItem26.CategoryIndex = 4
            Me.barItem26.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem26.ID = "E-mail Accounts"
            Me.barItem26.Text = "E-mail Accounts"
            '
            'barItem27
            '
            Me.barItem27.CategoryIndex = 4
            Me.barItem27.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem27.ID = "Customize"
            Me.barItem27.Text = "Customize"
            '
            'barItem28
            '
            Me.barItem28.CategoryIndex = 4
            Me.barItem28.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem28.ID = "Options"
            Me.barItem28.Text = "Options"
            '
            'barItem64
            '
            Me.barItem64.CategoryIndex = 9
            Me.barItem64.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem64.ID = "Day"
            Me.barItem64.ImageIndex = 40
            Me.barItem64.Text = "Day"
            '
            'barItem65
            '
            Me.barItem65.CategoryIndex = 9
            Me.barItem65.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem65.ID = "WorkWeek"
            Me.barItem65.ImageIndex = 41
            Me.barItem65.Text = "WorkWeek"
            '
            'barItem66
            '
            Me.barItem66.CategoryIndex = 9
            Me.barItem66.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem66.ID = "Week"
            Me.barItem66.ImageIndex = 42
            Me.barItem66.Text = "Week"
            '
            'barItem67
            '
            Me.barItem67.CategoryIndex = 9
            Me.barItem67.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem67.ID = "Month"
            Me.barItem67.ImageIndex = 43
            Me.barItem67.Text = "Month"
            '
            'splitter1
            '
            Me.splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.splitter1.Location = New System.Drawing.Point(0, 50)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(5, 786)
            Me.splitter1.TabIndex = 5
            Me.splitter1.TabStop = False
            '
            'clientPanel
            '
            Me.clientPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.clientPanel.Controls.Add(Me.panel16)
            Me.clientPanel.Controls.Add(Me.splitter2)
            Me.clientPanel.Controls.Add(Me.gridContainerPanel)
            Me.clientPanel.Controls.Add(Me.scheduleContainerPanel)
            Me.clientPanel.Controls.Add(Me.contactsGridPanel)
            Me.clientPanel.Controls.Add(Me.gradientPanel1)
            Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.clientPanel.Location = New System.Drawing.Point(0, 0)
            Me.clientPanel.Name = "clientPanel"
            Me.clientPanel.Size = New System.Drawing.Size(822, 786)
            Me.clientPanel.TabIndex = 4
            '
            'panel16
            '
            Me.panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel16.Controls.Add(Me.Display)
            Me.panel16.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel16.Location = New System.Drawing.Point(0, 357)
            Me.panel16.Name = "panel16"
            Me.panel16.Size = New System.Drawing.Size(822, 429)
            Me.panel16.TabIndex = 4
            '
            'Display
            '
            Me.Display.BackColor = System.Drawing.SystemColors.Window
            Me.Display.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Display.Location = New System.Drawing.Point(0, 0)
            Me.Display.Name = "Display"
            Me.Display.ReadOnly = True
            Me.Display.Size = New System.Drawing.Size(820, 427)
            Me.Display.TabIndex = 0
            Me.Display.Text = ""
            '
            'splitter2
            '
            Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitter2.Location = New System.Drawing.Point(0, 353)
            Me.splitter2.Name = "splitter2"
            Me.splitter2.Size = New System.Drawing.Size(822, 4)
            Me.splitter2.TabIndex = 3
            Me.splitter2.TabStop = False
            '
            'gridContainerPanel
            '
            Me.gridContainerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridContainerPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.gridContainerPanel.Location = New System.Drawing.Point(0, 28)
            Me.gridContainerPanel.Name = "gridContainerPanel"
            Me.gridContainerPanel.Size = New System.Drawing.Size(822, 325)
            Me.gridContainerPanel.TabIndex = 2
            '
            'scheduleContainerPanel
            '
            Me.scheduleContainerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.scheduleContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.scheduleContainerPanel.Location = New System.Drawing.Point(0, 28)
            Me.scheduleContainerPanel.Name = "scheduleContainerPanel"
            Me.scheduleContainerPanel.Size = New System.Drawing.Size(822, 758)
            Me.scheduleContainerPanel.TabIndex = 2
            '
            'contactsGridPanel
            '
            Me.contactsGridPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.contactsGridPanel.Location = New System.Drawing.Point(0, 28)
            Me.contactsGridPanel.Name = "contactsGridPanel"
            Me.contactsGridPanel.Size = New System.Drawing.Size(818, 767)
            Me.contactsGridPanel.TabIndex = 5
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.MidnightBlue
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.clientPanelLabel1)
            Me.gradientPanel1.Controls.Add(Me.clientPanelImage)
            Me.gradientPanel1.Controls.Add(Me.clientPanelLabel2)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(822, 28)
            Me.gradientPanel1.TabIndex = 1
            '
            'clientPanelLabel1
            '
            Me.clientPanelLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.clientPanelLabel1.BackColor = System.Drawing.Color.Transparent
            Me.clientPanelLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.clientPanelLabel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.clientPanelLabel1.Location = New System.Drawing.Point(38, 1)
            Me.clientPanelLabel1.Name = "clientPanelLabel1"
            Me.clientPanelLabel1.Size = New System.Drawing.Size(687, 28)
            Me.clientPanelLabel1.TabIndex = 5
            Me.clientPanelLabel1.Text = "Inbox"
            Me.clientPanelLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'clientPanelImage
            '
            Me.clientPanelImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.clientPanelImage.BackColor = System.Drawing.Color.Transparent
            Me.clientPanelImage.ImageIndex = 2
            Me.clientPanelImage.ImageList = Me.smallImageList
            Me.clientPanelImage.Location = New System.Drawing.Point(66, 0)
            Me.clientPanelImage.Name = "clientPanelImage"
            Me.clientPanelImage.Size = New System.Drawing.Size(32, 28)
            Me.clientPanelImage.TabIndex = 3
            '
            'clientPanelLabel2
            '
            Me.clientPanelLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.clientPanelLabel2.BackColor = System.Drawing.Color.Transparent
            Me.clientPanelLabel2.ForeColor = System.Drawing.Color.White
            Me.clientPanelLabel2.Location = New System.Drawing.Point(731, 0)
            Me.clientPanelLabel2.Name = "clientPanelLabel2"
            Me.clientPanelLabel2.Size = New System.Drawing.Size(88, 28)
            Me.clientPanelLabel2.TabIndex = 4
            Me.clientPanelLabel2.Text = "label12"
            Me.clientPanelLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'toolbarListBarItem1
            '
            Me.toolbarListBarItem1.CategoryIndex = 8
            Me.toolbarListBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolbarListBarItem1.ID = "GroupByBox"
            Me.toolbarListBarItem1.Text = "GroupByBox"
            '
            'barItem61
            '
            Me.barItem61.CategoryIndex = 8
            Me.barItem61.CustomTextFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem61.ID = "sad"
            Me.barItem61.Text = "sad"
            '
            'listBarItem1
            '
            Me.listBarItem1.CategoryIndex = 8
            Me.listBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.listBarItem1.ID = "Grou"
            Me.listBarItem1.Text = "Grou"
            '
            'textBoxBarItem1
            '
            Me.textBoxBarItem1.CategoryIndex = 8
            Me.textBoxBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxBarItem1.ID = "efrwe"
            Me.textBoxBarItem1.Text = "efrwe"
            Me.textBoxBarItem1.Value = ""
            '
            'staticBarItem1
            '
            Me.staticBarItem1.CategoryIndex = 8
            Me.staticBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.staticBarItem1.ID = "ewr"
            Me.staticBarItem1.Text = "ewr"
            '
            'statusStripEx1
            '
            Me.statusStripEx1.AllowItemReorder = True
            Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
            Me.statusStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.statusStripEx1.Location = New System.Drawing.Point(1, 816)
            Me.statusStripEx1.Name = "statusStripEx1"
            Me.statusStripEx1.Size = New System.Drawing.Size(200, 22)
            Me.statusStripEx1.TabIndex = 1003
            Me.statusStripEx1.Text = "statusStripEx1"
            '
            'toolStripStatusLabel1
            '
            Me.toolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(55, 13)
            Me.toolStripStatusLabel1.Text = "Messages"
            '
            'SplashControl1
            '
            Me.SplashControl1.AutoMode = False
            Me.SplashControl1.HideHostForm = True
            Me.SplashControl1.HostForm = Me
            Me.SplashControl1.SplashImage = CType(resources.GetObject("SplashControl1.SplashImage"), System.Drawing.Image)
            '
            'ScrollersFrame1
            '
            Me.ScrollersFrame1.AttachedTo = Me.treeView1
            Me.ScrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.[Auto]
            Me.ScrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007
            '
            'SplitContainerAdv1
            '
            Me.SplitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainerAdv1.Location = New System.Drawing.Point(5, 50)
            Me.SplitContainerAdv1.Name = "SplitContainerAdv1"
            '
            'SplitContainerAdv1.Panel1
            '
            Me.SplitContainerAdv1.Panel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.SplitContainerAdv1.Panel1.Controls.Add(Me.groupBar1)
            '
            'SplitContainerAdv1.Panel2
            '
            Me.SplitContainerAdv1.Panel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.SplitContainerAdv1.Panel2.Controls.Add(Me.clientPanel)
            Me.SplitContainerAdv1.Size = New System.Drawing.Size(1017, 786)
            Me.SplitContainerAdv1.SplitterDistance = 188
            Me.SplitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue
            Me.SplitContainerAdv1.TabIndex = 1004
            Me.SplitContainerAdv1.Text = "SplitContainerAdv1"
            '
            'Form1
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(1022, 836)
            Me.Controls.Add(Me.SplitContainerAdv1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.statusStripEx1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Outlook Demo"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBar1.ResumeLayout(False)
            Me.mailPanel.ResumeLayout(False)
            CType(Me.mailTaskBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.mailTaskBar.ResumeLayout(False)
            Me.mailTaskBarBox.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.journalPanel.ResumeLayout(False)
            CType(Me.gradientPanel10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel10.ResumeLayout(False)
            Me.gradientPanel10.PerformLayout()
            CType(Me.xpTaskBar6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBar6.ResumeLayout(False)
            Me.currentViewTaskBarBox3.ResumeLayout(False)
            Me.panel14.ResumeLayout(False)
            Me.panel14.PerformLayout()
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
            Me.contactsPanel.ResumeLayout(False)
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel5.ResumeLayout(False)
            Me.gradientPanel5.PerformLayout()
            CType(Me.xpTaskBar2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBar2.ResumeLayout(False)
            Me.currentViewTaskBarBox.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
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
            Me.folderlistPanel.ResumeLayout(False)
            CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel8.ResumeLayout(False)
            Me.panel6.ResumeLayout(False)
            CType(Me.xpTaskBar5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBar5.ResumeLayout(False)
            Me.allFoldersTaskBarBox.ResumeLayout(False)
            CType(Me.gradientPanel9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel9.ResumeLayout(False)
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.clientPanel.ResumeLayout(False)
            Me.panel16.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.statusStripEx1.ResumeLayout(False)
            Me.SplitContainerAdv1.Panel1.ResumeLayout(False)
            Me.SplitContainerAdv1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainerAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerAdv1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Theme Changes"

        Private themeStyle As String = "Blue"
        Public Shared r As Integer = 189, g As Integer = 215, b As Integer = 252, r1 As Integer = 220, g1 As Integer = 235, b1 As Integer = 254
        Private Sub OnThemeChange(ByVal sender As Object, ByVal e As EventArgs) Handles blueStyleBarItem.Click, blackStyleBarItem.Click, silverStyleBarItem.Click
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            SetTheme(item.ID)
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
                    Me.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Blue
                    Me.xpTaskBar2.Office2007ColorScheme = Office2007Theme.Blue
                    Me.xpTaskBar3.Office2007ColorScheme = Office2007Theme.Blue
                    Me.xpTaskBar4.Office2007ColorScheme = Office2007Theme.Blue
                    Me.xpTaskBar5.Office2007ColorScheme = Office2007Theme.Blue
                    Me.xpTaskBar6.Office2007ColorScheme = Office2007Theme.Blue
                    Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
                    Me.mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue
                    Me.ScrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Blue
                    Me.blueStyleBarItem.Checked = True
                    Me.blackStyleBarItem.Checked = False
                    Me.silverStyleBarItem.Checked = False
                    Me.ColorScheme = Office2007Theme.Blue
                    SetForeGroundTheme(Color.FromArgb(21, 66, 139))
                    Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Blue
                    Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Blue
                    Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Blue
                    Me.mailTaskBar.Office2007ColorScheme = Office2007Theme.Blue
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
                    Me.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Black
                    Me.xpTaskBar2.Office2007ColorScheme = Office2007Theme.Black
                    Me.xpTaskBar3.Office2007ColorScheme = Office2007Theme.Black
                    Me.xpTaskBar4.Office2007ColorScheme = Office2007Theme.Black
                    Me.xpTaskBar5.Office2007ColorScheme = Office2007Theme.Black
                    Me.xpTaskBar6.Office2007ColorScheme = Office2007Theme.Black
                    Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
                    Me.mainFrameBarManager1.Office2007Theme = Office2007Theme.Black
                    Me.ScrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Black
                    Me.blueStyleBarItem.Checked = False
                    Me.blackStyleBarItem.Checked = True
                    Me.silverStyleBarItem.Checked = False
                    Me.ColorScheme = Office2007Theme.Black
                    SetForeGroundTheme(Color.White)
                    Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Black
                    Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Black
                    Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Black
                    Me.mailTaskBar.Office2007ColorScheme = Office2007Theme.Black
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
                    Me.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Silver
                    Me.xpTaskBar2.Office2007ColorScheme = Office2007Theme.Silver
                    Me.xpTaskBar3.Office2007ColorScheme = Office2007Theme.Silver
                    Me.xpTaskBar4.Office2007ColorScheme = Office2007Theme.Silver
                    Me.xpTaskBar5.Office2007ColorScheme = Office2007Theme.Silver
                    Me.xpTaskBar6.Office2007ColorScheme = Office2007Theme.Silver
                    Me.mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver
                    Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
                    Me.blueStyleBarItem.Checked = False
                    Me.blackStyleBarItem.Checked = False
                    Me.silverStyleBarItem.Checked = True
                    Me.ScrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Silver
                    Me.ColorScheme = Office2007Theme.Silver
                    SetForeGroundTheme(Color.Black)
                    Me.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Silver
                    Me.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Silver
                    Me.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Silver
                    Me.mailTaskBar.Office2007ColorScheme = Office2007Theme.Silver
            End Select
            Me.Refresh()
        End Sub

        Private Sub SetBackGroundTheme()
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
            Me.gridContainerPanel.BackColor = Color.FromArgb(r, g, b)

            Me.gridGroupingPanel.BackColor = Color.FromArgb(r, g, b)
            Me.splitter1.BackColor = Color.FromArgb(r, g, b)
            Me.splitter2.BackColor = Color.FromArgb(r, g, b)
            Me.panel16.BackColor = Color.FromArgb(r1, g1, b1)
            Me.panel3.BackColor = Color.FromArgb(r, g, b)
            Me.panel4.BackColor = Color.FromArgb(r, g, b)
            Me.panel5.BackColor = Color.FromArgb(r, g, b)
            Me.calForm.BackColor = Color.FromArgb(r, g, b)
            Me.calForm.scheduleControl1.BackColor = Color.FromArgb(r, g, b)
            Me.calForm.scheduleControl1.Appearance.SplitterBackColor = Color.FromArgb(r, g, b)
            Me.calForm.scheduleControl1.Appearance.MarkColumnColor = Color.FromArgb(r, g, b)
            Me.calForm.scheduleControl1.Appearance.NavigationCalendarHeaderColor = Color.FromArgb(r, g, b)
            Me.calForm.scheduleControl1.NavigationPanel.BackColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Appearance.MonthWeekHeaderBackColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Appearance.CaptionBackColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Appearance.AllDayBackColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Calendar.BackColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Appearance.TimeBackColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Appearance.PrimeTimeCellColor = Color.FromArgb(r1, g1, b1)
            Me.calForm.scheduleControl1.Appearance.NonPrimeTimeCellColor = Color.FromArgb(r1, g1, b1)
        End Sub

        Private Sub SetForeGroundTheme(ByVal color As Color)
            Me.clientPanelLabel1.ForeColor = color
            Me.clientPanelLabel2.ForeColor = color
            Me.mailTaskBarBox.HeaderForeColor = color
            Me.favouritesTaskBarBox.HeaderForeColor = color
            Me.myCalendarsTaskBarBox1.HeaderForeColor = color
            Me.myContactsTaskBarBox.HeaderForeColor = color
            Me.myJournalTaskBarBox.HeaderForeColor = color
            Me.mytasksTaskBarBox.HeaderForeColor = color
            Me.currentViewTaskBarBox.HeaderForeColor = color
            Me.currentViewTaskBarBox1.HeaderForeColor = color
            Me.currentViewTaskBarBox2.HeaderForeColor = color
            Me.currentViewTaskBarBox3.HeaderForeColor = color
            Me.calForm.scheduleControl1.Appearance.TimeTextColor = color
            Me.calForm.scheduleControl1.Appearance.TextColor = color
            Me.calForm.radFullWeek.ForeColor = color
            Me.calForm.radWorkWeek.ForeColor = color
        End Sub

#End Region

#Region "Event Hanlders"
        Private Sub OnNewMailMessageClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem29.Click
            Dim oTemp As NewMailForm = New NewMailForm(Me, Me.themeStyle)
            oTemp.Show()
        End Sub

        Private Sub TaskBarBox_ProvideHeaderBackgroundBrush(ByVal sender As Object, ByVal args As ProvideBrushEventArgs) Handles allFoldersTaskBarBox.ProvideHeaderBackgroundBrush
            Dim blend As System.Drawing.Drawing2D.Blend = New System.Drawing.Drawing2D.Blend()
            blend.Factors = New Single() {0.0F, 0.25F, 0.5F, 1.0F}
            blend.Positions = New Single() {0.0F, 0.25F, 0.5F, 1.0F, 1.5F}
            ' Estimate the GroupBarItem bounds

            Dim rcgroupbaritem As Rectangle = args.Bounds
            ' Create and initialize the LinearGradientBrush
            Dim lgbrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(rcgroupbaritem, Color.White, Color.FromArgb(r, g, b), 90, True)
            lgbrush.Blend = blend
            args.Brush = lgbrush
        End Sub

        Private Sub mailTaskBar_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.mailTaskBarBox.PreferredChildPanelHeight = Me.mailTaskBar.Height - Me.favouritesTaskBarBox.Height
        End Sub

        Private Sub groupBar1_NavigationPaneDropDownClick(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventArgs) Handles groupBar1.NavigationPaneDropDownClick
            ' Add the 'Navigation Pane Options' and 'Add and Remove Buttons' menu commands to the GroupBar's dropdown menu
            args.ContextMenuProvider.AddContextMenuItem(String.Empty, "Navigation Pane Options...", New EventHandler(AddressOf Me.NavPaneOptions_Click))
            Dim addremove As String = "Add or Remove Buttons"
            ' Create and add a BarItem for each GroupBarItem in the GroupBar control
            For Each item As GroupBarItem In Me.groupBar1.GroupBarItems
                args.ContextMenuProvider.AddContextMenuItem(addremove, item.Text, New EventHandler(AddressOf Me.AddRemoveButtons_Click))
                args.ContextMenuProvider.SetContextMenuItemChecked(item.Text, item.Visible)
                args.ContextMenuProvider.SetContextMenuItemImage(item.Text, Me.smallImageList, CInt(Me.htLabelToImageIndex(item.Text)))
            Next item
        End Sub

        Private Sub NavPaneOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim optform As OutlookDemo.OptionsForm = New OutlookDemo.OptionsForm(Me)
            optform.ShowDialog(Me)
        End Sub

        Private Sub AddRemoveButtons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            ' Hide or show the GroupBarItem that was clicked on the PopupMenu
            Dim cntxtitem As Syncfusion.Windows.Forms.ContextMenuItem = CType(IIf(TypeOf sender Is ContextMenuItem, sender, Nothing), ContextMenuItem)
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
            Me.clientPanelImage.ImageIndex = CInt(Me.htLabelToImageIndex(selitem.Text))
        End Sub

        Private Sub barItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem5.Click
            Me.Close()
        End Sub

        Private Sub barItem36_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem36.Click
            Dim abtForm As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            abtForm.ShowDialog()
        End Sub

        Private Sub mailBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mailBarItem.Click
            Me.SetGroupBarSelectedItem("Mail")
        End Sub

        Private Sub calendarBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calendarBarItem.Click
            Me.groupBar1.SelectedItem = 1
        End Sub

        Private Sub contactsBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles contactsBarItem.Click
            Me.SetGroupBarSelectedItem("Contacts")
        End Sub

        Private Sub tasksBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tasksBarItem.Click
            Me.SetGroupBarSelectedItem("Tasks")
        End Sub

        Private Sub notesBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles notesBarItem.Click
            Me.SetGroupBarSelectedItem("Notes")
        End Sub

        Private Sub folderlistBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles folderlistBarItem.Click
            Me.SetGroupBarSelectedItem("Folder List")
        End Sub

        Private Sub journalBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles journalBarItem.Click
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

        Private Sub barItem48_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem48.Click
            ' Toggle the reading pane to dock bottom
            Me.gridContainerPanel.Height = 325
            Me.gridContainerPanel.Dock = DockStyle.Top
            Me.splitter2.Dock = DockStyle.Top
            Me.panel16.Dock = DockStyle.Fill
            Me.panel16.Show()
        End Sub

        Private Sub barItem47_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem47.Click
            ' Toggle the reading pane to dock right
            'this.gridContainerPanel.Width = 490;
            Me.gridContainerPanel.Width = 700
            Me.gridContainerPanel.Dock = DockStyle.Left
            Me.splitter2.Dock = DockStyle.Left
            'this.panel16.Width=280;
            Me.panel16.Width = 310
            Me.panel16.Dock = DockStyle.Right
            Me.panel16.Show()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.gridGroupingPanel.Grid.Table.ExpandAllGroups()
        End Sub

        Private Sub Form1_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.gridGroupingPanel.Close()
        End Sub

        Private Sub barItem62_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem62.Click
            If Me.groupBar1.SelectedItem = 0 Then
                Me.gridGroupingPanel.Grid.ShowGroupDropArea = Not Me.gridGroupingPanel.Grid.ShowGroupDropArea
            ElseIf Me.groupBar1.SelectedItem = 2 Then
                Me.contactForm.Grid.ShowGroupDropArea = Not Me.contactForm.Grid.ShowGroupDropArea
            End If
        End Sub

        Private gridBottomBorderhide As GridBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        Private gridBottomBorderShow As GridBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Private Sub barItem_AutoPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_AutoPreview.Click
            Dim barItem As BarItem = CType(sender, BarItem)
            Me.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow = Not Me.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow
            barItem.Checked = Not barItem.Checked
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
        End Sub


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
                    Dim drv As DataRowView = CType(IIf(TypeOf Me.gridGroupingPanel.Grid.Table.NestedDisplayElements(row).GetData() Is DataRowView, Me.gridGroupingPanel.Grid.Table.NestedDisplayElements(row).GetData(), Nothing), DataRowView)

                    ' font table
                    ' third line
                    ' closing bracket
                    Dim rtf2 As String = "{\rtf1\ansi" & "{\fonttbl" & "\f0\fswiss Microsoft Sans Serif;} " & "\highlight0\ql\f3\f0\fs28   " & drv("Subject") & "\plain\par" & "\highlight\ql\f0\f0\fs26    " & drv("From") & "\plain\par" & "\highlight1\ql\cf0\f0\fs20 {\b     To :}" & drv("To") & "\plain\par" & Environment.NewLine & "\highlight1\ql\f0\f2\fs20 " & "\plain\par" & "\highlight1\ql\cf0\f0\fs20     " & drv("Content") & "\plain\par" & "}"

                    ' Use display to show the content..
                    If e.Reason = GridSelectionReason.MouseDown OrElse e.Reason = GridSelectionReason.ArrowKey Then
                        Display.Rtf = rtf2
                    End If
                End If
            End If
        End Sub

        Private Sub barItem20_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem20.Click
            If Me.groupBar1.SelectedItem = 0 Then
                Dim barItem As BarItem = CType(sender, BarItem)
                Me.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow = Not Me.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow
                barItem.Checked = Not barItem.Checked
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

        Private Sub barItem19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem19.Click
            Me.barItem19.Checked = Not Me.barItem19.Checked
            If Me.barItem19.Checked Then
                Me.groupBar1.Show()
            Else
                Me.groupBar1.Hide()
            End If
        End Sub

        Private Sub barItem63_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem63.Click
            Me.panel16.Hide()
            Me.gridContainerPanel.Dock = DockStyle.Fill
        End Sub

        Private Sub groupBar1_GroupBarItemSelectionChanging(ByVal sender As Object, ByVal args As GroupBarItemSelectionChangingEventArgs)
            If Me.groupBar1.GroupBarItems(args.NewSelected).Text = "Calendar" Then
                Me.gradientPanel1.Hide()
                Me.gridContainerPanel.Hide()
                Me.panel16.Hide()
                scheduleContainerPanel.Show()
                Me.calendarPanel.Controls.Add(Me.calForm.Scheduler.Calendar)
                Me.toolStripStatusLabel1.Text = Me.calForm.Scheduler.Calendar.DateValue.ToLongDateString()
                Me.barItem64.Enabled = True
                Me.barItem65.Enabled = True
                Me.barItem66.Enabled = True
                Me.barItem67.Enabled = True
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
                Me.barItem64.Enabled = False
                Me.barItem65.Enabled = False
                Me.barItem66.Enabled = False
                Me.barItem67.Enabled = False
            Else
                Me.clientPanel.BorderStyle = BorderStyle.None
                Me.scheduleContainerPanel.Hide()
                Me.gridContainerPanel.Show()
                Me.panel16.Show()
                Me.contactsGridPanel.Hide()
                Me.gradientPanel1.Show()
                Me.toolStripStatusLabel1.Text = Me.gridGroupingPanel.Grid.Table.Records.Count.ToString() & " Messages"
                Me.barItem64.Enabled = False
                Me.barItem65.Enabled = False
                Me.barItem66.Enabled = False
                Me.barItem67.Enabled = False
            End If
        End Sub

        Private Sub barItem22_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem22.Click
            Me.barItem22.Checked = Not Me.barItem22.Checked
            If (Not Me.barItem22.Checked) Then
                Me.statusStripEx1.Hide()
            Else
                Me.statusStripEx1.Show()
            End If
        End Sub

        Private Sub Table_RecordDeleted(ByVal sender As Object, ByVal e As RecordEventArgs)
            Me.toolStripStatusLabel1.Text = Me.gridGroupingPanel.Grid.Table.Records.Count.ToString() & " Messages"
        End Sub

        Private Sub barItem64_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem64.Click
            If Me.calForm.Scheduler.ScheduleType <> ScheduleViewType.Day Then
                Me.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day)
            End If
        End Sub
        Private Sub barItem65_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem65.Click
            If Me.calForm.Scheduler.ScheduleType <> ScheduleViewType.WorkWeek Then
                Me.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek)
            End If
        End Sub
        Private Sub barItem66_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem66.Click
            If Me.calForm.Scheduler.ScheduleType <> ScheduleViewType.Week Then
                Me.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week)
            End If
        End Sub
        Private Sub barItem67_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem67.Click
            If Me.calForm.Scheduler.ScheduleType <> ScheduleViewType.Month Then
                Me.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month)
            End If
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

        Private Sub barItem49_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem49.Click
            Me.gridGroupingPanel.ExpandAllGroupsBarItem.PerformClick()
        End Sub

        Private Sub barItem50_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem50.Click
            Me.gridGroupingPanel.collapseAllGroupsBarItem.PerformClick()
        End Sub

        Private Sub barItem68_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem68.Click
            Me.gridGroupingPanel.ExpandthisGroup()
        End Sub

#End Region

        Dim flag As Boolean = True
        Private Sub groupBar1_StateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupBar1.StateChanged
            If Me.groupBar1.Collapsed Then
                Me.SplitContainerAdv1.SplitterDistance = 50
                flag = False
            Else
                Me.SplitContainerAdv1.SplitterDistance = distance
                flag = True
            End If
        End Sub

        Private Sub SplitContainerAdv1_SplitterMoved(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs) Handles SplitContainerAdv1.SplitterMoved
            If Me.SplitContainerAdv1.SplitterDistance <> 50 Then
                distance = Me.SplitContainerAdv1.SplitterDistance
            End If
            If Me.SplitContainerAdv1.SplitterDistance < 55 Then
                Me.groupBar1.Collapsed = True
                Me.SplitContainerAdv1.SplitterDistance = 50
            Else
                Me.groupBar1.Collapsed = False
            End If
        End Sub

        Private Sub SplitContainerAdv1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitContainerAdv1.DoubleClick
            If flag Then
                Me.groupBar1.Collapsed = True
                Me.SplitContainerAdv1.SplitterDistance = 50
                flag = False
            Else
                Me.groupBar1.Collapsed = False
                Me.SplitContainerAdv1.SplitterDistance = distance
                flag = True
            End If
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

'INSTANT VB NOTE: The parameter visible was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal text As String, ByVal navpane As Boolean, ByVal visible_Renamed As Boolean)
			Me.strItemText = text
			Me.bInNavPane = navpane
			Me.bVisible = visible_Renamed
		End Sub
	End Class
	#End Region

End Namespace
