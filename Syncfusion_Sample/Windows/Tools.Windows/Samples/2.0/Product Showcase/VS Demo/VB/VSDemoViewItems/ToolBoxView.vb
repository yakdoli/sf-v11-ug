Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for ToolBox.
	''' </summary>
	Public Class ToolBoxView : Inherits System.Windows.Forms.UserControl
		Private panelToolBox As System.Windows.Forms.Panel
		Public gBToolBox As Syncfusion.Windows.Forms.Tools.GroupBar
		Private gvbSyncfusion As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private gvbComponents As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private gvbWindowsForm As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private gvbGeneral As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private largeImageList As System.Windows.Forms.ImageList
		Public gvcSyncfusion As Syncfusion.Windows.Forms.Tools.GroupView
		Private dockingImageList As System.Windows.Forms.ImageList
		Public gvcComponents As Syncfusion.Windows.Forms.Tools.GroupView
		Public gvcWindowsForms As Syncfusion.Windows.Forms.Tools.GroupView
		Public gvcGeneral As Syncfusion.Windows.Forms.Tools.GroupView
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolBoxView))
			Me.panelToolBox = New System.Windows.Forms.Panel()
			Me.gBToolBox = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.gvcSyncfusion = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.gvcGeneral = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.gvcComponents = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.gvcWindowsForms = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.gvbSyncfusion = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.gvbComponents = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.gvbWindowsForm = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.gvbGeneral = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.panelToolBox.SuspendLayout()
			CType(Me.gBToolBox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gBToolBox.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelToolBox
			' 
			Me.panelToolBox.Controls.Add(Me.gBToolBox)
			Me.panelToolBox.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelToolBox.Location = New System.Drawing.Point(0, 0)
			Me.panelToolBox.Name = "panelToolBox"
			Me.panelToolBox.Size = New System.Drawing.Size(216, 568)
			Me.panelToolBox.TabIndex = 0
			' 
			' gBToolBox
			' 
			Me.gBToolBox.AllowDrop = True
			Me.gBToolBox.BackColor = System.Drawing.SystemColors.Control
			Me.gBToolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gBToolBox.Controls.Add(Me.gvcSyncfusion)
			Me.gBToolBox.Controls.Add(Me.gvcWindowsForms)
			Me.gBToolBox.Controls.Add(Me.gvcComponents)
			Me.gBToolBox.Controls.Add(Me.gvcGeneral)
			Me.gBToolBox.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gBToolBox.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold)
			Me.gBToolBox.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(33)))), (CInt((CByte(77)))), (CInt((CByte(140)))))
			Me.gBToolBox.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.gvbSyncfusion, Me.gvbComponents, Me.gvbWindowsForm, Me.gvbGeneral})
			Me.gBToolBox.Location = New System.Drawing.Point(0, 0)
			Me.gBToolBox.Name = "gBToolBox"
			Me.gBToolBox.SelectedItem = 0
			Me.gBToolBox.Size = New System.Drawing.Size(216, 568)
			Me.gBToolBox.TabIndex = 0
			Me.gBToolBox.Text = "groupBar1"
			Me.gBToolBox.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' gvcSyncfusion
			' 
			Me.gvcSyncfusion.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(236)))), (CInt((CByte(255)))))
			Me.gvcSyncfusion.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvcSyncfusion.ButtonView = True
			Me.gvcSyncfusion.FlatLook = True
			Me.gvcSyncfusion.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gvcSyncfusion.ForeColor = System.Drawing.Color.Black
			Me.gvcSyncfusion.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("AutoComplete", 43, True, Nothing, "AutoComplete"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("XPToolBar", 44, True, Nothing, "XPToolBar"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("ButtonEdit", 45, True, Nothing, "ButtonEdit"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CalculatorControl", 46, True, Nothing, "CalculatorControl"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("ColorPicker", 47, True, Nothing, "ColorPicker"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CurrencyEdit", 48, True, Nothing, "CurrencyEdit"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CurrencyTextBox", 48, True, Nothing, "CurrencyTextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("FolderBrowser", 49, True, Nothing, "FolderBrowser"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBar", 50, True, Nothing, "GroupBar"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupView", 51, True, Nothing, "GroupView"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DockingManager", 52, True, Nothing, "DockingManager"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainFrameBarManager", 53, True, Nothing, "MainFrameBarManager"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MaskedEditBox", 54, True, Nothing, "MaskedEditBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("PopupMenu", 55, True, Nothing, "PopupMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("GridRecordNavigationControl", 56, True, Nothing, "GridRecordNavigationControl"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("SplashControl", 57, True, Nothing, "SplashControl"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TabControlExt", 58, True, Nothing, "TabControlExt")})
			Me.gvcSyncfusion.HighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(238)))), (CInt((CByte(194)))))
			Me.gvcSyncfusion.IntegratedScrolling = True
			Me.gvcSyncfusion.ItemYSpacing = 1
			Me.gvcSyncfusion.LargeImageList = Me.largeImageList
			Me.gvcSyncfusion.Location = New System.Drawing.Point(1, 23)
			Me.gvcSyncfusion.Name = "gvcSyncfusion"
			Me.gvcSyncfusion.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(254)))), (CInt((CByte(128)))), (CInt((CByte(62)))))
			Me.gvcSyncfusion.SelectedItem = 0
			Me.gvcSyncfusion.SelectedItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(111)))))
			Me.gvcSyncfusion.Size = New System.Drawing.Size(214, 478)
			Me.gvcSyncfusion.SmallImageList = Me.dockingImageList
			Me.gvcSyncfusion.SmallImageView = True
			Me.gvcSyncfusion.TabIndex = 32
			Me.gvcSyncfusion.Text = "groupViewControl1"
			' 
			' largeImageList
			' 
			Me.largeImageList.ImageStream = (CType(resources.GetObject("largeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.largeImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.largeImageList.Images.SetKeyName(0, "")
			Me.largeImageList.Images.SetKeyName(1, "")
			Me.largeImageList.Images.SetKeyName(2, "")
			Me.largeImageList.Images.SetKeyName(3, "")
			Me.largeImageList.Images.SetKeyName(4, "")
			Me.largeImageList.Images.SetKeyName(5, "")
			Me.largeImageList.Images.SetKeyName(6, "")
			Me.largeImageList.Images.SetKeyName(7, "")
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
			' gvcGeneral
			' 
			Me.gvcGeneral.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(236)))), (CInt((CByte(255)))))
			Me.gvcGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvcGeneral.ButtonView = True
			Me.gvcGeneral.FlatLook = True
			Me.gvcGeneral.FlowView = True
			Me.gvcGeneral.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gvcGeneral.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 10, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 11, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 12, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 13, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 14, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 15, True, Nothing, "RadioButton")})
			Me.gvcGeneral.HighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(238)))), (CInt((CByte(194)))))
			Me.gvcGeneral.HighlightText = False
			Me.gvcGeneral.ImageSpacing = 5
			Me.gvcGeneral.IntegratedScrolling = True
			Me.gvcGeneral.ItemXSpacing = 0
			Me.gvcGeneral.ItemYSpacing = 0
			Me.gvcGeneral.LargeImageList = Me.largeImageList
			Me.gvcGeneral.Location = New System.Drawing.Point(1, 567)
			Me.gvcGeneral.Name = "gvcGeneral"
			Me.gvcGeneral.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(254)))), (CInt((CByte(128)))), (CInt((CByte(62)))))
			Me.gvcGeneral.SelectedItem = 0
			Me.gvcGeneral.SelectedItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(111)))))
			Me.gvcGeneral.Size = New System.Drawing.Size(214, 1)
			Me.gvcGeneral.SmallImageList = Me.dockingImageList
			Me.gvcGeneral.SmallImageView = True
			Me.gvcGeneral.TabIndex = 35
			Me.gvcGeneral.Text = "groupViewControl1"
			' 
			' gvcComponents
			' 
			Me.gvcComponents.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(236)))), (CInt((CByte(255)))))
			Me.gvcComponents.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvcComponents.ButtonView = True
			Me.gvcComponents.FlatLook = True
			Me.gvcComponents.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gvcComponents.ForeColor = System.Drawing.Color.Black
			Me.gvcComponents.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 20, True, Nothing, "FileSystemWatcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 21, True, Nothing, "EventLog"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 22, True, Nothing, "DirectoryEntry"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 23, True, Nothing, "DirectorySearcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 24, True, Nothing, "MessageQueue")})
			Me.gvcComponents.HighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(238)))), (CInt((CByte(194)))))
			Me.gvcComponents.IntegratedScrolling = True
			Me.gvcComponents.ItemYSpacing = 1
			Me.gvcComponents.LargeImageList = Me.largeImageList
			Me.gvcComponents.Location = New System.Drawing.Point(1, 45)
			Me.gvcComponents.Name = "gvcComponents"
			Me.gvcComponents.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(254)))), (CInt((CByte(128)))), (CInt((CByte(62)))))
			Me.gvcComponents.SelectedItem = 0
			Me.gvcComponents.SelectedItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(111)))))
			Me.gvcComponents.Size = New System.Drawing.Size(214, 0)
			Me.gvcComponents.SmallImageList = Me.dockingImageList
			Me.gvcComponents.SmallImageView = True
			Me.gvcComponents.TabIndex = 33
			Me.gvcComponents.Text = "groupViewControl1"
			' 
			' gvcWindowsForms
			' 
			Me.gvcWindowsForms.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(236)))), (CInt((CByte(255)))))
			Me.gvcWindowsForms.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvcWindowsForms.ButtonView = True
			Me.gvcWindowsForms.FlatLook = True
			Me.gvcWindowsForms.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gvcWindowsForms.ForeColor = System.Drawing.Color.Black
			Me.gvcWindowsForms.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 10, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 11, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 12, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 13, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 14, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 15, True, Nothing, "CheckBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 16, True, Nothing, "RadioButton"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBox", 17, True, Nothing, "GroupBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("PictureBox", 18, True, Nothing, "PictureBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DataGrid", 19, True, Nothing, "DataGrid")})
			Me.gvcWindowsForms.HighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(238)))), (CInt((CByte(194)))))
			Me.gvcWindowsForms.IntegratedScrolling = True
			Me.gvcWindowsForms.ItemYSpacing = 1
			Me.gvcWindowsForms.LargeImageList = Me.largeImageList
			Me.gvcWindowsForms.Location = New System.Drawing.Point(1, 545)
			Me.gvcWindowsForms.Name = "gvcWindowsForms"
			Me.gvcWindowsForms.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(254)))), (CInt((CByte(128)))), (CInt((CByte(62)))))
			Me.gvcWindowsForms.SelectedItem = 0
			Me.gvcWindowsForms.SelectedItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(111)))))
			Me.gvcWindowsForms.SelectingItemColor = System.Drawing.SystemColors.Control
			Me.gvcWindowsForms.Size = New System.Drawing.Size(214, 0)
			Me.gvcWindowsForms.SmallImageList = Me.dockingImageList
			Me.gvcWindowsForms.SmallImageView = True
			Me.gvcWindowsForms.TabIndex = 34
			Me.gvcWindowsForms.Text = "groupViewControl1"
			' 
			' gvbSyncfusion
			' 
			Me.gvbSyncfusion.Client = Me.gvcSyncfusion
			Me.gvbSyncfusion.Text = "Syncfusion"
			' 
			' gvbComponents
			' 
			Me.gvbComponents.Client = Me.gvcComponents
			Me.gvbComponents.Text = "Components"
			' 
			' gvbWindowsForm
			' 
			Me.gvbWindowsForm.Client = Me.gvcWindowsForms
			Me.gvbWindowsForm.Text = "Windows Forms"
			' 
			' gvbGeneral
			' 
			Me.gvbGeneral.Client = Me.gvcGeneral
			Me.gvbGeneral.Text = "General"
			' 
			' ToolBoxView
			' 
			Me.Controls.Add(Me.panelToolBox)
			Me.Name = "ToolBoxView"
			Me.Size = New System.Drawing.Size(216, 568)
			Me.panelToolBox.ResumeLayout(False)
			CType(Me.gBToolBox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gBToolBox.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region


	End Class
End Namespace
