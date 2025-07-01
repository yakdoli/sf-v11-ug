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
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace CustomControls_2005
	Public Partial Class Form1
		Inherits Office2007Form
		Public Sub New()
            InitializeComponent()
            Me.gridControl1(2, 1).Text = "2007"
            Me.gridControl1(2, 2).Text = "107,449,525"
            Me.gridControl1(2, 3).Text = "1,972,550(sq km) 761,602(sq mi)"
            Me.gridControl2(2, 1).Text = "2007"
            Me.gridControl2(2, 2).Text = "287,730"
            Me.gridControl2(2, 3).Text = "22,966(sq km) 8,867(sq mi)"
            Me.gridControl3(2, 1).Text = "2007"
            Me.gridControl3(2, 2).Text = "188,078,227"
            Me.gridControl3(2, 3).Text = "8,511,965(sq km)3,286,470(sq mi)"
			
			comboBoxAdv1.SelectedIndex = 0
			comboBoxAdv2.SelectedIndex = 0
			comboBoxAdv3.SelectedIndex = 0
        End Sub

		#Region "StateImage"
		Private Sub StateImageBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click, barItem7.Click, barItem13.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
			If barItem.Checked <> True Then
				barItem.Checked = True
			Else
			  barItem.Checked = False
			End If
			If barItem.Checked Then
				If barItem Is Me.barItem1 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).OpenImgIndex = Me.comboBoxAdv1.SelectedIndex
					Me.treeViewAdv1.Nodes(0).Nodes(0).ClosedImgIndex = Me.comboBoxAdv1.SelectedIndex
					Me.treeViewAdv1.Nodes(0).Nodes(0).ShowPlusMinus = False
				End If
				If barItem Is Me.barItem7 Then
					Dim imageindex As Integer = Me.comboBoxAdv2.SelectedIndex + 3
					Me.treeViewAdv1.Nodes(0).Nodes(1).OpenImgIndex = imageindex
					Me.treeViewAdv1.Nodes(0).Nodes(1).ClosedImgIndex = imageindex
					Me.treeViewAdv1.Nodes(0).Nodes(1).ShowPlusMinus = False
				End If
				If barItem Is Me.barItem13 Then
					Dim imageindex As Integer = Me.comboBoxAdv3.SelectedIndex + 6
					Me.treeViewAdv1.Nodes(0).Nodes(2).OpenImgIndex = imageindex
					Me.treeViewAdv1.Nodes(0).Nodes(2).ClosedImgIndex = imageindex
					Me.treeViewAdv1.Nodes(0).Nodes(2).ShowPlusMinus = False
				End If
			Else
				If barItem Is Me.barItem1 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).OpenImgIndex = -1
					Me.treeViewAdv1.Nodes(0).Nodes(0).ClosedImgIndex = -1
					Me.treeViewAdv1.Nodes(0).Nodes(0).ShowPlusMinus = True
				End If
				If barItem Is Me.barItem7 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).OpenImgIndex = -1
					Me.treeViewAdv1.Nodes(0).Nodes(1).ClosedImgIndex = -1
					Me.treeViewAdv1.Nodes(0).Nodes(1).ShowPlusMinus = True
				End If
				If barItem Is Me.barItem13 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).OpenImgIndex = -1
					Me.treeViewAdv1.Nodes(0).Nodes(2).ClosedImgIndex = -1
					Me.treeViewAdv1.Nodes(0).Nodes(2).ShowPlusMinus = True
				End If
				Me.treeViewAdv1.Refresh()
			End If



		End Sub
		#End Region

		#Region "LeftImage"
		Private Sub LeftImageBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem2.Click, barItem8.Click, barItem14.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
			If barItem.Checked <> True Then
				barItem.Checked = True
			Else
			  barItem.Checked = False
			End If
			If barItem.Checked Then
				If barItem Is Me.barItem2 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(0).LeftImageIndices = New Integer() { 0 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(1).LeftImageIndices = New Integer() { 1 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(2).LeftImageIndices = New Integer() { 2 }
				End If
				If barItem Is Me.barItem8 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(0).LeftImageIndices = New Integer() { 0 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(1).LeftImageIndices = New Integer() { 1 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(2).LeftImageIndices = New Integer() { 2 }
				End If
				If barItem Is Me.barItem14 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(0).LeftImageIndices = New Integer() { 0 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(1).LeftImageIndices = New Integer() { 1 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(2).LeftImageIndices = New Integer() { 2 }
				End If
			Else
				If barItem Is Me.barItem2 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(0).LeftImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(1).LeftImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(2).LeftImageIndices = New Integer() { -1 }
				End If
				If barItem Is Me.barItem8 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(0).LeftImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(1).LeftImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(2).LeftImageIndices = New Integer() { -1 }
				End If
				If barItem Is Me.barItem14 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(0).LeftImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(1).LeftImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(2).LeftImageIndices = New Integer() { -1 }
				End If
			End If
			Me.treeViewAdv1.Refresh()
		End Sub

		#End Region

		#Region "RightImage"
		Private Sub RightImageBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem3.Click, barItem9.Click, barItem15.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
			If barItem.Checked <> True Then
				barItem.Checked = True
			Else
				barItem.Checked = False
			End If
			If barItem.Checked Then
				If barItem Is Me.barItem3 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(0).RightImageIndices = New Integer() { 0 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(1).RightImageIndices = New Integer() { 1 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(2).RightImageIndices = New Integer() { 2 }
				End If
				If barItem Is Me.barItem9 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(0).RightImageIndices = New Integer() { 0 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(1).RightImageIndices = New Integer() { 1 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(2).RightImageIndices = New Integer() { 2 }
				End If
				If barItem Is Me.barItem15 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(0).RightImageIndices = New Integer() { 0 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(1).RightImageIndices = New Integer() { 1 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(2).RightImageIndices = New Integer() { 2 }
				End If
			Else

				If barItem Is Me.barItem3 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(0).RightImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(1).RightImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(0).Nodes(2).RightImageIndices = New Integer() { -1 }
				End If
				If barItem Is Me.barItem9 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(0).RightImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(1).RightImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(1).Nodes(2).RightImageIndices = New Integer() { -1 }
				End If
				If barItem Is Me.barItem15 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(0).RightImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(1).RightImageIndices = New Integer() { -1 }
					Me.treeViewAdv1.Nodes(0).Nodes(2).Nodes(2).RightImageIndices = New Integer() { -1 }
				End If
			End If
			Me.treeViewAdv1.Refresh()

		End Sub
		#End Region

		#Region "Stye1"
		Private Sub Style1BarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem4.Click, barItem10.Click, barItem16.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
			If barItem Is Me.barItem4 Then
				Me.treeViewAdv1.Nodes(0).Nodes(0).ChildStyle.BaseStyle = "Style1"
				Me.treeViewAdv1.SelectedNode = Nothing
				Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(0)
			End If
			If barItem Is Me.barItem10 Then
				Me.treeViewAdv1.Nodes(0).Nodes(1).ChildStyle.BaseStyle = "Style1"
				Me.treeViewAdv1.SelectedNode = Nothing
				Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(1)
			End If
			If barItem Is Me.barItem16 Then
				Me.treeViewAdv1.Nodes(0).Nodes(2).ChildStyle.BaseStyle = "Style1"
				Me.treeViewAdv1.SelectedNode = Nothing
				Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(2)
			End If
			Me.treeViewAdv1.Refresh()
		End Sub
#End Region

		#Region "style2"
		Private Sub Style2BarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem5.Click, barItem11.Click, barItem17.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
				If barItem Is Me.barItem5 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).ChildStyle.BaseStyle = "Style2"
					Me.treeViewAdv1.SelectedNode = Nothing
					Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(0)

				End If
				If barItem Is Me.barItem11 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).ChildStyle.BaseStyle = "Style2"
					Me.treeViewAdv1.SelectedNode = Nothing
					Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(1)
				End If
				If barItem Is Me.barItem17 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).ChildStyle.BaseStyle = "Style2"
					Me.treeViewAdv1.SelectedNode = Nothing
					Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(2)
				End If
				Me.treeViewAdv1.Refresh()

		End Sub
		#End Region

		#Region "Style3"
		Private Sub Style3BarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem6.Click, barItem12.Click, barItem18.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
				If barItem Is Me.barItem6 Then
					Me.treeViewAdv1.Nodes(0).Nodes(0).ChildStyle.BaseStyle = "Style3"
					Me.treeViewAdv1.SelectedNode = Nothing
					Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(0)
				End If
				If barItem Is Me.barItem12 Then
					Me.treeViewAdv1.Nodes(0).Nodes(1).ChildStyle.BaseStyle = "Style3"
					Me.treeViewAdv1.SelectedNode = Nothing
					Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(1)
				End If
				If barItem Is Me.barItem18 Then
					Me.treeViewAdv1.Nodes(0).Nodes(2).ChildStyle.BaseStyle = "Style3"
					Me.treeViewAdv1.SelectedNode = Nothing
					Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(2)
				End If
				Me.treeViewAdv1.Refresh()
		End Sub
		#End Region

		#Region "Update Grid"
			Private Sub ComboBoxAdv_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv1.SelectedIndexChanged, comboBoxAdv2.SelectedIndexChanged, comboBoxAdv3.SelectedIndexChanged
			Dim comboBoxAdv As ComboBoxAdv = TryCast(sender, ComboBoxAdv)
			If comboBoxAdv Is Me.comboBoxAdv1 Then
				If Me.comboBoxAdv1.SelectedItem.ToString() = "Mexico" Then
					Me.gridControl1(2, 1).Text = "2007"
					Me.gridControl1(2, 2).Text = "107,449,525"
					Me.gridControl1(2, 3).Text = "1,972,550(sq km) 761,602(sq mi)"

				End If
				If Me.comboBoxAdv1.SelectedItem.ToString() = "Canada" Then
					Me.gridControl1(2, 1).Text = "2007"
					Me.gridControl1(2, 2).Text = "33,098,932"
					Me.gridControl1(2, 3).Text = "9,984,670(sq km)3,855,081(sq mi)"
				End If
				If Me.comboBoxAdv1.SelectedItem.ToString() = "Bermuda" Then
					Me.gridControl1(2, 1).Text = "2007"
					Me.gridControl1(2, 2).Text = "65,773"
					Me.gridControl1(2, 3).Text = "53(sq km)20(sq mi)"
				End If
                If Me.treeViewAdv1.Nodes.Count > 0 Then
                    Me.treeViewAdv1.Nodes(0).Nodes(0).OpenImgIndex = Me.comboBoxAdv1.SelectedIndex
                    Me.treeViewAdv1.Nodes(0).Nodes(0).ClosedImgIndex = Me.comboBoxAdv1.SelectedIndex
                End If
			End If
			If comboBoxAdv Is Me.comboBoxAdv2 Then
				If Me.comboBoxAdv2.SelectedItem.ToString() = "Belize" Then
					Me.gridControl2(2, 1).Text = "2007"
					Me.gridControl2(2, 2).Text = "287,730"
					Me.gridControl2(2, 3).Text = "22,966(sq km) 8,867(sq mi)"

				End If
				If Me.comboBoxAdv2.SelectedItem.ToString() = "Panama" Then
					Me.gridControl2(2, 1).Text = "2007"
					Me.gridControl2(2, 2).Text = "3,191,319"
					Me.gridControl2(2, 3).Text = "78,200(sq km)30,193(sq mi)"
				End If
				If Me.comboBoxAdv2.SelectedItem.ToString() = "Costa Rica" Then
					Me.gridControl2(2, 1).Text = "2007"
					Me.gridControl2(2, 2).Text = "4,075,261"
					Me.gridControl2(2, 3).Text = "51,100(sq km)19,730(sq mi)"
				End If
				Dim imageindex As Integer = Me.comboBoxAdv2.SelectedIndex + 3
                If Me.treeViewAdv1.Nodes.Count > 0 Then
                    Me.treeViewAdv1.Nodes(0).Nodes(1).OpenImgIndex = imageindex
                    Me.treeViewAdv1.Nodes(0).Nodes(1).ClosedImgIndex = imageindex
                End If

			End If
			If comboBoxAdv Is Me.comboBoxAdv3 Then
				If Me.comboBoxAdv3.SelectedItem.ToString() = "Brazil" Then
					Me.gridControl3(2, 1).Text = "2007"
					Me.gridControl3(2, 2).Text = "188,078,227"
					Me.gridControl3(2, 3).Text = "8,511,965(sq km)3,286,470(sq mi)"

				End If
				If Me.comboBoxAdv3.SelectedItem.ToString() = "Argentina" Then
					Me.gridControl3(2, 1).Text = "2007"
					Me.gridControl3(2, 2).Text = "39,921,833"
					Me.gridControl3(2, 3).Text = "2,766,890(sq km)1,068,296(sq mi)"
				End If
				If Me.comboBoxAdv3.SelectedItem.ToString() = "Colombia" Then
					Me.gridControl3(2, 1).Text = "2007"
					Me.gridControl3(2, 2).Text = "43,593,035"
					Me.gridControl3(2, 3).Text = "1,138,910(sq km)439,733(sq mi)"
				End If
				Dim imageindex As Integer = Me.comboBoxAdv3.SelectedIndex + 6
                If Me.treeViewAdv1.Nodes.Count > 0 Then
                    Me.treeViewAdv1.Nodes(0).Nodes(2).OpenImgIndex = imageindex
                    Me.treeViewAdv1.Nodes(0).Nodes(2).ClosedImgIndex = imageindex
                End If

			End If
			Me.treeViewAdv1.Refresh()
			End Sub

			#End Region

		#Region "Clear Styles"
		Private Sub barItem22_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem22.Click
	 standardStyle()
		End Sub
		Private Sub standardStyle()
			Me.treeViewAdv1.Nodes(0).BaseStyle = "Standard"
			Me.treeViewAdv1.Nodes(0).ChildStyle.BaseStyle = "Standard"
			For Each treenode As TreeNodeAdv In Me.treeViewAdv1.Nodes(0).Nodes
				treenode.ChildStyle.BaseStyle = "Standard"
			Next treenode

			Me.treeViewAdv1.Refresh()
		End Sub
		#End Region
	End Class

End Namespace
