Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for ObjectBrowser.
	''' </summary>
	Public Class ObjectBrowserView : Inherits System.Windows.Forms.UserControl
		Private panel1 As System.Windows.Forms.Panel
		Private browseBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Public objectBrowserToolBar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private sortNameParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private dockingImageList As System.Windows.Forms.ImageList
		Private sortTypeParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private backBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private forwardBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private findSymbolBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private llObjBrowserBottom As System.Windows.Forms.LinkLabel
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObjectBrowserView))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.llObjBrowserBottom = New System.Windows.Forms.LinkLabel()
			Me.objectBrowserToolBar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.browseBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.sortNameParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.sortTypeParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.backBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.forwardBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.findSymbolBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.llObjBrowserBottom)
			Me.panel1.Controls.Add(Me.objectBrowserToolBar)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(696, 88)
			Me.panel1.TabIndex = 0
			' 
			' llObjBrowserBottom
			' 
			Me.llObjBrowserBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.llObjBrowserBottom.Dock = System.Windows.Forms.DockStyle.Fill
			Me.llObjBrowserBottom.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.llObjBrowserBottom.LinkArea = New System.Windows.Forms.LinkArea(25, 58)
			Me.llObjBrowserBottom.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
			Me.llObjBrowserBottom.LinkColor = System.Drawing.Color.DarkGreen
			Me.llObjBrowserBottom.Location = New System.Drawing.Point(0, 25)
			Me.llObjBrowserBottom.Name = "llObjBrowserBottom"
			Me.llObjBrowserBottom.Size = New System.Drawing.Size(696, 63)
			Me.llObjBrowserBottom.TabIndex = 1
			Me.llObjBrowserBottom.TabStop = True
			Me.llObjBrowserBottom.Text = "public class RichTextBox: System.Windows.Forms.RichTextBox"
			Me.llObjBrowserBottom.UseCompatibleTextRendering = True
			' 
			' objectBrowserToolBar
			' 
			Me.objectBrowserToolBar.BackColor = System.Drawing.Color.Transparent
			Me.objectBrowserToolBar.Dock = System.Windows.Forms.DockStyle.Top
			Me.objectBrowserToolBar.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.objectBrowserToolBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.browseBarItem, Me.sortNameParentBarItem, Me.sortTypeParentBarItem, Me.backBarItem, Me.forwardBarItem, Me.findSymbolBarItem})
			Me.objectBrowserToolBar.Location = New System.Drawing.Point(0, 0)
			Me.objectBrowserToolBar.Name = "objectBrowserToolBar"
			Me.objectBrowserToolBar.SeparatorIndices.AddRange(New Integer() { 1, 3})
			Me.objectBrowserToolBar.Size = New System.Drawing.Size(696, 25)
			Me.objectBrowserToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.objectBrowserToolBar.TabIndex = 0
			' 
			' browseBarItem
			' 
			Me.browseBarItem.ID = "Select "
			Me.browseBarItem.MinWidth = 100
			Me.browseBarItem.Text = "Select Component"
			' 
			' sortNameParentBarItem
			' 
			Me.sortNameParentBarItem.ImageIndex = 26
			Me.sortNameParentBarItem.ImageList = Me.dockingImageList
			Me.sortNameParentBarItem.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown
			Me.sortNameParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
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
			' sortTypeParentBarItem
			' 
			Me.sortTypeParentBarItem.ImageIndex = 36
			Me.sortTypeParentBarItem.ImageList = Me.dockingImageList
			Me.sortTypeParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			' 
			' backBarItem
			' 
			Me.backBarItem.ImageIndex = 39
			Me.backBarItem.ImageList = Me.dockingImageList
			' 
			' forwardBarItem
			' 
			Me.forwardBarItem.ImageIndex = 40
			Me.forwardBarItem.ImageList = Me.dockingImageList
			' 
			' findSymbolBarItem
			' 
			Me.findSymbolBarItem.ImageIndex = 41
			Me.findSymbolBarItem.ImageList = Me.dockingImageList
			' 
			' ObjectBrowserView
			' 
			Me.Controls.Add(Me.panel1)
			Me.Name = "ObjectBrowserView"
			Me.Size = New System.Drawing.Size(696, 88)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
