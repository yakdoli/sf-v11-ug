#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Drawing

Namespace OutlookDemo
	''' <summary>
	''' Summary description for ContactsPaneForm.
	''' </summary>
	Public Class ContactsPaneForm
		Inherits System.Windows.Forms.UserControl
		Friend gridGroupingControl1 As GridGroupingControl
		#Region "Declaration"

		Private ds As DataSet
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private popupMenu1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Public WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Public WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private popupMenusManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Public WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Public WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private visibleCols() As String

		#End Region

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

'			#Region "Settings"

			ds = New DataSet()
			ReadXml(ds, "data.xml")
			Me.gridGroupingControl1.DataSource = ds.Tables(0)
			Me.gridGroupingControl1.TableModel.Properties.Buttons3D = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TableModel.Properties.RowHeaders = False
			Me.gridGroupingControl1.TableModel.TableStyle.BackColor = SystemColors.HighlightText
			Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.BorderMargins.Top = 12
			Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellType = "Image"
			Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
			Me.gridGroupingControl1.DefaultAppearance.AnyRecordFieldCell.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.DefaultAppearance.AnyRecordFieldCell.Borders.Right = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.Appearance.GroupIndentCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableOptions.CaptionRowHeight = 30
			Me.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = 22
			Me.gridGroupingControl1.TableOptions.IndentWidth = 20
			Me.gridGroupingControl1.TableModel.TableStyle.Trimming = StringTrimming.EllipsisCharacter
			Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One
			Me.gridGroupingControl1.TableOptions.RecordRowHeight = 20

			Dim unboundCol As New GridColumnDescriptor("ImageCol", "", "", True, 30)
			unboundCol.Appearance.AnyRecordFieldCell.CellType = "Image"
			unboundCol.Appearance.AnyRecordFieldCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "contact.gif"))
			Me.gridGroupingControl1.TableDescriptor.Columns.Add(unboundCol)

			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ImageCol")
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ContactID")
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("CompanyName")
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ContactTitle")
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Address")
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("City")
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Phone")
			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
			AddHandler gridGroupingControl1.TableControl.MouseDown, AddressOf TableControl_MouseDown
			AddHandler gridGroupingControl1.GroupCollapsed, AddressOf gridGroupingControl1_GroupCollapsed
			AddHandler gridGroupingControl1.GroupExpanded, AddressOf gridGroupingControl1_GroupExpanded
			AddHandler gridGroupingControl1.TableControlCellClick, AddressOf gridGroupingControl1_TableControlCellClick
			AddHandler gridGroupingControl1.TableDescriptor.GroupedColumns.Changed, AddressOf GroupedColumns_Changed

			visibleCols = New String(Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Count - 1){}
			For i As Integer = 0 To visibleCols.Length - 1
				visibleCols(i) = Me.gridGroupingControl1.TableDescriptor.VisibleColumns(i).Name
			Next i

			Me.gridGroupingControl1.GridGroupDropArea.BackColor = Color.FromArgb(227, 239, 255)
			Me.gridGroupingControl1.GridGroupDropArea.ThemesEnabled = False
			Me.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(227, 239, 255)
			Me.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(227, 239, 255)
'			#End Region

'			#Region "Events Subscribed"
			AddHandler gridGroupingControl1.TableDescriptor.VisibleColumns.Changed, AddressOf VisibleColumns_Changed
			AddHandler gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo, AddressOf GridGroupDropArea_PrepareViewStyleInfo
			AddHandler gridGroupingControl1.TableControlCellDrawn, AddressOf gridGroupingControl1_TableControlCellDrawn
'			#End Region
		End Sub



		Public ReadOnly Property Grid() As GridGroupingControl
			Get
				Return Me.gridGroupingControl1
			End Get
		End Property

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ContactsPaneForm))
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.popupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(392, 256)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.HideCurrentCell
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "4.401.0.50"
			Me.popupMenusManager1.SetXPContextMenu(Me.gridGroupingControl1, Me.popupMenu1)
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = -1
			Me.parentBarItem1.ID = ""
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem3, Me.barItem5, Me.barItem6, Me.barItem7, Me.barItem4, Me.barItem2, Me.barItem8})
			Me.parentBarItem1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue
			Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() { 1, 6, 7})
			Me.parentBarItem1.ShowMnemonicUnderlinesAlways = True
			Me.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			' 
			' barItem1
			' 
			Me.barItem1.CategoryIndex = -1
			Me.barItem1.ID = "New Contact"
			Me.barItem1.ImageIndex = 0
			Me.barItem1.ImageList = Me.imageList1
			Me.barItem1.ShowMnemonicUnderlinesAlways = True
			Me.barItem1.Text = "New Contact"
'			Me.barItem1.Click += New System.EventHandler(Me.barItem1_Click)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' barItem3
			' 
			Me.barItem3.CategoryIndex = -1
			Me.barItem3.ID = "Group By"
			Me.barItem3.Text = "Group By"
'			Me.barItem3.Click += New System.EventHandler(Me.barItem3_Click)
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = -1
			Me.barItem5.ID = "Group By Box"
			Me.barItem5.ImageIndex = 3
			Me.barItem5.ImageList = Me.imageList1
			Me.barItem5.Text = "Group By Box"
'			Me.barItem5.Click += New System.EventHandler(Me.barItem5_Click)
			' 
			' barItem6
			' 
			Me.barItem6.CategoryIndex = -1
			Me.barItem6.ID = "Sort"
			Me.barItem6.ImageIndex = 4
			Me.barItem6.ImageList = Me.imageList1
			Me.barItem6.Text = "Sort"
'			Me.barItem6.Click += New System.EventHandler(Me.barItem6_Click)
			' 
			' barItem7
			' 
			Me.barItem7.CategoryIndex = -1
			Me.barItem7.ID = "Filter"
			Me.barItem7.ImageIndex = 5
			Me.barItem7.ImageList = Me.imageList1
			Me.barItem7.Text = "Filter"
'			Me.barItem7.Click += New System.EventHandler(Me.barItem7_Click)
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = -1
			Me.barItem4.ID = "Field Chooser"
			Me.barItem4.ImageIndex = 2
			Me.barItem4.ImageList = Me.imageList1
			Me.barItem4.Text = "Field Chooser"
'			Me.barItem4.Click += New System.EventHandler(Me.barItem4_Click)
			' 
			' barItem2
			' 
			Me.barItem2.CategoryIndex = -1
			Me.barItem2.ID = "Delete"
			Me.barItem2.ImageIndex = 1
			Me.barItem2.ImageList = Me.imageList1
			Me.barItem2.ShowMnemonicUnderlinesAlways = True
			Me.barItem2.Text = "Delete"
'			Me.barItem2.Click += New System.EventHandler(Me.barItem2_Click)
			' 
			' barItem8
			' 
			Me.barItem8.CategoryIndex = -1
			Me.barItem8.ID = "Customize Current View..."
			Me.barItem8.Text = "Customize Current View..."
'			Me.barItem8.Click += New System.EventHandler(Me.barItem8_Click)
			' 
			' popupMenu1
			' 
			Me.popupMenu1.ParentBarItem = Me.parentBarItem1
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.CategoryIndex = -1
			Me.parentBarItem2.ID = ""
			Me.parentBarItem2.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue
			' 
			' ContactsPaneForm
			' 
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.Name = "ContactsPaneForm"
			Me.Size = New System.Drawing.Size(392, 256)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "EventHandlers"

		Private Sub gridGroupingControl1_TableControlCellDrawn(ByVal sender As Object, ByVal e As GridTableControlDrawCellEventArgs)
			If e.Inner.RowIndex = 1 Then
				Dim rect1 As Rectangle = e.Inner.Bounds
				rect1.X = (rect1.X + rect1.Width) - 10
				rect1.Width = 10
				rect1.Y = (rect1.Y + rect1.Height) - 16
				rect1.Height = 10
				e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), New Point(rect1.X + 9, rect1.Y - 2), New Point(rect1.X + 9, rect1.Y + 12))
				e.Inner.Graphics.DrawLine(Pens.AliceBlue, New Point(rect1.X + 10, rect1.Y - 2), New Point(rect1.X + 10, rect1.Y + 12))
			End If
		End Sub


		Private Sub GridGroupDropArea_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
			e.Style.Font.Facename = "Segoe UI"
			e.Style.Font.Size = 8.25f
			If e.Style.Text.StartsWith("Drag a") Then
				e.Style.TextColor = Color.FromArgb(22, 74, 167)
			Else
				e.Style.TextColor = Color.FromArgb(141, 141, 141)
			End If
			e.Style.BackColor = Color.FromArgb(227, 239, 255)
			e.Style.Borders.All = New GridBorder(GridBorderStyle.None)
		End Sub

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			e.Style.Font.Facename = "Segoe UI"
			e.Style.Font.Size = 8.25f

			Dim lastRecIndex As Integer = Me.gridGroupingControl1.Table.Records.Count
			If e.TableCellIdentity.RowIndex = lastRecIndex + 1 Then
				e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.Black)
			End If

			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionCell Then
				e.Style.Themed = False
				e.Style.BackColor = Color.White
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.None)
				e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick)
				e.Style.TextColor = Color.FromArgb(Form1.r1, Form1.g1, Form1.b1)
				e.Style.Text = e.TableCellIdentity.DisplayElement.ParentGroup.Category.ToString()
				e.Style.TextMargins.Bottom = 8 - 3

				e.Style.VerticalAlignment = GridVerticalAlignment.Bottom
			End If
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionPlusMinusCell Then
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.None)
				e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick)
			End If
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupIndentCell Then
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.None)
				e.Style.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r1, Form1.g1, Form1.b1), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			End If
			If e.Style.CellType Is "ColumnHeaderCell" Then
				e.Style.Borders.All = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thin)
				e.Style.CellTipText = e.Style.Text
				e.Style.HorizontalAlignment = GridHorizontalAlignment.Left
				e.Style.Interior = New BrushInfo(GradientStyle.Vertical, Color.White, Color.FromArgb(Form1.r, Form1.g, Form1.b))
			End If
		End Sub

		Private Sub TableControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Right Then
				Dim row, col As Integer
				Me.gridGroupingControl1.TableControl.PointToRowCol(New Point(e.X, e.Y), row, col)
				Dim el As Element = Me.gridGroupingControl1.TableModel.GetDisplayElementAt(row)
				If el IsNot Nothing Then
					Me.barItem2.Enabled = True
				Else
					Me.barItem2.Enabled = False
				End If

			End If
		End Sub

		Private Sub gridGroupingControl1_GroupCollapsed(ByVal sender As Object, ByVal e As GroupEventArgs)
			Dim gcr As GridCaptionRow = CType(e.Group.Caption.CaptionRows(0), GridCaptionRow)
			gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"))
		End Sub

		Private Sub gridGroupingControl1_GroupExpanded(ByVal sender As Object, ByVal e As GroupEventArgs)
			Dim gcr As GridCaptionRow = CType(e.Group.Caption.CaptionRows(0), GridCaptionRow)
			gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
		End Sub

		Private Sub VisibleColumns_Changed(ByVal sender As Object, ByVal e As Syncfusion.Collections.ListPropertyChangedEventArgs)
			visibleCols = New String(Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Count - 1){}
			For i As Integer = 0 To visibleCols.Length - 1
				visibleCols(i) = Me.gridGroupingControl1.TableDescriptor.VisibleColumns(i).Name
			Next i
		End Sub

		Private Sub barItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click
			Dim dlg As New NewContactDialog()
			Dim result As DialogResult = dlg.ShowDialog()
			If result = DialogResult.OK Then
				Dim rw As DataRow = ds.Tables(0).NewRow()
				rw("ContactID") = dlg.ContactID
				rw("CompanyName") = dlg.CompName
				rw("ContactTitle") = dlg.ContactTitle
				rw("Address") = dlg.Address
				rw("City") = dlg.City
				rw("Phone") = dlg.Phone
				ds.Tables(0).Rows.Add(rw)
			End If
		End Sub

		Private Sub barItem3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem3.Click
			Dim dlg As New GroupByDialog(visibleCols)
			If dlg.ShowDialog() = DialogResult.OK Then
				For i As Integer = 0 To 2
					If dlg.GroupByCols(i).CompareTo("(none)") <> 0 Then
						Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(dlg.GroupByCols(i), dlg.Direction(i))
					End If
				Next i
				If dlg.View = "All expanded" Then
					Me.gridGroupingControl1.Table.ExpandAllGroups()
				ElseIf dlg.View = "All collapsed" Then
					Me.gridGroupingControl1.Table.CollapseAllGroups()
				End If
			End If
		End Sub

		Private Sub barItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem4.Click
			Dim hiddenCols(Me.gridGroupingControl1.TableDescriptor.Columns.Count - 1) As String
			Dim flag As Boolean = False
			Dim hiddenIndex As Integer = 0
			Dim temp As String
			For i As Integer = 0 To hiddenCols.Length - 1
				temp = Me.gridGroupingControl1.TableDescriptor.Columns(i).Name
				For j As Integer = 0 To visibleCols.Length - 1
					If visibleCols(j).CompareTo(temp) = 0 Then
						flag = True
						Exit For
					End If
				Next j
				If Not flag Then
					hiddenCols(hiddenIndex) = temp
					hiddenIndex += 1
				Else
					flag = False
				End If
			Next i
			Dim dlg As New FieldChooserDialog(hiddenCols, visibleCols)
			If dlg.ShowDialog() = DialogResult.OK Then
				Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ImageCol")
				For Each str As String In dlg.SelectedFields
					Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add(str)
				Next str
			End If
		End Sub

		Private Sub barItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem2.Click
			Dim rec As Record = Me.gridGroupingControl1.Table.CurrentRecord
			rec.Delete()
		End Sub

		Private Sub barItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem5.Click
			Me.gridGroupingControl1.ShowGroupDropArea = Not Me.gridGroupingControl1.ShowGroupDropArea
		End Sub

		Private Sub barItem6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem6.Click
			Dim dlg As New SortDialog(visibleCols)
			If dlg.ShowDialog() = DialogResult.OK Then
				For i As Integer = 0 To 2
					If dlg.SortByCols(i).CompareTo("(none)") <> 0 Then
						Me.gridGroupingControl1.TableDescriptor.SortedColumns.Add(dlg.SortByCols(i), dlg.Direction(i))
					End If
				Next i
			End If
		End Sub

		Private Sub barItem8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem8.Click
			Dim curView As New CurrentView(Me)
			curView.ShowDialog()
		End Sub

		Private Sub barItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem7.Click
			Dim dlg As New FilterDialog(Me.gridGroupingControl1)
			dlg.ShowDialog()
		End Sub

		Private Sub gridGroupingControl1_TableControlCellClick(ByVal sender As Object, ByVal e As GridTableControlCellClickEventArgs)
			If e.Inner.MouseEventArgs.Button = MouseButtons.Left Then
				If e.Inner.RowIndex > 1 Then
					Dim style As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex)
					If style.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionPlusMinusCell Then
						Dim curGrp As GridCaptionRow = TryCast(e.TableControl.Table.NestedDisplayElements(e.Inner.RowIndex), GridCaptionRow)
						curGrp.ParentGroup.IsExpanded = Not curGrp.ParentGroup.IsExpanded
					End If
				End If
			End If
		End Sub

		Private Sub GroupedColumns_Changed(ByVal sender As Object, ByVal e As Syncfusion.Collections.ListPropertyChangedEventArgs)
			If Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Count >= 1 Then
				For Each el As Element In Me.gridGroupingControl1.Table.DisplayElements
					If Not(TypeOf el Is GridRecordRow) Then
						Dim row As Integer = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el)
						If Me.gridGroupingControl1.Table.NestedDisplayElements(row).IsCaption() Then
							Dim crow As GridCaptionRow = CType(el, GridCaptionRow)
							Dim gp As Group = crow.ParentGroup
							If gp.IsExpanded Then
								crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
							Else
								crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"))
							End If
						End If
					End If
				Next el
			End If
		End Sub
		#End Region
	End Class
End Namespace
