Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for Properties.
	''' </summary>
	Public Class PropertiesView : Inherits System.Windows.Forms.UserControl
		Private dockingImageList As System.Windows.Forms.ImageList
		Private panelProperties As System.Windows.Forms.Panel
		Public propertiesToolBar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private catergorizedBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private alphabeticBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private propertiesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private eventBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private propertyPagesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertiesView))
			Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.panelProperties = New System.Windows.Forms.Panel()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.propertiesToolBar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.catergorizedBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.alphabeticBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.propertiesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.eventBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.propertyPagesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.panelProperties.SuspendLayout()
			Me.SuspendLayout()
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
			' panelProperties
			' 
			Me.panelProperties.Controls.Add(Me.propertyGrid1)
			Me.panelProperties.Controls.Add(Me.propertiesToolBar)
			Me.panelProperties.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelProperties.Location = New System.Drawing.Point(0, 0)
			Me.panelProperties.Name = "panelProperties"
			Me.panelProperties.Size = New System.Drawing.Size(216, 392)
			Me.panelProperties.TabIndex = 0
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.BackColor = System.Drawing.SystemColors.Control
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyGrid1.HelpVisible = False
			Me.propertyGrid1.LineColor = System.Drawing.SystemColors.Control
			Me.propertyGrid1.Location = New System.Drawing.Point(0, 25)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.SelectedObject = Me.propertyGrid1
			Me.propertyGrid1.Size = New System.Drawing.Size(216, 367)
			Me.propertyGrid1.TabIndex = 3
			Me.propertyGrid1.ToolbarVisible = False
			' 
			' propertiesToolBar
			' 
			Me.propertiesToolBar.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.propertiesToolBar.Bar.BarName = ""
			Me.propertiesToolBar.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.catergorizedBarItem, Me.alphabeticBarItem, Me.propertiesBarItem, Me.eventBarItem, Me.propertyPagesBarItem})
			Me.propertiesToolBar.Bar.Manager = Nothing
			Me.propertiesToolBar.Bar.SeparatorIndices.AddRange(New Integer() { 2, 4})
			Me.propertiesToolBar.Dock = System.Windows.Forms.DockStyle.Top
			Me.propertiesToolBar.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertiesToolBar.Location = New System.Drawing.Point(0, 0)
			Me.propertiesToolBar.Name = "propertiesToolBar"
			Me.propertiesToolBar.SeparatorIndices.AddRange(New Integer() { 2, 4})
			Me.propertiesToolBar.Size = New System.Drawing.Size(216, 25)
			Me.propertiesToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.propertiesToolBar.TabIndex = 0
			' 
			' catergorizedBarItem
			' 
			Me.catergorizedBarItem.ImageIndex = 25
			Me.catergorizedBarItem.ImageList = Me.dockingImageList
			' 
			' alphabeticBarItem
			' 
			Me.alphabeticBarItem.ImageIndex = 26
			Me.alphabeticBarItem.ImageList = Me.dockingImageList
			' 
			' propertiesBarItem
			' 
			Me.propertiesBarItem.ImageIndex = 27
			Me.propertiesBarItem.ImageList = Me.dockingImageList
			' 
			' eventBarItem
			' 
			Me.eventBarItem.ImageIndex = 28
			Me.eventBarItem.ImageList = Me.dockingImageList
			' 
			' propertyPagesBarItem
			' 
			Me.propertyPagesBarItem.ImageIndex = 29
			Me.propertyPagesBarItem.ImageList = Me.dockingImageList
			' 
			' PropertiesView
			' 
			Me.Controls.Add(Me.panelProperties)
			Me.Name = "PropertiesView"
			Me.Size = New System.Drawing.Size(216, 392)
			Me.panelProperties.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
