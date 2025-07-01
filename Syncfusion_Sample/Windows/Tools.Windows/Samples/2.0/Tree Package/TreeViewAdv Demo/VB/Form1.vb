#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace TreeViewAdvDemo
	#Region "Class Form1 Description"

	Public Class Form1
		Inherits Office2007Form
		#Region "Variable Declaration"
		Private WithEvents treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private stateImageList As System.Windows.Forms.ImageList
		Private leftImageList As System.Windows.Forms.ImageList
		Private rightImageList As System.Windows.Forms.ImageList
		Private WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
		Private WithEvents copyItem As System.Windows.Forms.MenuItem
		Private WithEvents cutItem As System.Windows.Forms.MenuItem
		Private WithEvents editItem As System.Windows.Forms.MenuItem
		Private splitter1 As System.Windows.Forms.Splitter
		Private pgGrid As System.Windows.Forms.PropertyGrid
		Private components As System.ComponentModel.IContainer
		#End Region

		#Region "Form Constructor Initialization and Disposing "
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim TreeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo
            Dim TreeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv8 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv9 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv10 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv11 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv12 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv13 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv14 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv15 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv16 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv17 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv18 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv19 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv20 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv21 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv
            Me.contextMenu1 = New System.Windows.Forms.ContextMenu
            Me.editItem = New System.Windows.Forms.MenuItem
            Me.copyItem = New System.Windows.Forms.MenuItem
            Me.cutItem = New System.Windows.Forms.MenuItem
            Me.leftImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.rightImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.stateImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.pgGrid = New System.Windows.Forms.PropertyGrid
            Me.splitter1 = New System.Windows.Forms.Splitter
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeViewAdv1
            '
            Me.treeViewAdv1.AllowDrop = True
            Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(241, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer)))
            TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo1.NoChildrenImgIndex = -1
            Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
            Me.treeViewAdv1.ContextMenu = Me.contextMenu1
            Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left
            '
            '
            '
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(732, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(50, 17)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.ItemHeight = 18
            Me.treeViewAdv1.LeftImageList = Me.leftImageList
            Me.treeViewAdv1.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.Name = "treeViewAdv1"
            Me.treeViewAdv1.NoChildrenImgIndex = -1
            TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.Expanded = True
            TreeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.Optioned = True
            TreeNodeAdv2.ShowOptionButton = True
            TreeNodeAdv2.Text = "Single"
            TreeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.ShowOptionButton = True
            TreeNodeAdv3.Text = "Married"
            TreeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.ShowOptionButton = True
            TreeNodeAdv4.Text = "Married with children"
            TreeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv2, TreeNodeAdv3, TreeNodeAdv4})
            TreeNodeAdv1.RightImageIndices = New Integer() {2}
            TreeNodeAdv1.Text = "Marital Status"
            TreeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.Expanded = True
            TreeNodeAdv5.InteractiveCheckBox = True
            TreeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.Optioned = True
            TreeNodeAdv6.ShowCheckBox = True
            TreeNodeAdv6.Text = "Hepatitis B"
            TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.ShowCheckBox = True
            TreeNodeAdv7.Text = "Tetanus"
            TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.ShowCheckBox = True
            TreeNodeAdv8.Text = "Polio "
            TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.ShowCheckBox = True
            TreeNodeAdv9.Text = "Measles"
            TreeNodeAdv5.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv6, TreeNodeAdv7, TreeNodeAdv8, TreeNodeAdv9})
            TreeNodeAdv5.RightImageIndices = New Integer() {6}
            TreeNodeAdv5.ShowCheckBox = True
            TreeNodeAdv5.Text = "Baby Vaccines"
            TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.Expanded = True
            TreeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.LeftImageIndices = New Integer() {0}
            TreeNodeAdv11.Optioned = True
            TreeNodeAdv11.Text = "Canada"
            TreeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.LeftImageIndices = New Integer() {1}
            TreeNodeAdv12.Text = "France"
            TreeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv13.EnsureDefaultOptionedChild = True
            TreeNodeAdv13.LeftImageIndices = New Integer() {2}
            TreeNodeAdv13.Text = "Germany"
            TreeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv14.EnsureDefaultOptionedChild = True
            TreeNodeAdv14.LeftImageIndices = New Integer() {3}
            TreeNodeAdv14.Text = "UK"
            TreeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv15.EnsureDefaultOptionedChild = True
            TreeNodeAdv15.LeftImageIndices = New Integer() {4}
            TreeNodeAdv15.Text = "USA"
            TreeNodeAdv10.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv11, TreeNodeAdv12, TreeNodeAdv13, TreeNodeAdv14, TreeNodeAdv15})
            TreeNodeAdv10.RightImageIndices = New Integer() {7}
            TreeNodeAdv10.Text = "Country Information"
            TreeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv16.EnsureDefaultOptionedChild = True
            TreeNodeAdv16.Expanded = True
            TreeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv17.EnsureDefaultOptionedChild = True
            TreeNodeAdv17.Optioned = True
            TreeNodeAdv17.RightImageIndices = New Integer() {4, 4, 4, 4}
            TreeNodeAdv17.Text = "Finding Nemo"
            TreeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv18.EnsureDefaultOptionedChild = True
            TreeNodeAdv18.RightImageIndices = New Integer() {4, 4, 4, 4}
            TreeNodeAdv18.Text = "Lord Of the Rings"
            TreeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv19.EnsureDefaultOptionedChild = True
            TreeNodeAdv19.RightImageIndices = New Integer() {4, 4}
            TreeNodeAdv19.Text = "Matrix Reloaded"
            TreeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv20.EnsureDefaultOptionedChild = True
            TreeNodeAdv20.RightImageIndices = New Integer() {4, 4, 4}
            TreeNodeAdv20.Text = "T3"
            TreeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv21.EnsureDefaultOptionedChild = True
            TreeNodeAdv21.RightImageIndices = New Integer() {4, 4, 4, 4}
            TreeNodeAdv21.Text = "Sea Biscuit"
            TreeNodeAdv16.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv17, TreeNodeAdv18, TreeNodeAdv19, TreeNodeAdv20, TreeNodeAdv21})
            TreeNodeAdv16.RightImageIndices = New Integer() {5}
            TreeNodeAdv16.Text = "Top 2003 Movies"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1, TreeNodeAdv5, TreeNodeAdv10, TreeNodeAdv16})
            Me.treeViewAdv1.PathSeparator = "/"
            Me.treeViewAdv1.RightImageList = Me.rightImageList
            Me.treeViewAdv1.Size = New System.Drawing.Size(234, 390)
            Me.treeViewAdv1.StateImageList = Me.stateImageList
            Me.treeViewAdv1.TabIndex = 0
            Me.treeViewAdv1.Text = "treeViewAdv1"
            '
            '
            '
            Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(642, 0)
            Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 17)
            Me.treeViewAdv1.ToolTipControl.TabIndex = 1
            Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
            '
            'contextMenu1
            '
            Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.editItem, Me.copyItem, Me.cutItem})
            '
            'editItem
            '
            Me.editItem.Index = 0
            Me.editItem.Text = "&Edit"
            '
            'copyItem
            '
            Me.copyItem.Index = 1
            Me.copyItem.Text = "&Copy"
            '
            'cutItem
            '
            Me.cutItem.Index = 2
            Me.cutItem.Text = "Cu&t"
            '
            'leftImageList
            '
            Me.leftImageList.ImageStream = CType(resources.GetObject("leftImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.leftImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.leftImageList.Images.SetKeyName(0, "")
            Me.leftImageList.Images.SetKeyName(1, "")
            Me.leftImageList.Images.SetKeyName(2, "")
            Me.leftImageList.Images.SetKeyName(3, "")
            Me.leftImageList.Images.SetKeyName(4, "")
            '
            'rightImageList
            '
            Me.rightImageList.ImageStream = CType(resources.GetObject("rightImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.rightImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.rightImageList.Images.SetKeyName(0, "")
            Me.rightImageList.Images.SetKeyName(1, "")
            Me.rightImageList.Images.SetKeyName(2, "smiley.ico")
            Me.rightImageList.Images.SetKeyName(3, "")
            Me.rightImageList.Images.SetKeyName(4, "")
            Me.rightImageList.Images.SetKeyName(5, "")
            Me.rightImageList.Images.SetKeyName(6, "")
            Me.rightImageList.Images.SetKeyName(7, "")
            '
            'stateImageList
            '
            Me.stateImageList.ImageStream = CType(resources.GetObject("stateImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.stateImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.stateImageList.Images.SetKeyName(0, "")
            Me.stateImageList.Images.SetKeyName(1, "")
            Me.stateImageList.Images.SetKeyName(2, "")
            '
            'pgGrid
            '
            Me.pgGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.pgGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pgGrid.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.pgGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.pgGrid.Location = New System.Drawing.Point(237, 0)
            Me.pgGrid.Name = "pgGrid"
            Me.pgGrid.SelectedObject = Me.treeViewAdv1
            Me.pgGrid.Size = New System.Drawing.Size(211, 390)
            Me.pgGrid.TabIndex = 2
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(234, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 390)
            Me.splitter1.TabIndex = 1
            Me.splitter1.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(448, 390)
            Me.Controls.Add(Me.pgGrid)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.treeViewAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TreeViewAdv Demo"
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Main Function Definition"

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "TreeViewAdv Event Handler"

		' This event will be called when either option button or checkbox are changed.
		Private Sub treeViewAdv1_AfterCheck(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvEventArgs) Handles treeViewAdv1.AfterCheck
			' Update the Marital Status icon based on the current selection
			If Me.treeViewAdv1.Nodes(0).Nodes(0).Optioned Then
				' If single selected
				Me.treeViewAdv1.Root.Nodes(0).RightImageIndices(0) = 2
			Else
				' if married or with children
				Me.treeViewAdv1.Root.Nodes(0).RightImageIndices(0) = 3
			End If
			Me.treeViewAdv1.Invalidate()
		End Sub


		#Region "EDITING"

		Private Sub treeViewAdv1_BeforeEdit(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvBeforeEditEventArgs) Handles treeViewAdv1.BeforeEdit
			' Let us prevent editing the top-level nodes.
			If e.Node.Parent Is Me.treeViewAdv1.Root Then
				e.Cancel = True
				MessageBox.Show("Node editing canceled for top-level nodes in the BeforeEdit event handler.")
			End If
		End Sub
		Private Sub treeViewAdv1_NodeEditorValidated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvEditEventArgs) Handles treeViewAdv1.NodeEditorValidated
			' Typically, you might have to update the bound data source, if any, with the new Label.
			e.Node.Text = e.Node.Text.ToUpper()
		End Sub
		Private Sub treeViewAdv1_NodeEditorValidating(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvCancelableEditEventArgs) Handles treeViewAdv1.NodeEditorValidating
			If e.Label.Length > 0 Then
				If e.Label.IndexOfAny(New Char(){"@"c, "."c, ","c, "!"c}) <> -1 Then
					' Cancel the label edit action, inform the user, and
'place the node in edit mode again.
					e.Cancel = True
					MessageBox.Show("Invalid tree node label." & Constants.vbLf & "The invalid characters are: '@','.', ',', '!'", "Node Label Edit")
				End If
			Else
				' Cancel the label edit action, inform the user, and
'place the node in edit mode again.
				e.Cancel = True
				MessageBox.Show("Invalid tree node label." & Constants.vbLf & "The label cannot be blank", "Node Label Edit")
				' To end editing mode, do this:
				' e.ContinueEditing = false;
			End If
		End Sub

		#End Region ' EDITING

		#End Region

		#Region "CONTEXTMENU"

		Private rightMouseDownNodeCached As TreeNodeAdv = Nothing
		Private Sub editItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles editItem.Click
			If Not Me.rightMouseDownNodeCached Is Nothing Then
				' You can also alternatively turn on F2 label editing for all nodes via 
				' the LabelEdit property of the tree.
				Me.treeViewAdv1.BeginEdit(Me.rightMouseDownNodeCached)
			End If
		End Sub

		Private Sub contextMenu1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles contextMenu1.Popup
			Me.rightMouseDownNodeCached = Me.treeViewAdv1.RMouseDownNode
			' This will be null if the user clicked in the empty portion of the tree.
			If Me.treeViewAdv1.RMouseDownNode Is Nothing Then
				Me.copyItem.Visible = False
				Me.cutItem.Visible = False
				Me.editItem.Visible = False
			Else
				Me.copyItem.Visible = True
				Me.cutItem.Visible = True
				Me.editItem.Visible = True
			End If
		End Sub

		Private Sub cutItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cutItem.Click
			MessageBox.Show("Not Implemented. Only Edit menu is implemented.")
		End Sub

		Private Sub copyItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles copyItem.Click
			MessageBox.Show("Not Implemented. Only Edit menu is implemented.")
		End Sub
		#End Region ' CONTEXTMENU

		#Region "Form Event Handler"

		Private Sub Form1_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles MyBase.Closing
			' End editing before the form closes
			Me.treeViewAdv1.EndEdit(True)
		End Sub
		#End Region


	End Class

	#End Region 
End Namespace
