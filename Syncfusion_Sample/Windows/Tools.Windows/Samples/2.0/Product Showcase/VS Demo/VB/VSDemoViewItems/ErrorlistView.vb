Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for Errorlist.
	''' </summary>
	Public Class ErrorlistView : Inherits System.Windows.Forms.UserControl
		Private panelErrorList As System.Windows.Forms.Panel
		Private WithEvents errorsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents warningsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents messagesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Public errorlistToolBar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private imageList1 As System.Windows.Forms.ImageList
		Private dwTaskListView As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private columnHeader3 As System.Windows.Forms.ColumnHeader
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call
			Me.errorlistToolBar.Bar.BeginGroupAt(Me.warningsBarItem)
			Me.errorlistToolBar.Bar.BeginGroupAt(Me.messagesBarItem)
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
			Dim listViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "1", "", "TODO: Add any constructor code after InitializeComponent call"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorlistView))
			Me.panelErrorList = New System.Windows.Forms.Panel()
			Me.dwTaskListView = New System.Windows.Forms.ListView()
			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
			Me.errorlistToolBar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.errorsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.warningsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.messagesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.panelErrorList.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelErrorList
			' 
			Me.panelErrorList.Controls.Add(Me.dwTaskListView)
			Me.panelErrorList.Controls.Add(Me.errorlistToolBar)
			Me.panelErrorList.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelErrorList.Location = New System.Drawing.Point(0, 0)
			Me.panelErrorList.Name = "panelErrorList"
			Me.panelErrorList.Size = New System.Drawing.Size(680, 190)
			Me.panelErrorList.TabIndex = 0
			' 
			' dwTaskListView
			' 
			Me.dwTaskListView.BackColor = System.Drawing.Color.White
			Me.dwTaskListView.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.dwTaskListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
			Me.dwTaskListView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dwTaskListView.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.dwTaskListView.FullRowSelect = True
			Me.dwTaskListView.GridLines = True
			listViewItem2.Checked = True
			listViewItem2.StateImageIndex = 1
			Me.dwTaskListView.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem2})
			Me.dwTaskListView.Location = New System.Drawing.Point(0, 28)
			Me.dwTaskListView.MultiSelect = False
			Me.dwTaskListView.Name = "dwTaskListView"
			Me.dwTaskListView.Size = New System.Drawing.Size(680, 162)
			Me.dwTaskListView.TabIndex = 28
			Me.dwTaskListView.UseCompatibleStateImageBehavior = False
			Me.dwTaskListView.View = System.Windows.Forms.View.Details
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "!"
			Me.columnHeader1.Width = 20
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = ""
			Me.columnHeader2.Width = 22
			' 
			' columnHeader3
			' 
			Me.columnHeader3.Text = "Description"
			Me.columnHeader3.Width = 1000
			' 
			' errorlistToolBar
			' 
			Me.errorlistToolBar.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.errorlistToolBar.Bar.BarName = ""
			Me.errorlistToolBar.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.errorsBarItem, Me.warningsBarItem, Me.messagesBarItem})
			Me.errorlistToolBar.Bar.Manager = Nothing
			Me.errorlistToolBar.Dock = System.Windows.Forms.DockStyle.Top
			Me.errorlistToolBar.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.errorlistToolBar.Location = New System.Drawing.Point(0, 0)
			Me.errorlistToolBar.Name = "errorlistToolBar"
			Me.errorlistToolBar.Size = New System.Drawing.Size(680, 28)
			Me.errorlistToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.errorlistToolBar.TabIndex = 0
			' 
			' errorsBarItem
			' 
			Me.errorsBarItem.Checked = True
			Me.errorsBarItem.ID = "Errors"
			Me.errorsBarItem.ImageIndex = 0
			Me.errorsBarItem.ImageList = Me.imageList1
			Me.errorsBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
			Me.errorsBarItem.Text = "Errors"
'			Me.errorsBarItem.Click += New System.EventHandler(Me.BarItem_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' warningsBarItem
			' 
			Me.warningsBarItem.ID = "Warnings"
			Me.warningsBarItem.ImageIndex = 1
			Me.warningsBarItem.ImageList = Me.imageList1
			Me.warningsBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
			Me.warningsBarItem.Text = "Warnings"
'			Me.warningsBarItem.Click += New System.EventHandler(Me.BarItem_Click);
			' 
			' messagesBarItem
			' 
			Me.messagesBarItem.ID = "Messages"
			Me.messagesBarItem.ImageIndex = 2
			Me.messagesBarItem.ImageList = Me.imageList1
			Me.messagesBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
			Me.messagesBarItem.Text = "Messages"
'			Me.messagesBarItem.Click += New System.EventHandler(Me.BarItem_Click);
			' 
			' ErrorlistView
			' 
			Me.Controls.Add(Me.panelErrorList)
			Me.Name = "ErrorlistView"
			Me.Size = New System.Drawing.Size(680, 190)
			Me.panelErrorList.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub BarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles errorsBarItem.Click, warningsBarItem.Click, messagesBarItem.Click
			Dim item As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem = CType(IIf(TypeOf sender Is Syncfusion.Windows.Forms.Tools.XPMenus.BarItem, sender, Nothing), Syncfusion.Windows.Forms.Tools.XPMenus.BarItem)
			item.Checked = Not item.Checked
		End Sub
	End Class
End Namespace
