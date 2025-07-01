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
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Drawing
Imports System.Diagnostics

Namespace TreeViewAdvLoadOnDemand
	#Region "Class Form1 Description"

	Public Class Form1
		Inherits Office2007Form
		#Region "Variable Declaration"
		Private WithEvents treeViewAdv2 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private imageList1 As System.Windows.Forms.ImageList
		Private listBox1 As System.Windows.Forms.ListBox
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private splitter1 As System.Windows.Forms.Splitter
		Private components As System.ComponentModel.IContainer
		#End Region

		#Region "Form Constructor Initialization and Disposing"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
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
			Me.components = New System.ComponentModel.Container()
			Dim treeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
			Dim treeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.treeViewAdv2 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			CType(Me.treeViewAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeViewAdv2
			' 
			Me.treeViewAdv2.AddSeparatorAtEnd = True
			Me.treeViewAdv2.AllowDrop = True
			Me.treeViewAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(245))))))
			Me.treeViewAdv2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(246)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(245)))))))
			treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
			treeNodeAdvStyleInfo1.ShowPlusMinus = True
			treeNodeAdvStyleInfo1.ThemesEnabled = True
			Me.treeViewAdv2.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() { New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)})
			Me.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner
			Me.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Left
			Me.treeViewAdv2.DragOnText = False
			Me.treeViewAdv2.Font = New System.Drawing.Font("Verdana", 8F)
			' 
			' 
			' 
			Me.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv2.HelpTextControl.Location = New System.Drawing.Point(732, 0)
			Me.treeViewAdv2.HelpTextControl.Name = "helpText"
			Me.treeViewAdv2.HelpTextControl.Size = New System.Drawing.Size(50, 17)
			Me.treeViewAdv2.HelpTextControl.TabIndex = 0
			Me.treeViewAdv2.HelpTextControl.Text = "help text"
			Me.treeViewAdv2.HideSelection = False
			Me.treeViewAdv2.IgnoreThemeBackground = True
			Me.treeViewAdv2.Indent = 20
			Me.treeViewAdv2.LabelEdit = True
			Me.treeViewAdv2.LeftImageList = Me.imageList1
			Me.treeViewAdv2.LineColor = System.Drawing.Color.Transparent
			Me.treeViewAdv2.LoadOnDemand = True
			Me.treeViewAdv2.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv2.Name = "treeViewAdv2"
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv1.EnsureDefaultOptionedChild = True
			treeNodeAdv1.Height = 16
			treeNodeAdv1.ShowPlusOnExpand = True
			treeNodeAdv1.Text = "C:"
			Me.treeViewAdv2.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv1})
			Me.treeViewAdv2.Office2007ScrollBars = True
			Me.treeViewAdv2.OwnerDrawNodes = True
			Me.treeViewAdv2.PathSeparator = "/"
			Me.treeViewAdv2.SelectionMode = Syncfusion.Windows.Forms.Tools.TreeSelectionMode.MultiSelectSameLevel
			Me.treeViewAdv2.Size = New System.Drawing.Size(232, 550)
			Me.treeViewAdv2.StateImageList = Me.imageList1
			Me.treeViewAdv2.TabIndex = 2
			Me.treeViewAdv2.ThemesEnabled = True
			' 
			' 
			' 
			Me.treeViewAdv2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
			Me.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv2.ToolTipControl.Location = New System.Drawing.Point(642, 0)
			Me.treeViewAdv2.ToolTipControl.Name = "toolTip"
			Me.treeViewAdv2.ToolTipControl.Size = New System.Drawing.Size(41, 17)
			Me.treeViewAdv2.ToolTipControl.TabIndex = 1
			Me.treeViewAdv2.ToolTipControl.Text = "toolTip"
'			Me.treeViewAdv2.AfterSelect += New System.EventHandler(Me.treeViewAdv2_AfterSelect);
'			Me.treeViewAdv2.BeforeExpand += New Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(Me.treeViewAdv2_BeforeExpand);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' listBox1
			' 
			Me.listBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(245))))))
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.HorizontalScrollbar = True
			Me.listBox1.Location = New System.Drawing.Point(238, 0)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.ScrollAlwaysVisible = True
			Me.listBox1.Size = New System.Drawing.Size(252, 550)
			Me.listBox1.TabIndex = 0
			' 
			' splitter1
			' 
			Me.splitter1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(206))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(246))))))
			Me.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.splitter1.Location = New System.Drawing.Point(232, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 550)
			Me.splitter1.TabIndex = 3
			Me.splitter1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.AutoScroll = True
			Me.ClientSize = New System.Drawing.Size(490, 550)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.treeViewAdv2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Load On Demand"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeViewAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Main Function Definition"

		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "TreeViewAdv Event Handler"

		#Region "Load the child nodes "

		'This Event will be fired  before a node is expanded
		Private Sub treeViewAdv2_BeforeExpand(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs) Handles treeViewAdv2.BeforeExpand
            Try

                'Checking Whether the Node has been  expanded atleast once
                If e.Node.ExpandedOnce Then
                    Return
                End If

                'Get the Path of the node and AddSeparatorAtEnd Property set to true
                Dim path As String = e.Node.GetPath("\")

                'Get an Array of Directories from the current directory path
                Dim dirs As ArrayList = New ArrayList(Directory.GetDirectories(path))

                'Add the Directories as a node in TreeViewAdv
                For i As Integer = 0 To dirs.Count - 1
                    Dim dir As String = CStr(dirs(i))
                    Dim lastIndex As Integer = dir.LastIndexOf("\") + 1
                    Dim node As TreeNodeAdv = New TreeNodeAdv(dir.Substring(lastIndex))
                    e.Node.Nodes.Add(node)
                Next i
            Catch ex As Exception
            End Try

        End Sub
		#End Region

		#Region "Fill the listbox on the right with the directories and files below the selected node."
		' This Event will be fired  after a node is selected

		Private Sub treeViewAdv2_AfterSelect(ByVal sender As Object, ByVal e As EventArgs) Handles treeViewAdv2.AfterSelect
			If Not Me.treeViewAdv2.SelectedNode Is Nothing Then
				Dim bounds As Rectangle = Me.treeViewAdv2.SelectedNode.Bounds

				Me.listBox1.Items.Clear()
				Try
					Me.listBox1.Items.AddRange(Directory.GetFiles(Me.treeViewAdv2.SelectedNode.GetPath("\")))
				Catch ' Exception will be thrown in the user renamed the dirs and then selects them. Lose the exception.
				End Try
			End If
		End Sub
		#End Region

		#End Region

		#Region "Form Event Handler"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'Expand the Fist Node in the TreeViewAdv Control
			Me.treeViewAdv2.Nodes(0).Expanded = True
		End Sub
		#End Region


	End Class
	#End Region
End Namespace
