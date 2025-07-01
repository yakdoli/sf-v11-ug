Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.IO
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace TabbedMDI_2005
	Partial Public Class Form1
		Inherits Office2007Form
		Private aboutForm As DemoCommon.AboutForm = Nothing
		Private tabWindowsOn As Boolean = False
        Private document1Count As Integer = 0
        Private tabbedMDIMgr As Syncfusion.Windows.Forms.Tools.TabbedMDIManager


        Public Sub New()
            'Adding a TabbedMDI Manager
            Me.tabbedMDIMgr = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager()

            Me.tabbedMDIMgr.AttachedTo = Me
            Me.tabbedMDIMgr.DropDownButtonVisible = True
            Me.tabbedMDIMgr.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabbedMDIMgr.NeedUpdateHostedForm = False
            Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            AddHandler tabbedMDIMgr.BeforeDropDownPopup, AddressOf BeforePopup
            AddHandler tabbedMDIMgr.TabControlAdded, AddressOf tabbedMDIManager_TabControlAdded

            ' Trigger when right clicking on the tabs.
            AddHandler tabbedMDIMgr.ContextMenuItem.BeforePopup, AddressOf ContextMenuItem_BeforePopup
            InitializeComponent()

            comboBox1.SelectedIndex = 3

            Me.propertyGrid1.SelectedObject = CObj(Me.tabbedMDIMgr)
        End Sub

        ' Convenient way to toggle TabbedMDI mode.
        Friend Property TabbedMDIOn() As Boolean
            Get
                Return Me.tabWindowsOn
            End Get
            Set(ByVal value As Boolean)
                If Not (Me.tabWindowsOn = value) Then
                    Me.tabWindowsOn = value

                    If Me.tabWindowsOn Then
                        Me.tabbedMDIMgr.AttachToMdiContainer(Me)
                    Else
                        Me.tabbedMDIMgr.DetachFromMdiContainer(Me, False) ' false to not invoke the Cascade mode after detaching.
                    End If
                End If
            End Set
        End Property

        Friend ReadOnly Property TabbedMDIManager() As TabbedMDIManager
            Get
                Return Me.tabbedMDIMgr
            End Get
        End Property

        Private Sub SendMessageToStatusBar(ByVal text As String)
            Me.statusBarAdvPanel1.Text = text
        End Sub

        Private tabControl As TabControlAdv
        ' Triggered when a tabgroup host is created.
        Private Sub tabbedMDIManager_TabControlAdded(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs)
            tabControl = args.TabControl
            If barItem18.Checked Then
                args.TabControl.Office2007ColorScheme = Office2007Theme.Blue
            ElseIf barItem19.Checked Then
                args.TabControl.Office2007ColorScheme = Office2007Theme.Black
            ElseIf barItem20.Checked Then
                args.TabControl.Office2007ColorScheme = Office2007Theme.Silver
            End If
        End Sub

        'Add a document 
        Private Sub AddDocument(ByVal doc As Form)
            doc.MdiParent = Me
            doc.Show()
            Me.mdiListBarItem1.ChildCaptions.Add(doc.Name)
        End Sub

        Private Sub NewDocClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click
            Me.checkBox2.Checked = True
            Me.TabbedMDIManager.ShowCloseButton = True
            document1Count += 1
            Dim doc As Document1 = New Document1("Document " & document1Count.ToString())
            AddDocument(doc)
            If document1Count Mod 2 = 0 Then
                Me.TabbedMDIManager.ShowCloseButtonForForm(doc, True)
            End If

            ' To set tooltip for the tabs
            Me.tabbedMDIMgr.SetTooltip(doc, "Tooltip for " & doc.Text)
        End Sub


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Me.NewDocClick(Me, EventArgs.Empty)
            Me.NewDocClick(Me, EventArgs.Empty)
            Me.NewDocClick(Me, EventArgs.Empty)
            Me.NewDocClick(Me, EventArgs.Empty)

            ' Turn on MDI Tabbed Documents mode.
            ' Call this after loading the mdi children to restore their previous state.
            Me.TabbedMDIOn = True
            Me.tabbedMDIMgr.ContextMenuItem.Items.Add(Me.closeAllBarItem)
            Me.tabbedMDIMgr.ContextMenuItem.BeginGroupAt(closeAllBarItem)
            Me.tabbedMDIMgr.ContextMenuItem.Items.Add(Me.barItem1)

            If File.Exists("..\..\persist.xml") Then
                Dim serializer As AppStateSerializer = New AppStateSerializer(SerializeMode.XMLFile, "..\..\persist")
                Me.tabbedMDIMgr.LoadTabGroupStates(serializer)
                SendMessageToStatusBar("TabGroupStates loaded")
            End If
        End Sub

        Private Sub ToggleAlign(ByVal sender As Object, ByVal e As EventArgs) Handles barItem5.Click
            Me.tabbedMDIMgr.Horizontal = Not Me.tabbedMDIMgr.Horizontal
        End Sub

        Private Sub AppExit(ByVal sender As Object, ByVal e As EventArgs) Handles barItem2.Click
            Me.Close()
        End Sub

        Private Sub Parse(ByVal sender As Object, ByVal e As EventArgs) Handles barItem6.Click
            Dim children As String = String.Empty
            For Each form As Form In Me.tabbedMDIMgr.MdiChildren
                children &= form.Text & Constants.vbCrLf
            Next form
            MessageBox.Show(children)
        End Sub

        Private Sub Form1_MdiChildActivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MdiChildActivate
            If Me.ActiveMdiChild Is Nothing Then
                statusBarAdv1.Text = ""
            Else
                statusBarAdv1.Text = Me.ActiveMdiChild.Text
            End If
        End Sub

        Private Sub LoadState(ByVal sender As Object, ByVal e As EventArgs) Handles barItem3.Click
            Dim serializer As AppStateSerializer = New AppStateSerializer(SerializeMode.XMLFile, "..\..\persist")
            Me.tabbedMDIMgr.LoadTabGroupStates(serializer)
            SendMessageToStatusBar("TabGroupStates loaded")
        End Sub

        Private Sub SaveState(ByVal sender As Object, ByVal e As EventArgs) Handles barItem4.Click
            Dim serializer As AppStateSerializer = New AppStateSerializer(SerializeMode.XMLFile, "..\..\persist")
            Me.tabbedMDIMgr.SaveTabGroupStates(serializer)
            serializer.PersistNow()
            SendMessageToStatusBar("TabGroupStates saved")
        End Sub

        Private Sub CloseAll(ByVal sender As Object, ByVal e As EventArgs) Handles closeAllBarItem.Click
            For Each f As Form In Me.tabbedMDIMgr.MdiChildren
                If Me.ActiveMdiChild.Name <> f.Name Then
                    f.Close()
                End If
            Next f
        End Sub

        Private Sub ShowProperties(ByVal sender As Object, ByVal e As EventArgs) Handles barItem7.Click
            barItem7.Checked = Not barItem7.Checked

            tabControlAdv1.Visible = barItem7.Checked
            splitter1.Visible = barItem7.Checked
        End Sub

        Private Sub About(ByVal sender As Object, ByVal e As EventArgs) Handles barItem21.Click
            aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            aboutForm.ShowDialog()
        End Sub

        Private Sub ContextMenuItem_BeforePopup(ByVal sender As Object, ByVal e As CancelEventArgs)
            Select Case comboBox1.SelectedIndex
                Case 0
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default
                Case 1
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
                Case 2
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005
                Case 3
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
                Case 4
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
            End Select
            'Disables the "Close All But Me" barItem when the number of Tab Pages are equal to one.
            Dim i As Integer = 0
            For Each f As Form In Me.tabbedMDIMgr.MdiChildren
                i = i + 1
            Next f
            If i < 2 Then
                Me.closeAllBarItem.Enabled = False
            Else
                Me.closeAllBarItem.Enabled = True
            End If
        End Sub

        ' This event triggers before dropdown button shows its mdi list.
        Private Sub BeforePopup(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.DropDownPopupEventArgs)
            Select Case comboBox1.SelectedIndex
                Case 0
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default
                Case 1
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
                Case 2
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005
                Case 3
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
                Case 4
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
                    tabbedMDIMgr.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
            End Select
        End Sub

        Public Sub MenuCheckRemove(ByVal Item As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem)
            For Each barItem As BarItem In Me.StylesList.Items
                If barItem IsNot Item Then
                    CType(barItem, BarItem).Checked = False

                Else
                    CType(barItem, BarItem).Checked = True
                End If
            Next barItem
        End Sub

        ' Changing the tab style.
        Private Sub TabStyles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem8.Click, barItem9.Click, barItem10.Click, barItem11.Click, barItem12.Click, barItem13.Click, barItem14.Click, barItem15.Click, barItem16.Click, barItem17.Click, barItem18.Click, barItem19.Click, barItem20.Click, barItem22.Click, barItem23.Click
            Me.MenuCheckRemove(CType(sender, BarItem))

            If Me.barItem8.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRenderer2D)
            ElseIf Me.barItem9.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRenderer3D)
            ElseIf Me.barItem10.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode)
            ElseIf Me.barItem11.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.OneNoteStyleRenderer)
            ElseIf Me.barItem12.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.OneNoteStyleFlatTabsRenderer)
            ElseIf Me.barItem13.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2003)
            ElseIf Me.barItem14.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererWhidbey)
            ElseIf Me.barItem15.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbey)
            ElseIf Me.barItem16.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbeyBeta)
            ElseIf Me.barItem17.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererIE7)

                ' TabbedMDIManager does not have Office2007 Black and Silver them
                ' Hence accessing the internal tabControlAdv and applying
                ' 
            ElseIf Me.barItem18.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)

                For Each tabhost As TabHost In tabbedMDIMgr.TabGroupHosts
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Blue
                Next tabhost

            ElseIf Me.barItem19.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)

                For Each tabhost As TabHost In tabbedMDIMgr.TabGroupHosts
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Black
                Next tabhost

            ElseIf Me.barItem20.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)

                For Each tabhost As TabHost In tabbedMDIMgr.TabGroupHosts
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Silver
                Next tabhost

            ElseIf Me.barItem22.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererBlendLight)

            ElseIf Me.barItem23.Checked Then
                Me.tabbedMDIMgr.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererBlendDark)
            End If
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            'Show or Hide MDI List dropdown.
            Me.tabbedMDIMgr.DropDownButtonVisible = Not Me.tabbedMDIMgr.DropDownButtonVisible
            SendMessageToStatusBar("DropDownButtonVisible set to " & Me.checkBox1.Checked.ToString())
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' Show or Hide close button for individual tabs.
            Me.tabbedMDIMgr.ShowCloseButton = Not Me.tabbedMDIMgr.ShowCloseButton
            SendMessageToStatusBar("ShowCloseButton set to " & Me.checkBox2.Checked.ToString())
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            ' Show or Hide child form icons.
            Me.tabbedMDIMgr.UseIconsInTabs = Not Me.tabbedMDIMgr.UseIconsInTabs
            SendMessageToStatusBar("UseIconInTabs set to " & Me.checkBox3.Checked.ToString())
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            ' Show or Hide the tab panel.
            Me.tabbedMDIMgr.Visible = Not Me.tabbedMDIMgr.Visible
            SendMessageToStatusBar("TabbedMDIManager visibility set to " & Me.checkBox4.Checked.ToString())
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged
            ' Close the child form when clicking the tab using the middle mouse button.
            Me.tabbedMDIMgr.CloseOnMiddleButtonClick = checkBox5.Checked
            SendMessageToStatusBar("CloseOnMiddleButtonClick set to " & checkBox5.Checked.ToString())
        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox6.CheckedChanged
            ' Show or hide the close button.
            Me.tabbedMDIMgr.CloseButtonVisible = Not Me.tabbedMDIMgr.CloseButtonVisible
            SendMessageToStatusBar("CloseButton Visible set to " & Me.checkBox6.Checked.ToString())
        End Sub
	End Class
End Namespace