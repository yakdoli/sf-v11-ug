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

Namespace ExcelLikeUI_2005
	Public Partial Class Form1
		Inherits RibbonForm
		Private Shared accCount As Integer = 1
		Public Sub New()
            InitializeComponent()
            AddHandler Me.FormClosing, AddressOf Form1_Closing

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			QuickItems()
			Me.toolStripFontfaceComboBox.SelectedIndex = 0
			Me.toolStripFontSizeComboBox.SelectedIndex = 3

			' Create a new child
			Dim workBook As WorkBook = New WorkBook()
			workBook.MdiParent = Me

            childWorkBookNumber = childWorkBookNumber + 1
            workBook.Text = "WorkBook " & childWorkBookNumber
			workBook.Show()

			AddHandler excelRibbon.Header.QuickItemAdded, AddressOf Header_QuickItemAdded
			AddHandler excelRibbon.Header.QuickItemRemoved, AddressOf Header_QuickItemRemoved

			For Each ctrl As Control In Me.Controls
				If TypeOf ctrl Is MdiClient Then
					Dim mdiClient As MdiClient = CType(ctrl, MdiClient)
					mdiClient.BackColor = Color.FromArgb(165, 195, 239)
				End If
			Next ctrl
        End Sub

        Private Sub Form1_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If Not workBook Is Nothing Then
                workBook.tabBarSplitterControl.Controls(1).Focus()
            End If
        End Sub
        ' Triggers when an item is added into quick access toolbar
        Private Sub Header_QuickItemAdded(ByVal sender As Object, ByVal e As ToolStripItemEventArgs)
            Me.superAccelerator1.SetAccelerator(e.Item, accCount.ToString())
            accCount += 1
        End Sub

        ' Triggers when an item is removed into quick access toolbar
        Private Sub Header_QuickItemRemoved(ByVal sender As Object, ByVal e As ToolStripItemEventArgs)
            accCount -= 1
        End Sub

        Private Sub QuickItems()
            Dim saveBtn As ToolStripButton = New ToolStripButton("Save")
            saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
            saveBtn.Image = Me.imageList1.Images(0)
            excelRibbon.Header.AddQuickItem(saveBtn)

            Dim undoBtn As ToolStripButton = New ToolStripButton("Undo")
            undoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
            undoBtn.Image = Me.imageList1.Images(1)
            excelRibbon.Header.AddQuickItem(undoBtn)

            Dim redoBtn As ToolStripButton = New ToolStripButton("Redo")
            redoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
            redoBtn.Image = Me.imageList1.Images(2)
            redoBtn.Enabled = False
            excelRibbon.Header.AddQuickItem(redoBtn)
        End Sub

        Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
            Me.gridAwareTextBoxItem2.MinWidth = Me.Width - (Me.gridAwareTextBoxItem1.MinWidth + 66)
        End Sub

        ' Triggers when double-clicking the menu button.
        Private Sub excelRibbon_MenuButtonDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles excelRibbon.MenuButtonDoubleClick
            Close()
        End Sub

        Private Sub toolStripButton81_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton81.Click
            Dim workBook As WorkBook = New WorkBook()
            workBook.MdiParent = Me

            childWorkBookNumber = childWorkBookNumber + 1
            workBook.Text = "WorkBook " & childWorkBookNumber
            workBook.Show()
        End Sub

        Private Sub toolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton6.Click
            Close()
        End Sub

        Private Sub toolStripButton89_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton89.Click
            Me.ActiveMdiChild.Close()
        End Sub
    End Class
End Namespace