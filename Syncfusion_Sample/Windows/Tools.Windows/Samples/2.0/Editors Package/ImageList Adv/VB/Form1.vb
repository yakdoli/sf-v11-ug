Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace ImageListAdv_Demo

	'Control that have a image property to directly associate 
	'image can use the ImageListeAdv's image property.
	'For controls that have to be associated with a imageList
	'the imageListAdv should be converted to imageList via the 
	'ImageListAdv.ToImageList method.
	Partial Public Class Form1
		Inherits Office2007Form
		#Region "Form's Constructor"
		Public Sub New()
			InitializeComponent()
			For Each tabPage As TabPageAdv In Me.tabControlAdv3.TabPages
				tabPage.Hide()
			Next tabPage
			Me.tabPageAdv12.Show()
			Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0).Nodes(0)
			Me.treeViewAdv1.Nodes(0).Nodes(0).BaseStyle = "Style1"
		End Sub
		#End Region

		#Region "Form_Load"
		Private imgList As ImageList = New ImageList()
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.trackBarEx1.Maximum = 50
            Me.trackBarEx1.Minimum = 30
            Me.trackBarEx1.Value = 30
            Me.trackBarEx2.Maximum = 50
            Me.trackBarEx2.Minimum = 30
            Me.trackBarEx2.Value = 30

            'Converting ImageListAdv to ImageList
			imgList = Me.imageListAdv1.ToImageList()
			imgList.ColorDepth = ColorDepth.Depth32Bit

'			#Region "Assigning images to controls with direct image property."

			'BarItem Images through ImageListAdv
			Me.barItem1.Image = CType(Me.imageListAdv1.Images(0), ImageExt)
			Me.barItem2.Image = CType(Me.imageListAdv1.Images(1), ImageExt)
			Me.barItem3.Image = CType(Me.imageListAdv1.Images(2), ImageExt)
			Me.barItem4.Image = CType(Me.imageListAdv1.Images(17), ImageExt)
			Me.barItem5.Image = CType(Me.imageListAdv1.Images(18), ImageExt)
			Me.barItem6.Image = CType(Me.imageListAdv1.Images(19), ImageExt)

			'BarItem Images through ImageList
			Me.barItem7.Image = CType(Me.imageList1.Images(0), ImageExt)
			Me.barItem8.Image = CType(Me.imageList1.Images(1), ImageExt)
			Me.barItem9.Image = CType(Me.imageList1.Images(2), ImageExt)
			Me.barItem10.Image = CType(Me.imageList1.Images(17), ImageExt)
			Me.barItem11.Image = CType(Me.imageList1.Images(18), ImageExt)
			Me.barItem12.Image = CType(Me.imageList1.Images(19), ImageExt)


			'GroupBarItem Images through ImageListAdv
			Me.groupBarItem1.Image = Me.imageListAdv1.Images(23)
			Me.groupBarItem3.Image = Me.imageListAdv1.Images(24)

			'GroupBarItem Images through ImageList
			Me.groupBarItem5.Image = Me.imageList1.Images(23)
			Me.groupBarItem6.Image = Me.imageList1.Images(24)

			Me.xpToolBar1.Size = New Size(150, 25)
			Me.xpToolBar2.Size = New Size(150, 25)
			Me.pictureBox1.Image = Me.imageListAdv1.Images(16)
			Me.pictureBox2.Image = Me.imageList1.Images(16)
'		#End Region

'			#Region "Assigning images to controls with ImageList property."

			'TreeViewAdv Images through ImageListAdv
			Me.treeViewAdv2.NodeStateImageList = imgList
			Me.treeViewAdv2.LeftImageList = imgList
			Me.treeViewAdv2.Nodes(0).LeftImageIndices = New Integer() { 30 }
			Me.treeViewAdv2.Nodes(0).Nodes(0).LeftImageIndices = New Integer() { 27 }
			Me.treeViewAdv2.Nodes(0).Nodes(1).LeftImageIndices = New Integer() { 28 }
			Me.treeViewAdv2.Nodes(0).Nodes(2).LeftImageIndices = New Integer() { 29 }

			'TreeViewAdv Images through ImageList
			Me.treeViewAdv3.NodeStateImageList = Me.imageList1
			Me.treeViewAdv3.LeftImageList = Me.imageList1
			Me.treeViewAdv3.Nodes(0).LeftImageIndices = New Integer() { 30 }
			Me.treeViewAdv3.Nodes(0).Nodes(0).LeftImageIndices = New Integer() { 27 }
			Me.treeViewAdv3.Nodes(0).Nodes(1).LeftImageIndices = New Integer() { 28 }
			Me.treeViewAdv3.Nodes(0).Nodes(2).LeftImageIndices = New Integer() { 29 }

			'TabControlAdv Images through ImageListAdv
			Me.tabControlAdv1.ImageList = imgList
			Me.tabPageAdv1.ImageIndex = 12
			Me.tabPageAdv2.ImageIndex = 13
			Me.tabPageAdv5.ImageIndex = 14
			'TabControlAdv Images through ImageList
			Me.tabControlAdv2.ImageList = Me.imageList1
			Me.tabPageAdv3.ImageIndex = 12
			Me.tabPageAdv4.ImageIndex = 13
			Me.tabPageAdv6.ImageIndex = 14
'#End Region

		End Sub
		#End Region

		#Region "TabPage Visibility"
		Private Sub treeViewAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles treeViewAdv1.Click
			Me.treeViewAdv1.Nodes(0).Nodes(0).BaseStyle = "Style2"
			For Each tabPage As TabPageAdv In Me.tabControlAdv3.TabPages
				tabPage.Hide()
			Next tabPage
			Select Case Me.treeViewAdv1.SelectedNode.Text
				Case "Controls"
					Me.tabPageAdv12.Show()
				Case "DockingManager"
					Me.tabPageAdv12.Show()
				Case "GroupBar"
					Me.tabPageAdv9.Show()
				Case "TabControlAdv"
					Me.tabPageAdv10.Show()
				Case "TreeViewAdv"
					Me.tabPageAdv8.Show()
				Case "XPMenus"
					Me.tabPageAdv11.Show()
				Case "Image Size"
					Me.tabPageAdv13.Show()
			End Select
		End Sub
		#End Region

		#Region "Image Size"
		
        Private Sub trackBarEx2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBarEx2.ValueChanged
            Dim value As Integer = Me.trackBarEx2.Value
            Me.pictureBox2.Size = New Size(value, value)
            Me.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        End Sub
		


        Private Sub trackBarEx1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBarEx1.ValueChanged

            Dim value As Integer = Me.trackBarEx1.Value
            Me.pictureBox1.Size = New Drawing.Size(value, value)
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        End Sub
#End Region

	End Class
End Namespace