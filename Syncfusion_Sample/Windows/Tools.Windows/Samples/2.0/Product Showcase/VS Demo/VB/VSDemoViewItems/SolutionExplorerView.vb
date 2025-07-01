Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for SolutionExplorer.
	''' </summary>
	Public Class SolutionExplorerView : Inherits System.Windows.Forms.UserControl
		Private panelSolutionExplorer As System.Windows.Forms.Panel
		Private viewCodeBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private viewDesignerBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private refreshBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private showAllFilesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private dockingImageList As System.Windows.Forms.ImageList
		Private propertiesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private tvSolutionExp As System.Windows.Forms.TreeView
		Public solutionExplorerToolBar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
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
			Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solution 'ConsoleApplication1' (1 Project)", 31, 31)
			Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System", 67, 67)
			Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System.Data", 67, 67)
			Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System.Windows.Forms", 67, 67)
			Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("References", 62, 62, New System.Windows.Forms.TreeNode() { treeNode2, treeNode3, treeNode4})
			Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("App.ico", 64, 64)
			Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AssemblyInfo.cs", 63, 63)
			Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Class1.cs", 63, 63)
			Dim treeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ConsoleApplication", 79, 79, New System.Windows.Forms.TreeNode() { treeNode5, treeNode6, treeNode7, treeNode8})
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolutionExplorerView))
			Me.panelSolutionExplorer = New System.Windows.Forms.Panel()
			Me.tvSolutionExp = New System.Windows.Forms.TreeView()
			Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.solutionExplorerToolBar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.viewCodeBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.viewDesignerBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.refreshBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.showAllFilesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.propertiesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.panelSolutionExplorer.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelSolutionExplorer
			' 
			Me.panelSolutionExplorer.Controls.Add(Me.tvSolutionExp)
			Me.panelSolutionExplorer.Controls.Add(Me.solutionExplorerToolBar)
			Me.panelSolutionExplorer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelSolutionExplorer.Location = New System.Drawing.Point(0, 0)
			Me.panelSolutionExplorer.Name = "panelSolutionExplorer"
			Me.panelSolutionExplorer.Size = New System.Drawing.Size(176, 328)
			Me.panelSolutionExplorer.TabIndex = 0
			' 
			' tvSolutionExp
			' 
			Me.tvSolutionExp.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tvSolutionExp.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.tvSolutionExp.HideSelection = False
			Me.tvSolutionExp.ImageIndex = 0
			Me.tvSolutionExp.ImageList = Me.dockingImageList
			Me.tvSolutionExp.Location = New System.Drawing.Point(0, 25)
			Me.tvSolutionExp.Name = "tvSolutionExp"
			treeNode1.ImageIndex = 31
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 31
			treeNode1.Text = "Solution 'ConsoleApplication1' (1 Project)"
			treeNode2.ImageIndex = 67
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 67
			treeNode2.Text = "System"
			treeNode3.ImageIndex = 67
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 67
			treeNode3.Text = "System.Data"
			treeNode4.ImageIndex = 67
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 67
			treeNode4.Text = "System.Windows.Forms"
			treeNode5.ImageIndex = 62
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 62
			treeNode5.Text = "References"
			treeNode6.ImageIndex = 64
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 64
			treeNode6.Text = "App.ico"
			treeNode7.ImageIndex = 63
			treeNode7.Name = ""
			treeNode7.SelectedImageIndex = 63
			treeNode7.Text = "AssemblyInfo.cs"
			treeNode8.ImageIndex = 63
			treeNode8.Name = ""
			treeNode8.SelectedImageIndex = 63
			treeNode8.Text = "Class1.cs"
			treeNode9.ImageIndex = 79
			treeNode9.Name = ""
			treeNode9.SelectedImageIndex = 79
			treeNode9.Text = "ConsoleApplication"
			Me.tvSolutionExp.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode1, treeNode9})
			Me.tvSolutionExp.SelectedImageIndex = 0
			Me.tvSolutionExp.Size = New System.Drawing.Size(176, 303)
			Me.tvSolutionExp.TabIndex = 2
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
			Me.dockingImageList.Images.SetKeyName(79, "")
			' 
			' solutionExplorerToolBar
			' 
			Me.solutionExplorerToolBar.BackColor = System.Drawing.Color.Transparent
			Me.solutionExplorerToolBar.Dock = System.Windows.Forms.DockStyle.Top
			Me.solutionExplorerToolBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.viewCodeBarItem, Me.viewDesignerBarItem, Me.refreshBarItem, Me.showAllFilesBarItem, Me.propertiesBarItem})
			Me.solutionExplorerToolBar.Location = New System.Drawing.Point(0, 0)
			Me.solutionExplorerToolBar.Name = "solutionExplorerToolBar"
			Me.solutionExplorerToolBar.SeparatorIndices.AddRange(New Integer() { 2, 4})
			Me.solutionExplorerToolBar.Size = New System.Drawing.Size(176, 25)
			Me.solutionExplorerToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.solutionExplorerToolBar.TabIndex = 0
			' 
			' viewCodeBarItem
			' 
			Me.viewCodeBarItem.ImageIndex = 4
			Me.viewCodeBarItem.ImageList = Me.dockingImageList
			' 
			' viewDesignerBarItem
			' 
			Me.viewDesignerBarItem.ImageIndex = 5
			Me.viewDesignerBarItem.ImageList = Me.dockingImageList
			' 
			' refreshBarItem
			' 
			Me.refreshBarItem.ImageIndex = 6
			Me.refreshBarItem.ImageList = Me.dockingImageList
			' 
			' showAllFilesBarItem
			' 
			Me.showAllFilesBarItem.ImageIndex = 7
			Me.showAllFilesBarItem.ImageList = Me.dockingImageList
			Me.showAllFilesBarItem.UpdateUIOnAppIdle = True
			' 
			' propertiesBarItem
			' 
			Me.propertiesBarItem.ImageIndex = 8
			Me.propertiesBarItem.ImageList = Me.dockingImageList
			' 
			' SolutionExplorerView
			' 
			Me.Controls.Add(Me.panelSolutionExplorer)
			Me.Name = "SolutionExplorerView"
			Me.Size = New System.Drawing.Size(176, 328)
			Me.panelSolutionExplorer.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
