Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Design
Imports Syncfusion.Collections
Imports Syncfusion.ComponentModel
Imports System.Drawing.Design
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Runtime.Serialization
Imports System.Reflection
Imports Syncfusion.Runtime.Serialization

Imports Syncfusion.Windows.Forms.Grid

Imports Syncfusion.Windows.Forms.Tools

Namespace TabBarSplitterDemo
	Partial Public Class Form1
		Inherits RibbonForm
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
		End Sub
		#End Region

		#Region "Helper Methods"
		Private Sub QuickItems()
			Dim saveBtn As New ToolStripButton("Save")
			saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
			saveBtn.Image = Me.imageList1.Images(0)
			ribbonControlAdv1.Header.AddQuickItem(saveBtn)

			Dim undoBtn As New ToolStripButton("Undo")
			undoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
			undoBtn.Image = Me.imageList1.Images(1)
			ribbonControlAdv1.Header.AddQuickItem(undoBtn)

			Dim redoBtn As New ToolStripButton("Redo")
			redoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
			redoBtn.Image = Me.imageList1.Images(2)
			redoBtn.Enabled = False
			ribbonControlAdv1.Header.AddQuickItem(redoBtn)
		End Sub

		Private Function CreateGridControl() As GridControl
			Dim gridControl1 As GridControl = New Syncfusion.Windows.Forms.Grid.GridControl()

			gridControl1.ColCount = 20
			gridControl1.RowCount = 100

			Return gridControl1
		End Function

		Private Sub AddTabBarPage()
			Dim page As New TabBarPage("Sheet" & (Me.tabBarSplitterControl1.TabBarPages.Count + 1))

			Dim grid As GridControl = CreateGridControl()
			page.Controls.Add(grid)

			grid.ThemesEnabled = True
			grid.GridVisualStyles = GridVisualStyles.Office2007Blue
			grid.Dock = DockStyle.Fill

			Me.tabBarSplitterControl1.TabBarPages.Add(page)
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub toolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton6.Click
			Close()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			QuickItems()

			For i As Integer = 0 To 2
				AddTabBarPage()
			Next i
		End Sub

		Private Sub toolStripCheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripCheckBox1.CheckedChanged
			Me.tabBarSplitterControl1.ShowHorizontalScrollBar = Not Me.toolStripCheckBox1.Checked
		End Sub

		Private Sub toolStripCheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripCheckBox2.CheckedChanged
			Me.tabBarSplitterControl1.ShowVerticalScrollBar = Not Me.toolStripCheckBox2.Checked
		End Sub

		Private Sub toolStripButton10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton10.Click
			AddTabBarPage()
		End Sub

		Private Sub toolStripButton11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton11.Click
			If Me.tabBarSplitterControl1.TabBarPages.Count > 1 Then
				Me.tabBarSplitterControl1.HidePage(Me.tabBarSplitterControl1.ActivePage)
			End If
		End Sub

		Private Sub toolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.Click
			If Me.tabBarSplitterControl1.TabBarPages.Count > 1 Then
				Me.tabBarSplitterControl1.TabBarPages.Remove(Me.tabBarSplitterControl1.ActivePage)
			Else
				MessageBoxAdv.Show("One sheet alone exists! No more sheets to remove!", "Warning!")
			End If
		End Sub

		Private Sub toolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripComboBox1.SelectedIndexChanged
			Select Case Me.toolStripComboBox1.SelectedIndex
				Case 0
					Me.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Blue
					Me.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
				Case 1
					Me.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Black
					Me.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
				Case 2
					Me.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Silver
					Me.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
			End Select


		End Sub
		#End Region
	End Class
End Namespace