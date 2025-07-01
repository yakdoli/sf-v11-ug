Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for ClassView.
	''' </summary>
	Public Class ClassView : Inherits System.Windows.Forms.UserControl
		Private panelClassView As System.Windows.Forms.Panel
		Public classViewToolBar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private sortBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private newFolderBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private dockingImageList As System.Windows.Forms.ImageList
		Private tvClassView As System.Windows.Forms.TreeView
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MainForm()", 72, 72)
			Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dispose(bool)", 70, 71)
			Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("InitializeComponent()", 70, 70)
			Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("components", 73, 73)
			Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Program", 69, 69, New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3, treeNode4})
			Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ConsoleApplication", 68, 68, New System.Windows.Forms.TreeNode() { treeNode5})
			Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ConsoleApplication1", 61, 61, New System.Windows.Forms.TreeNode() { treeNode6})
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassView))
			Me.panelClassView = New System.Windows.Forms.Panel()
			Me.tvClassView = New System.Windows.Forms.TreeView()
			Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.classViewToolBar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.sortBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.newFolderBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.panelClassView.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelClassView
			' 
			Me.panelClassView.Controls.Add(Me.tvClassView)
			Me.panelClassView.Controls.Add(Me.classViewToolBar)
			Me.panelClassView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelClassView.Location = New System.Drawing.Point(0, 0)
			Me.panelClassView.Name = "panelClassView"
			Me.panelClassView.Size = New System.Drawing.Size(184, 568)
			Me.panelClassView.TabIndex = 0
			' 
			' tvClassView
			' 
			Me.tvClassView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tvClassView.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.tvClassView.ImageIndex = 0
			Me.tvClassView.ImageList = Me.dockingImageList
			Me.tvClassView.Location = New System.Drawing.Point(0, 25)
			Me.tvClassView.Name = "tvClassView"
			treeNode1.ImageIndex = 72
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 72
			treeNode1.Text = "MainForm()"
			treeNode2.ImageIndex = 70
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 71
			treeNode2.Text = "Dispose(bool)"
			treeNode3.ImageIndex = 70
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 70
			treeNode3.Text = "InitializeComponent()"
			treeNode4.ImageIndex = 73
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 73
			treeNode4.Text = "components"
			treeNode5.ImageIndex = 69
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 69
			treeNode5.Text = "Program"
			treeNode6.ImageIndex = 68
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 68
			treeNode6.Text = "ConsoleApplication"
			treeNode7.ImageIndex = 61
			treeNode7.Name = ""
			treeNode7.SelectedImageIndex = 61
			treeNode7.Text = "ConsoleApplication1"
			Me.tvClassView.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode7})
			Me.tvClassView.SelectedImageIndex = 0
			Me.tvClassView.Size = New System.Drawing.Size(184, 543)
			Me.tvClassView.TabIndex = 30
			' 
			' dockingImageList
			' 
			Me.dockingImageList.ImageStream = (CType(resources.GetObject("dockingImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.dockingImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.dockingImageList.Images.SetKeyName(0, "")
			Me.dockingImageList.Images.SetKeyName(1, "")
			Me.dockingImageList.Images.SetKeyName(2, "")
			Me.dockingImageList.Images.SetKeyName(3, "")
			Me.dockingImageList.Images.SetKeyName(4, "")
			Me.dockingImageList.Images.SetKeyName(5, "")
			Me.dockingImageList.Images.SetKeyName(6, "")
			Me.dockingImageList.Images.SetKeyName(7, "")
			Me.dockingImageList.Images.SetKeyName(8, "")
			Me.dockingImageList.Images.SetKeyName(9, "")
			Me.dockingImageList.Images.SetKeyName(10, "")
			Me.dockingImageList.Images.SetKeyName(11, "")
			Me.dockingImageList.Images.SetKeyName(12, "")
			Me.dockingImageList.Images.SetKeyName(13, "")
			Me.dockingImageList.Images.SetKeyName(14, "")
			Me.dockingImageList.Images.SetKeyName(15, "")
			Me.dockingImageList.Images.SetKeyName(16, "")
			Me.dockingImageList.Images.SetKeyName(17, "")
			Me.dockingImageList.Images.SetKeyName(18, "")
			Me.dockingImageList.Images.SetKeyName(19, "")
			Me.dockingImageList.Images.SetKeyName(20, "")
			Me.dockingImageList.Images.SetKeyName(21, "")
			Me.dockingImageList.Images.SetKeyName(22, "")
			Me.dockingImageList.Images.SetKeyName(23, "")
			Me.dockingImageList.Images.SetKeyName(24, "")
			Me.dockingImageList.Images.SetKeyName(25, "")
			Me.dockingImageList.Images.SetKeyName(26, "")
			Me.dockingImageList.Images.SetKeyName(27, "")
			Me.dockingImageList.Images.SetKeyName(28, "")
			Me.dockingImageList.Images.SetKeyName(29, "")
			Me.dockingImageList.Images.SetKeyName(30, "")
			Me.dockingImageList.Images.SetKeyName(31, "")
			Me.dockingImageList.Images.SetKeyName(32, "")
			Me.dockingImageList.Images.SetKeyName(33, "")
			Me.dockingImageList.Images.SetKeyName(34, "")
			Me.dockingImageList.Images.SetKeyName(35, "")
			Me.dockingImageList.Images.SetKeyName(36, "")
			Me.dockingImageList.Images.SetKeyName(37, "")
			Me.dockingImageList.Images.SetKeyName(38, "")
			Me.dockingImageList.Images.SetKeyName(39, "")
			Me.dockingImageList.Images.SetKeyName(40, "")
			Me.dockingImageList.Images.SetKeyName(41, "")
			Me.dockingImageList.Images.SetKeyName(42, "")
			Me.dockingImageList.Images.SetKeyName(43, "")
			Me.dockingImageList.Images.SetKeyName(44, "")
			Me.dockingImageList.Images.SetKeyName(45, "")
			Me.dockingImageList.Images.SetKeyName(46, "")
			Me.dockingImageList.Images.SetKeyName(47, "")
			Me.dockingImageList.Images.SetKeyName(48, "")
			Me.dockingImageList.Images.SetKeyName(49, "")
			Me.dockingImageList.Images.SetKeyName(50, "")
			Me.dockingImageList.Images.SetKeyName(51, "")
			Me.dockingImageList.Images.SetKeyName(52, "")
			Me.dockingImageList.Images.SetKeyName(53, "")
			Me.dockingImageList.Images.SetKeyName(54, "")
			Me.dockingImageList.Images.SetKeyName(55, "")
			Me.dockingImageList.Images.SetKeyName(56, "")
			Me.dockingImageList.Images.SetKeyName(57, "")
			Me.dockingImageList.Images.SetKeyName(58, "")
			Me.dockingImageList.Images.SetKeyName(59, "")
			Me.dockingImageList.Images.SetKeyName(60, "")
			Me.dockingImageList.Images.SetKeyName(61, "")
			Me.dockingImageList.Images.SetKeyName(62, "")
			Me.dockingImageList.Images.SetKeyName(63, "")
			Me.dockingImageList.Images.SetKeyName(64, "")
			Me.dockingImageList.Images.SetKeyName(65, "")
			Me.dockingImageList.Images.SetKeyName(66, "")
			Me.dockingImageList.Images.SetKeyName(67, "")
			Me.dockingImageList.Images.SetKeyName(68, "")
			Me.dockingImageList.Images.SetKeyName(69, "")
			Me.dockingImageList.Images.SetKeyName(70, "")
			Me.dockingImageList.Images.SetKeyName(71, "")
			Me.dockingImageList.Images.SetKeyName(72, "")
			Me.dockingImageList.Images.SetKeyName(73, "")
			Me.dockingImageList.Images.SetKeyName(74, "")
			Me.dockingImageList.Images.SetKeyName(75, "")
			Me.dockingImageList.Images.SetKeyName(76, "")
			Me.dockingImageList.Images.SetKeyName(77, "")
			Me.dockingImageList.Images.SetKeyName(78, "")
			' 
			' classViewToolBar
			' 
			Me.classViewToolBar.BackColor = System.Drawing.Color.Transparent
			Me.classViewToolBar.Dock = System.Windows.Forms.DockStyle.Top
			Me.classViewToolBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.sortBarItem, Me.newFolderBarItem})
			Me.classViewToolBar.Location = New System.Drawing.Point(0, 0)
			Me.classViewToolBar.Name = "classViewToolBar"
			Me.classViewToolBar.Size = New System.Drawing.Size(184, 25)
			Me.classViewToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.classViewToolBar.TabIndex = 0
			' 
			' sortBarItem
			' 
			Me.sortBarItem.ImageIndex = 36
			Me.sortBarItem.ImageList = Me.dockingImageList
			Me.sortBarItem.UpdateUIOnAppIdle = True
			' 
			' newFolderBarItem
			' 
			Me.newFolderBarItem.ImageIndex = 37
			Me.newFolderBarItem.ImageList = Me.dockingImageList
			' 
			' ClassView
			' 
			Me.Controls.Add(Me.panelClassView)
			Me.Name = "ClassView"
			Me.Size = New System.Drawing.Size(184, 568)
			Me.panelClassView.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
