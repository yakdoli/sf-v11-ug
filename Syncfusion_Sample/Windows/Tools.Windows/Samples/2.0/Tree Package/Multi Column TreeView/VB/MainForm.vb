Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System.IO
Imports Syncfusion.Windows.Forms.Tools.MultiColumnTreeView
Imports Syncfusion.Drawing

Namespace MultiColumnTreeViewDemo
	Partial Public Class MainForm
		Inherits Office2007Form
		Private treeColumnAdv1 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv
		Private treeColumnAdv2 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv
		Private treeColumnAdv3 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv

		Public Sub New()
			InitializeComponent()

			Dim root As New TreeNodeAdv()

            Dim drive As New DriveInfo(Environment.SystemDirectory)
            root.Text = drive.ToString()
			Me.multiColumnTreeView1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv() { root})

			treeColumnAdv1 = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv()
			treeColumnAdv2 = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv()
			treeColumnAdv3 = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv()

			treeColumnAdv1.HelpText = "Name"
			treeColumnAdv1.Highlighted = False
			treeColumnAdv1.Text = "Name"
			treeColumnAdv1.Width = 320
			treeColumnAdv1.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.LightBlue)
            treeColumnAdv1.AreaBackground = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.Color.LightBlue)
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle

			treeColumnAdv2.HelpText = "Full Path"
			treeColumnAdv2.Highlighted = False
			treeColumnAdv2.Text = "Full Path"
			treeColumnAdv2.Width = 260
            treeColumnAdv2.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.LightBlue)
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle

			treeColumnAdv3.HelpText = "Date Modified"
			treeColumnAdv3.Highlighted = False
			treeColumnAdv3.Text = "Date Modified"
			treeColumnAdv3.Width = 150
            treeColumnAdv3.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.LightBlue)
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle

			Me.multiColumnTreeView1.Columns.AddRange(New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv(){ treeColumnAdv1,treeColumnAdv2,treeColumnAdv3})

			AddHandler Load, AddressOf MultiColumnTreeViewDemo_Load
			AddHandler multiColumnTreeView1.BeforeExpand, AddressOf multiColumnTreeView1_BeforeExpand

		End Sub

		Private Sub MultiColumnTreeViewDemo_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.multiColumnTreeView1.Nodes(0).Expanded = True
		End Sub

		Private Sub multiColumnTreeView1_BeforeExpand(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventArgs)
			Try
				'Checking whether the Node has been  expanded atleast once
				If e.Node.ExpandedOnce Then
					Return
				End If

				Dim dir As DirectoryInfo = Nothing
				Dim subDir() As DirectoryInfo = Nothing
				If Me.multiColumnTreeView1.Nodes(0).Nodes.Count = 0 Then 'Root directory
					Dim drive As New DriveInfo(e.Node.Text)
					dir = drive.RootDirectory

					subDir = dir.GetDirectories()

				Else
					'Get the Path of the node and AddSeparatorAtEnd Property set to true
					Dim path As String = e.Node.GetPath("\")

					dir = New DirectoryInfo(path)
					subDir = dir.GetDirectories()
				End If

				If subDir IsNot Nothing Then
					For Each dirinfo As DirectoryInfo In subDir
						Dim subitem1 As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem()
						Dim subitem2 As New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem()

						subitem1.Text = dirinfo.FullName
						subitem1.HelpText = subitem1.Text

						subitem2.Text = dirinfo.LastWriteTime.ToString()
						subitem2.HelpText = subitem2.Text

						Dim node As New TreeNodeAdv(dirinfo.Name)

						node.SubItems.AddRange(New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem(){ subitem1,subitem2})
						e.Node.Nodes.Add(node)
					Next dirinfo
				End If
			Catch
			End Try
		End Sub

        Private Sub ColorPickerButton1_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerButton1.ColorSelected
            Me.treeColumnAdv3.HighlightBorderColor = Me.ColorPickerButton1.SelectedColor
        End Sub

        Private Sub ColorPickerButton2_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerButton2.ColorSelected
            Me.treeColumnAdv2.HighlightBorderColor = Me.ColorPickerButton2.SelectedColor
        End Sub

        Private Sub ColorPickerButton3_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerButton3.ColorSelected
            Me.treeColumnAdv1.HighlightBorderColor = Me.ColorPickerButton3.SelectedColor
        End Sub
    End Class
End Namespace