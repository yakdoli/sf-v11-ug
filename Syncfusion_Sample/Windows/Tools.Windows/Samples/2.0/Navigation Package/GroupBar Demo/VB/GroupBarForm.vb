Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D
Imports Syncfusion.Runtime.Serialization
Imports System.Collections
Imports Syncfusion.Windows.Forms.Tools.XPMenus


Namespace GroupBarDemo_2005
	Partial Public Class Form1
		Inherits Office2007Form
		#Region "Form's Constructor"
		Public Sub New()
			InitializeComponent()
			'Initial settings
			cmbGBBorder.SelectedIndex = 2
			cmbTextAlignment.SelectedIndex = 0
			cmbGBVisualStyle.SelectedIndex = 0
			cmbPopupResize.SelectedIndex = 0
			Me.cmbOutLookGBStyle.SelectedIndex = 2
			Me.cmbOutLookGBColorScheme.SelectedIndex = 0
			AddHandler gbAdvanced.GroupBarItemRemoved, AddressOf gbAdvanced_GroupBarItemRemoved
			AddHandler gbAdvanced.GroupBarItemAdded, AddressOf gbAdvanced_GroupBarItemAdded

			Me.cpCustomColor.SelectedColor = System.Drawing.SystemColors.HotTrack
			Me.tabControlAdv1.SelectedIndex = 1
			Me.gbAdvanced.SelectedItem = 1

			Me.imageListAdv1.ToImageList().ColorDepth = ColorDepth.Depth32Bit
			Me.gbOutlook.GroupBarItems(0).Image = Me.imageListAdv1.Images(0)
			Me.gbOutlook.GroupBarItems(1).Image = Me.imageListAdv1.Images(1)
			Me.gbOutlook.GroupBarItems(2).Image = Me.imageListAdv1.Images(2)
			Me.gbOutlook.GroupBarItems(3).Image = Me.imageListAdv1.Images(3)
			Me.gbOutlook.GroupBarItems(4).Image = Me.imageListAdv1.Images(4)
			Me.gbOutlook.GroupBarItems(5).Image = Me.imageListAdv1.Images(5)
			Me.gbOutlook.GroupBarItems(6).Image = Me.imageListAdv1.Images(6)
			cpCustomColor.SelectedColor = Color.FromArgb(131, 195, 207)
			SetCustomColor()



		End Sub

		#End Region

		#Region "VS Like GroupBar"

		'AnimatedSelection
		Private Sub animatedSelectionCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAnimatedSelection.CheckedChanged
			Me.gbVisualStudio.AnimatedSelection = Me.cbAnimatedSelection.Checked
		End Sub

		'Flat Look
		Private Sub flatLookCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbflatLook.CheckedChanged
			Me.gbVisualStudio.FlatLook = Me.cbflatLook.Checked
		End Sub

		'GroupBar BorderStyle
		Private Sub GBBorderComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGBBorder.SelectedIndexChanged
			Me.gbVisualStudio.BorderStyle = CType(System.Enum.Parse(GetType(BorderStyle), Me.cmbGBBorder.SelectedItem.ToString(), True), BorderStyle)
		End Sub

		'GroupBar ClientBorder
		Private Sub ClientBorderCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDrawClientBorder.CheckedChanged
			Me.gbVisualStudio.DrawClientBorder = Me.cbDrawClientBorder.Checked
			For Each gbItem As GroupBarItem In Me.gbVisualStudio.GroupBarItems
				gbItem.ClientBorderColors = New Syncfusion.Windows.Forms.Tools.BorderColors(cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor)
			Next gbItem
		End Sub
		'GroupBar Visual style
		Private Sub GBVisualStyleComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGBVisualStyle.SelectedIndexChanged
			Me.gbVisualStudio.VisualStyle = CType(System.Enum.Parse(GetType(VisualStyle), Me.cmbGBVisualStyle.SelectedItem.ToString(), True), VisualStyle)

		End Sub

		'Text Alignment
		Private Sub GBTextAlignmentComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTextAlignment.SelectedIndexChanged
			Me.gbVisualStudio.TextAlign = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Tools.TextAlignment), Me.cmbTextAlignment.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Tools.TextAlignment)
		End Sub

		'Integrated scrolling
		Private Sub IntegratedScrollingCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbIntegratedScrolling.CheckedChanged
			Me.gbVisualStudio.IntegratedScrolling = Me.cbIntegratedScrolling.Checked
		End Sub

		'GroupBar BackColor
		Private Sub GBBackColorPickerButton_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpBack.ColorSelected
			Me.gbVisualStudio.BackColor = cpBack.SelectedColor
			Me.GeneralGroupView.BackColor = Color.White
			Me.ComponentsGroupView.BackColor = Color.White
			Me.WinFormsGroupView.BackColor = Color.White
		End Sub

		#End Region

		#Region "Outlook  GroupBar"

		'ShowChevron
		Private Sub ChevronCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbChevron.CheckedChanged
			Me.gbOutlook.ShowChevron = cbChevron.Checked
		End Sub

		'Show item image in header
		Private Sub ImageInHeaderCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbImageInHeader.CheckedChanged
			Me.gbOutlook.ShowItemImageInHeader = cbImageInHeader.Checked
		End Sub

		'Enable Stacked Mode
		Private Sub StackedModeCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStackedMode.CheckedChanged
			Me.gbOutlook.StackedMode = Me.cbStackedMode.Checked
			Me.panel25.Enabled = Me.cbStackedMode.Checked
			Me.cbCollapse.Enabled = cbStackedMode.Checked
		End Sub

		'Visual style
		#Region "Visual style"
		Private Sub OutLookGBStyleComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbOutLookGBStyle.SelectedIndexChanged
			Me.gbOutlook.VisualStyle = CType(System.Enum.Parse(GetType(VisualStyle), Me.cmbOutLookGBStyle.SelectedItem.ToString(), True), VisualStyle)

			Me.monthCalendarAdv2.Style = CType(System.Enum.Parse(GetType(VisualStyle), Me.cmbOutLookGBStyle.SelectedItem.ToString(), True), VisualStyle)
			If Me.cmbOutLookGBStyle.SelectedIndex = 2 Then
				cmbOutLookGBColorScheme.Enabled = True
				For Each ctrl As Control In Me.gbOutlook.Controls

					If ctrl.GetType() Is GetType(XPTaskBar) Then
						Dim xpt As XPTaskBar = TryCast(ctrl, XPTaskBar)
						xpt.Style = XPTaskBarStyle.Office2007
						xpt.ThemesEnabled = False
					End If
				Next ctrl

				Me.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2007Generic
				Me.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Office2007Generic
			End If
			If Me.cmbOutLookGBStyle.SelectedIndex = 1 Then
				cmbOutLookGBColorScheme.Enabled = False
				For Each ctrl As Control In Me.gbOutlook.Controls

					If ctrl.GetType() Is GetType(XPTaskBar) Then
						Dim xpt As XPTaskBar = TryCast(ctrl, XPTaskBar)
						xpt.Style = XPTaskBarStyle.Default
						xpt.ThemesEnabled = True
					End If
				Next ctrl
				Me.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.WindowsXP
				Me.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.WindowsXP
			ElseIf Me.cmbOutLookGBStyle.SelectedIndex = 0 Then
				cmbOutLookGBColorScheme.Enabled = False
				For Each ctrl As Control In Me.gbOutlook.Controls

					If ctrl.GetType() Is GetType(XPTaskBar) Then
						Dim xpt As XPTaskBar = TryCast(ctrl, XPTaskBar)
						xpt.Style = XPTaskBarStyle.Default
						xpt.ThemesEnabled = False
					End If
				Next ctrl
				Me.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Classic
				Me.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Classic
			End If
		End Sub
		#End Region

		'Color scheme
		Private Sub OutLookGBColorSchemeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbOutLookGBColorScheme.SelectedIndexChanged
			If Me.cmbOutLookGBColorScheme.SelectedIndex = 0 Then
				Me.gbOutlook.Office2007Theme = Office2007Theme.Managed
			Else
				Me.gbOutlook.Office2007Theme = CType(System.Enum.Parse(GetType(Office2007Theme), Me.cmbOutLookGBColorScheme.SelectedItem.ToString(), True), Office2007Theme)
			End If
			Me.scrollersFrame1.OfficeColorScheme = CType(System.Enum.Parse(GetType(Office2007ColorScheme), Me.cmbOutLookGBColorScheme.SelectedItem.ToString(), True), Office2007ColorScheme)
			For Each ctrl As Control In Me.gbOutlook.Controls
				If ctrl.GetType() Is GetType(XPTaskBar) Then
					Dim xpt As XPTaskBar = TryCast(ctrl, XPTaskBar)
					xpt.Office2007ColorScheme = CType(System.Enum.Parse(GetType(Office2007Theme), Me.cmbOutLookGBColorScheme.SelectedItem.ToString(), True), Office2007Theme)
				End If
			Next ctrl
			Me.monthCalendarAdv2.Office2007Theme = CType(System.Enum.Parse(GetType(Office2007Theme), Me.cmbOutLookGBColorScheme.SelectedItem.ToString(), True), Office2007Theme)

		End Sub

		'Allow collapse
		Private Sub AllowCollapseCheckBoxAdv_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbAllowCollapse.CheckedChanged
			Me.gbOutlook.AllowCollapse = cbAllowCollapse.Checked
			Me.panel23.Enabled = cbAllowCollapse.Checked
		End Sub

		'Collapse GroupBar
		Private Sub CollapseCheckBoxAdv_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbCollapse.CheckedChanged
			Me.gbOutlook.Collapsed = cbCollapse.Checked
		End Sub

		'Show Gripper
		Private Sub checkBoxAdvGripper_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbShowGripper.CheckedChanged
			Me.gbOutlook.ShowPopupGripper = cbShowGripper.Checked
		End Sub

		'PopupAuto close 
		Private Sub checkBoxAdvAutoClose_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbAutoClose.CheckedChanged
			Me.gbOutlook.PopupAutoClose = Me.cbAutoClose.Checked
		End Sub

		'Collapsed width
		Private Sub CollapsedWidthNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericCollapsedWidth.ValueChanged
			Me.gbOutlook.CollapsedWidth = CInt(Fix(Me.numericCollapsedWidth.Value))
		End Sub

		'PopupResize mode
		Private Sub PopupResizeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPopupResize.SelectedIndexChanged
			Me.gbOutlook.PopupResizeMode = CType(System.Enum.Parse(GetType(PopupResizeMode), Me.cmbPopupResize.SelectedItem.ToString()), PopupResizeMode)
		End Sub


		#End Region

		#Region "Advanced Settings"

		#Region "Custom Colors"

		#Region "Custom colors for GroupBar with Office2007 Style"
		Private colors As Office2007Colors = Office2007Colors.Default
		Private Sub cpCustomColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpCustomColor.ColorSelected
			If Me.gbAdvanced.GroupBarItems.Count > 0 Then
				SetCustomColor()
				AddHandler NestedGroupBar.ProvideGroupBarItemBrush, AddressOf NestedGroupBar_ProvideGroupBarItemBrush
			End If
		End Sub

		Protected Sub SetCustomColor()
			'Sets custom colors for Office2007 style
			Me.gbOutlook.Office2007Theme = Office2007Theme.Managed
			Me.gbAdvanced.Office2007Theme = Office2007Theme.Blue

			colors.GroupBarItemTextColor = Color.Black
			colors.GroupBarBorderColor = cpCustomColor.SelectedColor

			colors.GroupBarHighlightColorDark = Color.FromArgb(248, 215, 185)
			colors.GroupBarHighlightColorLight = Color.FromArgb(255, 233, 215)

			colors.GroupBarItemColorDark = cpCustomColor.SelectedColor
			colors.GroupBarItemColorLight = Color.FromArgb(235, 246, 248)

			colors.GroupBarSelectedColorDark = Color.FromArgb(255, 191, 135)
			colors.GroupBarSelectedColorLight = Color.FromArgb(255, 233, 215)
			colors.GroupBarSelectedTopColorDark = Color.FromArgb(248, 215, 185)
			colors.GroupBarSelectedTopColorLight = Color.FromArgb(255, 233, 215)

			Me.gbAdvanced.GroupBarItems(Me.gbAdvanced.SelectedItem).ForeColor = Color.White
			Me.gbAdvanced.Refresh()


		End Sub
		#End Region

		#Region "Custom color for GroupBar with Office XP style"

		Private Sub NestedGroupBar_ProvideGroupBarItemBrush(ByVal sender As Object, ByVal args As ProvideGroupBarItemBrushEventArgs) Handles NestedGroupBar.ProvideGroupBarItemBrush
			Dim blend As New Blend()
			blend.Positions = New Single() { 0.0F, 0.4F, 0.4F + 0.001F, 1.0F }
			blend.Factors = New Single() { 0.0F, 0.5F, 1.0F, 0.5F }
			Dim lgb As LinearGradientBrush
			lgb = New LinearGradientBrush(args.Bounds, Color.White, cpCustomColor.SelectedColor, LinearGradientMode.Vertical)
			lgb.Blend = blend
			args.BackgroundBrush = lgb


			Me.NestedGroupBar.GroupBarItems(0).ClientBorderColors = New Syncfusion.Windows.Forms.Tools.BorderColors(cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor)
			Me.NestedGroupBar.GroupBarItems(1).ClientBorderColors = New Syncfusion.Windows.Forms.Tools.BorderColors(cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor)
			For Each gbItem As GroupBarItem In Me.gbAdvanced.GroupBarItems
				gbItem.ClientBorderColors = New Syncfusion.Windows.Forms.Tools.BorderColors(cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor)
			Next gbItem
			Me.PersonalGroupView.HighlightItemColor = cpCustomColor.SelectedColor
			Me.gvOffice.HighlightItemColor = cpCustomColor.SelectedColor
		End Sub
		#End Region
		#End Region


		#Region "Events"
		Private listViewItem1 As ListViewItem
		Private Sub gbAdvanced_GroupBarItemSelectionChanging(ByVal sender As Object, ByVal args As GroupBarItemSelectionChangingEventArgs) Handles gbAdvanced.GroupBarItemSelectionChanging
			listViewItem1 = New System.Windows.Forms.ListViewItem(New String() { "GroupBarItemSelectionChanging ", "Previous: " & args.OldSelected.ToString() & " New: " & args.NewSelected.ToString() })
			Me.listView1.Items.Add(listViewItem1)
		End Sub
		Private Sub gbAdvanced_GroupBarItemSelected(ByVal sender As Object, ByVal e As EventArgs) Handles gbAdvanced.GroupBarItemSelected
			Dim gb As GroupBar = TryCast(sender, GroupBar)
			listViewItem1 = New System.Windows.Forms.ListViewItem(New String() { "GroupBarItemSelected", gb.SelectedItem.ToString() })
			Me.listView1.Items.Add(listViewItem1)
		End Sub
		Private Sub gbAdvanced_GroupBarItemRemoved(ByVal sender As Object, ByVal args As GroupBarItemEventArgs)
			listViewItem1 = New System.Windows.Forms.ListViewItem(New String() { "GroupBarItemRemoved", "Item Removed: " & args.Item.Text })
			Me.listView1.Items.Add(listViewItem1)
		End Sub
		Private Sub gbAdvanced_GroupBarItemAdded(ByVal sender As Object, ByVal args As GroupBarItemEventArgs)
			listViewItem1 = New System.Windows.Forms.ListViewItem(New String() { "GroupBarItemAdded", "Item Added: " & args.Item.Text })
			Me.listView1.Items.Add(listViewItem1)
		End Sub
		Private Sub gbAdvanced_GroupBarItemRenamed(ByVal obj As Object, ByVal arg As GroupItemRenamedEventArgs) Handles gbAdvanced.GroupBarItemRenamed
			listViewItem1 = New System.Windows.Forms.ListViewItem(New String() { "GroupBarItemRenamed", "Item Renamed: " & arg.Index & " NewLabel: " & arg.NewLabel & " OldLabel: " & arg.OldLabel })
			Me.listView1.Items.Add(listViewItem1)
		End Sub

		' Handler for the GroupView.ShowContextMenu event.
		Private Sub gbAdvanced_ShowContextMenu(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbAdvanced.ShowContextMenu
			Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "ContextMenu Shown" })
			Me.listView1.Items.Add(listViewItem1)

			Dim menu As New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu()

			menu.ParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			menu.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003

			Dim additem As New BarItem("Add New Item", New EventHandler(AddressOf Me.gvc_MenuAddNewItem))
			additem.ImageList = Me.ilGroupBarSmall
			additem.ImageIndex = 28
			menu.ParentBarItem.Items.Add(additem)

			Dim removeitem As New BarItem("Remove Item", New EventHandler(AddressOf Me.gvc_MenuRemoveItem))
			removeitem.ImageList = Me.ilGroupBarSmall
			removeitem.ImageIndex = 27
			menu.ParentBarItem.Items.Add(removeitem)

			Dim renameitem As New BarItem("Rename Item", New EventHandler(AddressOf Me.gvc_MenuRenameItem))
			menu.ParentBarItem.Items.Add(renameitem)

			If Me.gbAdvanced.HighlightItem = -1 Then
				removeitem.Enabled = False
				renameitem.Enabled = False
			End If

			menu.Show(Me.gbAdvanced, Me.gbAdvanced.PointToClient(Cursor.Position))
		End Sub
		Public Sub gvc_MenuAddNewItem(ByVal sender As Object, ByVal e As EventArgs)
			' Create a new GroupBarItem with the new GroupView as the client
			Dim grpbaritem As New Syncfusion.Windows.Forms.Tools.GroupBarItem()

			grpbaritem.Text = String.Empty
			Me.gbAdvanced.GroupBarItems.Add(grpbaritem)
			Me.gbAdvanced.InplaceRenameItem(Me.gbAdvanced.GroupBarItems.Count - 1)
		End Sub

		Private Sub gvc_MenuRemoveItem(ByVal sender As Object, ByVal e As EventArgs)
			If Me.gbAdvanced.SelectedItem >= 0 AndAlso Me.gbAdvanced.GroupBarItems.Count > 0 Then

				Me.gbAdvanced.GroupBarItems.Remove(Me.gbAdvanced.GroupBarItems(Me.gbAdvanced.ContextMenuItem))
			End If
		End Sub

		Private Sub gvc_MenuRenameItem(ByVal sender As Object, ByVal e As EventArgs)

			Me.gbAdvanced.InplaceRenameItem(Me.gbAdvanced.ContextMenuItem)
		End Sub

		Private Sub gbOutlook_StateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gbOutlook.StateChanged
			cbCollapse.Checked = Me.gbOutlook.Collapsed
		End Sub


		#End Region

		#End Region

	End Class
End Namespace