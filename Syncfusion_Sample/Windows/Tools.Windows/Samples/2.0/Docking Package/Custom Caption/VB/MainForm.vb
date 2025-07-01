Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Microsoft.Win32
Namespace CustomCaption
	Partial Public Class Form1
		Inherits Office2007Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()

			AddCaptionButtons()

			AddHandler comboBoxBarItem1.ListBox.SelectedValueChanged, AddressOf ListBox_SelectedValueChanged
			Me.propertyGrid1.ToolbarVisible = False
			Me.propertyGrid1.SelectedObject = Me.dockingManager1
		End Sub

		Private Sub ListBox_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Select Case TryCast(comboBoxBarItem1.ListBox.SelectedItem, String)
				Case "Default"
					Me.dockingManager1.VisualStyle = VisualStyle.Default
					Me.ColorScheme = Office2007Theme.Silver
					xpToolBar1.Office2007Theme = Office2007Theme.Silver
					toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					GroupBar1.Office2007Theme = Office2007Theme.Silver
					SetDefault()
				Case "Office2003"
					Me.dockingManager1.VisualStyle = VisualStyle.Office2003
					Me.ColorScheme = Office2007Theme.Silver
					xpToolBar1.Office2007Theme = Office2007Theme.Silver
					toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					GroupBar1.Office2007Theme = Office2007Theme.Silver
					SetDefault()
				Case "VS2005"
					Me.dockingManager1.VisualStyle = VisualStyle.VS2005
					Me.ColorScheme = Office2007Theme.Silver
					xpToolBar1.Office2007Theme = Office2007Theme.Silver
					GroupBar1.Office2007Theme = Office2007Theme.Silver
					toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					SetDefault()
				Case "Office2007"
					Me.dockingManager1.VisualStyle = VisualStyle.Office2007
					Me.ColorScheme = Office2007Theme.Blue
					xpToolBar1.Office2007Theme = Office2007Theme.Blue
					toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
					GroupBar1.Office2007Theme = Office2007Theme.Blue
					SetOffice2007()
				Case "Office2007Outlook"
					Me.dockingManager1.VisualStyle = VisualStyle.Office2007Outlook
					Me.ColorScheme = Office2007Theme.Blue
					xpToolBar1.Office2007Theme = Office2007Theme.Blue
					toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
					GroupBar1.Office2007Theme = Office2007Theme.Blue
					SetOffice2007Outlook()
				Case Else
			End Select

		End Sub
		#End Region

		#Region "AddCaptionButtons"
		Private plus As New Syncfusion.Windows.Forms.Tools.CaptionButton()
		Private minus As New Syncfusion.Windows.Forms.Tools.CaptionButton()
		Private [next] As New Syncfusion.Windows.Forms.Tools.CaptionButton()
		Private previous As New Syncfusion.Windows.Forms.Tools.CaptionButton()
		Private helpShow As New Syncfusion.Windows.Forms.Tools.CaptionButton()
		Private toolTipInfo1 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
		Private toolTipInfo2 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
		Private toolTipInfo3 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
		Private toolTipInfo4 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
		Private toolTipInfo5 As New Syncfusion.Windows.Forms.Tools.ToolTipInfo()

		Private Sub AddCaptionButtons()
'#Region "CaptionButton for TreeViewAdv through code"

			  plus.ImageIndex = 7
			  plus.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom
			  plus.TransparentImageColor = System.Drawing.Color.Transparent
			  AddHandler plus.Click, AddressOf plus_Click

			  'Set tooltip
			  toolTipInfo1.BackColor = Color.Bisque
			  toolTipInfo1.Header.Text = "Collapse nodes"
			  toolTipInfo1.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			  ' To assign the created tooltip to the caption button
			  plus.SuperToolTipInfo=toolTipInfo1

			  minus.ImageIndex = 6
			  minus.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom
			  minus.TransparentImageColor = System.Drawing.Color.Transparent
			  AddHandler minus.Click, AddressOf minus_Click

			  Dim cbTreeview As New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			  cbTreeview.Add(plus)
			  cbTreeview.Add(minus)

			  Me.dockingManager1.SetCustomCaptionButtons(Me.treeViewAdv1, cbTreeview)
			  'Set tooltip
			  toolTipInfo2.BackColor = Color.Bisque
			  toolTipInfo2.Header.Text = "Expand nodes"
			  toolTipInfo2.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			  ' To assign the created tooltip to a the caption button
			  minus.SuperToolTipInfo = toolTipInfo2
'#End Region

'			 #Region "CaptionButton for GroupBar through code"

			   [next].ImageIndex = 5
			   [next].Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom
			   [next].TransparentImageColor = System.Drawing.Color.Transparent
			   'Set tooltip
			   toolTipInfo3.BackColor = Color.Bisque
			   toolTipInfo3.Header.Text = "View Next Item"
			   toolTipInfo3.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			   ' To assign the created tooltip to a the caption button
			   [next].SuperToolTipInfo = toolTipInfo3

			   previous.ImageIndex = 4
			   previous.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom
			   previous.TransparentImageColor = System.Drawing.Color.Transparent
			   Dim cbGroupBar1 As New CaptionButtonsCollection()
			   cbGroupBar1.Add([next])
			   cbGroupBar1.Add(previous)

			   Me.dockingManager1.SetCustomCaptionButtons(Me.GroupBar1, cbGroupBar1)
			   'Set tooltip
			   toolTipInfo4.BackColor = Color.Bisque
			   toolTipInfo4.Header.Text = "View Previous Item"
			   toolTipInfo4.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			   ' To assign the created tooltip to the caption button
			   previous.SuperToolTipInfo = toolTipInfo4
'			  #End Region

'			  #Region "CaptionButton for propertyGrid through code"

			   helpShow.ImageIndex = 9
			   helpShow.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom
			   helpShow.TransparentImageColor = System.Drawing.Color.Transparent
			   AddHandler helpShow.Click, AddressOf helpShow_Click
			   Dim cbProperty As New CaptionButtonsCollection()
			   cbProperty.Add(helpShow)
			   Me.dockingManager1.SetCustomCaptionButtons(Me.propertyGrid1, cbProperty)
			   'Set tooltip
			   toolTipInfo5.BackColor = Color.Bisque
			   If Me.propertyGrid1.HelpVisible Then
				   toolTipInfo5.Header.Text = "Hide help bar"
			   Else
				   toolTipInfo5.Header.Text = "Show help bar"
			   End If
			   toolTipInfo5.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			   ' To assign the created tooltip to a the caption button
			   helpShow.SuperToolTipInfo = toolTipInfo5
'			   #End Region

		End Sub
		 #End Region

		#Region "Caption Button Events"

		Private Sub minus_Click(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.treeViewAdv1.ExpandAll()
		End Sub

		Private Sub plus_Click(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.treeViewAdv1.CollapseAll()
		End Sub
		Private Sub helpShow_Click(ByVal sender As Object, ByVal e As CancelEventArgs)
			If Me.propertyGrid1.HelpVisible Then
				Me.propertyGrid1.HelpVisible = False
				toolTipInfo5.Header.Text = "Show help bar"
				helpShow.ImageIndex = 8

			Else
				Me.propertyGrid1.HelpVisible = True
				toolTipInfo5.Header.Text = "Hide help bar"
				helpShow.ImageIndex = 9
			End If
		End Sub
		#End Region

		#Region "Helper Methods"
		Private Sub SetDefault()
			If Me.dockingManager1.VisualStyle = VisualStyle.Default Then
				Me.comboBoxBarItem1.ListBox.SelectedIndex = 0
			End If
			'this.BackColor = Color.White;
			Me.GroupBar1.BackColor = System.Drawing.SystemColors.Control
			Me.groupBarItem3.BackColor = System.Drawing.SystemColors.Control
			Me.groupBarItem4.BackColor = System.Drawing.SystemColors.Control
			Me.groupBarItem5.BackColor = System.Drawing.SystemColors.Control
			Me.propertyGrid1.BackColor = Color.White
			Me.propertyGrid1.LineColor = Color.White
			Me.label1.BackColor = Color.White
			Me.groupView1.BackColor=Color.White
			Me.groupView2.BackColor=Color.White
			Me.groupView3.BackColor=Color.White
		End Sub
		Private Sub SetOffice2007()
			Me.dockingManager1.VisualStyle = VisualStyle.Office2007
			Me.BackColor = Color.FromArgb(241, 244, 254)
			Me.GroupBar1.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupBarItem3.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupBarItem4.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupBarItem5.BackColor = Color.FromArgb(241, 244, 254)
			Me.propertyGrid1.BackColor = Color.FromArgb(241, 244, 254)
			Me.propertyGrid1.LineColor = Color.FromArgb(241, 244, 254)
			Me.label1.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupView1.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupView2.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupView3.BackColor = Color.FromArgb(241, 244, 254)
		End Sub

		Private Sub SetOffice2007Outlook()
			Me.dockingManager1.VisualStyle = VisualStyle.Office2007Outlook
			Me.BackColor = Color.FromArgb(241, 244, 254)
			Me.GroupBar1.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupBarItem3.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupBarItem4.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupBarItem5.BackColor = Color.FromArgb(241, 244, 254)
			Me.propertyGrid1.BackColor = Color.FromArgb(241, 244, 254)
			Me.propertyGrid1.LineColor = Color.FromArgb(241, 244, 254)
			Me.label1.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupView1.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupView2.BackColor = Color.FromArgb(241, 244, 254)
			Me.groupView3.BackColor = Color.FromArgb(241, 244, 254)
		End Sub
		#End Region


		Private Sub ShowCaptionClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click
			Me.barItem1.Checked = Not Me.barItem1.Checked
			Me.dockingManager1.ShowCaption = Me.barItem1.Checked
		End Sub

		Private Sub ShowCaptionImageClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem2.Click
			Me.barItem2.Checked = Not Me.barItem2.Checked
			Me.dockingManager1.ShowCaptionImages = Me.barItem2.Checked
		End Sub

		Private Sub EnableSuperToolTipClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem3.Click
			Me.barItem3.Checked = Not Me.barItem3.Checked
			Me.dockingManager1.EnableSuperToolTip = Me.barItem3.Checked
		End Sub
		Private Sub ShowCaptionInFloating_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem4.Click
			Me.barItem4.Checked = Not Me.barItem4.Checked
			Me.dockingManager1.ShowCustomButtonsInFloating = Me.barItem4.Checked
		End Sub
		Private Sub InActiveCaptionBackGround_ButtonClicked(ByVal sender As Object, ByVal e As EventArgs) Handles inactiveCaptionBack.Click
			If Me.dockingManager1.VisualStyle <> VisualStyle.Default Then
				MessageBoxAdv.Show("You should set Visual Style to Default to change the backcolor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					inactiveCaptionBack.ForeColor = colorDialog1.Color
					Me.dockingManager1.InActiveCaptionBackground = New Syncfusion.Drawing.BrushInfo(colorDialog1.Color)
					Me.dockingManager1.VisualStyle = VisualStyle.Default
					SetDefault()
				End If
			End If
		End Sub

		Private Sub activeCaptionBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles activeCaptionBack.Click
			If Me.dockingManager1.VisualStyle <> VisualStyle.Default Then
				MessageBoxAdv.Show("You should set Visual Style to Default to change the backcolor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					activeCaptionBack.ForeColor = colorDialog1.Color
					Me.dockingManager1.ActiveCaptionBackground = New Syncfusion.Drawing.BrushInfo(colorDialog1.Color)
					Me.dockingManager1.VisualStyle = VisualStyle.Default
					SetDefault()
				End If
			End If
		End Sub

		Private Sub inactiveCaptionFore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inactiveCaptionFore.Click
			If Me.dockingManager1.VisualStyle <> VisualStyle.Default Then
				MessageBoxAdv.Show("You should set Visual Style to Default to change the forecolor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					inactiveCaptionFore.ForeColor = colorDialog1.Color
					Me.dockingManager1.InActiveCaptionForeGround = colorDialog1.Color
					Me.dockingManager1.VisualStyle = VisualStyle.Default
					SetDefault()
				End If
			End If
		End Sub

		Private Sub activeCaptionFore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles activeCaptionFore.Click
			If Me.dockingManager1.VisualStyle <> VisualStyle.Default Then
				MessageBoxAdv.Show("You should set Visual Style to Default to change the forecolor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					activeCaptionFore.ForeColor = colorDialog1.Color
					Me.dockingManager1.ActiveCaptionForeGround = colorDialog1.Color
					Me.dockingManager1.VisualStyle = VisualStyle.Default
					SetDefault()
				End If
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.comboBoxBarItem1.ListBox.SelectedIndex = 3
			Me.comboBoxBarItem1.TextBoxValue = comboBoxBarItem1.ListBox.SelectedItem.ToString()
		End Sub

	End Class
End Namespace