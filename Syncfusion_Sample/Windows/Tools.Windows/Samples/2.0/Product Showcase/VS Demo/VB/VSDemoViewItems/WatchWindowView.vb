Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for WatchWindowView.
	''' </summary>
	Public Class WatchWindowView : Inherits System.Windows.Forms.UserControl
		Private watchListView As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private columnHeader3 As System.Windows.Forms.ColumnHeader
		Private imageList1 As System.Windows.Forms.ImageList
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
			Dim listViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "Name"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "this.listBox1.Text", "Name"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WatchWindowView))
			Me.watchListView = New System.Windows.Forms.ListView()
			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.SuspendLayout()
			' 
			' watchListView
			' 
			Me.watchListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
			Me.watchListView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.watchListView.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.watchListView.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2})
			Me.watchListView.Location = New System.Drawing.Point(0, 0)
			Me.watchListView.Name = "watchListView"
			Me.watchListView.Size = New System.Drawing.Size(744, 150)
			Me.watchListView.SmallImageList = Me.imageList1
			Me.watchListView.TabIndex = 0
			Me.watchListView.UseCompatibleStateImageBehavior = False
			Me.watchListView.View = System.Windows.Forms.View.Details
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "Name"
			Me.columnHeader1.Width = 273
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Value"
			Me.columnHeader2.Width = 191
			' 
			' columnHeader3
			' 
			Me.columnHeader3.Text = "Type"
			Me.columnHeader3.Width = 270
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			' 
			' WatchWindowView
			' 
			Me.Controls.Add(Me.watchListView)
			Me.Name = "WatchWindowView"
			Me.Size = New System.Drawing.Size(744, 150)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
