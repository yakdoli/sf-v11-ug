Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Text.RegularExpressions


Imports Syncfusion.XlsIO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.GridExcelConverter
Imports Syncfusion.Windows.Forms.Grid


Namespace ExcelLikeUI_2005
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class WorkBook
        Inherits Office2007Form
		Public WithEvents tabBarSplitterControl As Syncfusion.Windows.Forms.TabBarSplitterControl
		Public gridAwareTextBox1 As Syncfusion.Windows.Forms.Grid.GridAwareTextBox
		Public gridAwareTextBox2 As Syncfusion.Windows.Forms.Grid.GridAwareTextBox
		Private parentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private insertRowBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private tbscCMStrip As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
		Private gridCMStrip As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
		Private WithEvents insertSheetToolStripMenuItem As ToolStripMenuItem
		Private WithEvents deleteSheetToolStripMenuItem As ToolStripMenuItem
		Private WithEvents cutToolStripMenuItem As ToolStripMenuItem
		Private WithEvents copyToolStripMenuItem As ToolStripMenuItem
		Private WithEvents pasteToolStripMenuItem As ToolStripMenuItem
		Private WithEvents deleteToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents hyperlinkToolStripMenuItem As ToolStripMenuItem
		Private WithEvents showDialogToolStripMenuItem As ToolStripMenuItem
		Private WithEvents unhideItem As ToolStripMenuItem
		Private components As System.ComponentModel.IContainer = Nothing

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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkBook))
			Me.tabBarSplitterControl = New Syncfusion.Windows.Forms.TabBarSplitterControl()
			Me.gridAwareTextBox1 = New Syncfusion.Windows.Forms.Grid.GridAwareTextBox()
			Me.gridAwareTextBox2 = New Syncfusion.Windows.Forms.Grid.GridAwareTextBox()
			Me.parentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.insertRowBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.tbscCMStrip = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
			Me.insertSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.deleteSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.showDialogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.gridCMStrip = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
			Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.hyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.unhideItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.tabBarSplitterControl.SuspendLayout()
			Me.tbscCMStrip.SuspendLayout()
			Me.gridCMStrip.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tabBarSplitterControl
			' 
			Me.tabBarSplitterControl.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(219))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(249))))))
            Me.tabBarSplitterControl.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.tabBarSplitterControl.Controls.Add(Me.gridAwareTextBox1)
			Me.tabBarSplitterControl.Controls.Add(Me.gridAwareTextBox2)
			Me.tabBarSplitterControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabBarSplitterControl.EnabledColor = System.Drawing.SystemColors.WindowText
			Me.tabBarSplitterControl.Location = New System.Drawing.Point(0, 0)
			Me.tabBarSplitterControl.Name = "tabBarSplitterControl"
            Me.tabBarSplitterControl.Style = TabBarSplitterStyle.Office2007
            Me.tabBarSplitterControl.Office2007ColorScheme = Office2007Theme.Blue
			Me.tabBarSplitterControl.Size = New System.Drawing.Size(776, 502)
			Me.tabBarSplitterControl.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.tabBarSplitterControl.TabIndex = 0
			Me.tabBarSplitterControl.Text = "tabBarSplitterControl1"
			Me.tabBarSplitterControl.ThemesEnabled = False
            Me.tabBarSplitterControl.Office2007ScrollBars = True
            Me.tabBarSplitterControl.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007
'			Me.tabBarSplitterControl.PaneCreated += New Syncfusion.Windows.Forms.SplitterPaneEventHandler(Me.tabBarSplitterControl_PaneCreated);
'			Me.tabBarSplitterControl.ActivePageChanging += New System.Windows.Forms.ControlEventHandler(Me.tabBarSplitterControl_ActivePageChanging);
			' 
			' gridAwareTextBox1
			' 
			Me.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window
			Me.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window
			Me.gridAwareTextBox1.Location = New System.Drawing.Point(-100, -100)
			Me.gridAwareTextBox1.Name = "gridAwareTextBox1"
			Me.gridAwareTextBox1.Size = New System.Drawing.Size(100, 20)
			Me.gridAwareTextBox1.TabIndex = 1
			' 
			' gridAwareTextBox2
			' 
			Me.gridAwareTextBox2.DisabledBackColor = System.Drawing.SystemColors.Window
			Me.gridAwareTextBox2.EnabledBackColor = System.Drawing.SystemColors.Window
			Me.gridAwareTextBox2.Location = New System.Drawing.Point(-100, -100)
			Me.gridAwareTextBox2.Name = "gridAwareTextBox2"
			Me.gridAwareTextBox2.Size = New System.Drawing.Size(100, 20)
			Me.gridAwareTextBox2.TabIndex = 2
			' 
			' parentBarItem
			' 
			Me.parentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.insertRowBarItem})
			' 
			' insertRowBarItem
			' 
			Me.insertRowBarItem.ID = "insertRowBarItem"
			Me.insertRowBarItem.Text = "Insert Row"
			' 
			' tbscCMStrip
			' 
			Me.tbscCMStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.insertSheetToolStripMenuItem, Me.deleteSheetToolStripMenuItem, Me.showDialogToolStripMenuItem, Me.unhideItem})
			Me.tbscCMStrip.Name = "tbscCMStrip"
			Me.tbscCMStrip.Size = New System.Drawing.Size(153, 114)
			' 
			' insertSheetToolStripMenuItem
			' 
			Me.insertSheetToolStripMenuItem.Name = "insertSheetToolStripMenuItem"
			Me.insertSheetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.insertSheetToolStripMenuItem.Text = "Add Sheet"
            AddHandler Me.insertSheetToolStripMenuItem.Click, AddressOf Me.insertSheetMenuItem_Click
			' 
			' deleteSheetToolStripMenuItem
			' 
			Me.deleteSheetToolStripMenuItem.Name = "deleteSheetToolStripMenuItem"
			Me.deleteSheetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.deleteSheetToolStripMenuItem.Text = "Delete Sheet"
            AddHandler Me.deleteSheetToolStripMenuItem.Click, AddressOf Me.deleteSheetMenuItem_Click
			' 
			' showDialogToolStripMenuItem
			' 
			Me.showDialogToolStripMenuItem.Name = "showDialogToolStripMenuItem"
			Me.showDialogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.showDialogToolStripMenuItem.Text = "Hide"
            AddHandler Me.showDialogToolStripMenuItem.Click, AddressOf Me.hideItem_Click
			' 
			' gridCMStrip
			' 
			Me.gridCMStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.deleteToolStripMenuItem, Me.toolStripSeparator1, Me.hyperlinkToolStripMenuItem})
			Me.gridCMStrip.Name = "gridCMStrip"
			Me.gridCMStrip.Size = New System.Drawing.Size(130, 120)
			' 
			' cutToolStripMenuItem
			' 
			Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
			Me.cutToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
			Me.cutToolStripMenuItem.Text = "Cut"
'			Me.cutToolStripMenuItem.Click += New System.EventHandler(Me.cutMenuItem_Click);
			' 
			' copyToolStripMenuItem
			' 
			Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
			Me.copyToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
			Me.copyToolStripMenuItem.Text = "Copy"
'			Me.copyToolStripMenuItem.Click += New System.EventHandler(Me.copyMenuItem_Click);
			' 
			' pasteToolStripMenuItem
			' 
			Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
			Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
			Me.pasteToolStripMenuItem.Text = "Paste"
            AddHandler Me.pasteToolStripMenuItem.Click, AddressOf Me.pasteMenuItem_Click
			' 
			' deleteToolStripMenuItem
			' 
			Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
			Me.deleteToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
			Me.deleteToolStripMenuItem.Text = "Delete"
            AddHandler Me.deleteToolStripMenuItem.Click, AddressOf Me.deleteMenuItem_Click_1
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(126, 6)
			' 
			' hyperlinkToolStripMenuItem
			' 
			Me.hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem"
			Me.hyperlinkToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
			Me.hyperlinkToolStripMenuItem.Text = "Hyperlink"
            AddHandler Me.hyperlinkToolStripMenuItem.Click, AddressOf Me.HyperLinkMenuItem_Click
			' 
			' unhideItem
			' 
			Me.unhideItem.Name = "unhideItem"
			Me.unhideItem.Size = New System.Drawing.Size(152, 22)
			Me.unhideItem.Text = "Unhide..."
            AddHandler Me.unhideItem.Click, AddressOf Me.unhideItem_Click
			' 
			' WorkBook
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(776, 502)
			Me.Controls.Add(Me.tabBarSplitterControl)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "WorkBook"
			Me.Text = "Form2"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            AddHandler Me.Deactivate, AddressOf Me.WorkBook_Deactivate
            AddHandler Me.Activated, AddressOf Me.WorkBook_Activated
            AddHandler Me.Load, AddressOf Me.Form1_Load
			Me.tabBarSplitterControl.ResumeLayout(False)
			Me.tabBarSplitterControl.PerformLayout()
			Me.tbscCMStrip.ResumeLayout(False)
			Me.gridCMStrip.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Friend HiddenSheets As ArrayList = New ArrayList()

		Private Sub MyInit()
'			#Region "Initial Settings"
			Me.tabBarSplitterControl.SuspendLayout()
			Me.SuspendLayout()

			For i As Integer = 0 To 2
				Dim tabBarPage As TabBarPage = New TabBarPage()
				tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249)
				Dim _grid As GridControl
				Dim model As GridModel= New GridModel()
				SampleGrid.SetupGridModel(model)
				_grid = New SampleGrid(model)
				' 
				' _grid
				' 
				_grid.ContextMenuStrip = gridCMStrip
				_grid.Location = New System.Drawing.Point(0, 0)
				_grid.Name = String.Format("gridControl{0}",i+1)
				_grid.SmartSizeBox = False
				_grid.Text = String.Format("gridControl{0}",i+1)
				' 
				' tabBarPage
				' 
				tabBarPage.Controls.Add(_grid)
				tabBarPage.Location = New System.Drawing.Point(0, 0)
				tabBarPage.Name = String.Format("tabBarPage{0}",i+1)
				tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both
				tabBarPage.Text = String.Format("Sheet{0}",i+1)
				tabBarPage.ThemesEnabled = True
				Me.tabBarSplitterControl.TabBarPages.Add(tabBarPage)
			Next i
			Me.tabBarSplitterControl.ResumeLayout(True)
			Me.ResumeLayout(True)
'			#End Region
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.MyInit()

			Me.tabBarSplitterControl.Bar.ContextMenuStrip = tbscCMStrip
			AddHandler tabBarSplitterControl.ActivePageChanged, AddressOf tabBarSplitterControl_ActivePageChanged
		End Sub

		Friend _grid As GridControl = Nothing
		Private Sub tabBarSplitterControl_ActivePageChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles tabBarSplitterControl.ActivePageChanging
			If Not e.Control Is Nothing Then
				For Each control As Control In e.Control.Controls
					If TypeOf control Is GridControl Then
						Me._grid = TryCast(control, GridControl)
						Exit For
					End If
				Next control
			End If
			If Not Me._grid Is Nothing Then
				Me.gridAwareTextBox1.WireGrid(Me._grid)
                Me.gridAwareTextBox2.WireGrid(Me._grid)
                Dim frm As Form1 = TryCast(Me.MdiParent, Form1)
                frm.gridAwareTextBoxItem1.WireGridAwareTextBox(Me.gridAwareTextBox1, Me._grid, True)
                frm.gridAwareTextBoxItem2.WireGridAwareTextBox(Me.gridAwareTextBox2, Me._grid, False)
				AddHandler _grid.VisibleChanged, AddressOf _grid_VisibleChanged
			End If
		End Sub

		Private Sub tabBarSplitterControl_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles tabBarSplitterControl.PaneCreated
			Me._grid = CType(e.Control, GridControl)
			_grid.ContextMenuStrip = gridCMStrip
			Me.gridAwareTextBox1.WireGrid(Me._grid)
            Me.gridAwareTextBox2.WireGrid(Me._grid)
            Dim frm As Form1 = TryCast(Me.MdiParent, Form1)
            frm.gridAwareTextBoxItem1.WireGridAwareTextBox(Me.gridAwareTextBox1, Me._grid, True)
            frm.gridAwareTextBoxItem2.WireGridAwareTextBox(Me.gridAwareTextBox2, Me._grid, False)
			AddHandler _grid.VisibleChanged, AddressOf _grid_VisibleChanged
		End Sub

		#Region "Menu Handlers"
		Private Sub insertSheetMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles insertSheetToolStripMenuItem.Click
			Dim tabBarPage As TabBarPage = New TabBarPage()
			tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249)
			Dim _grid As GridControl = New GridControl()
			Dim indx As Integer = Me.tabBarSplitterControl.TabBarPages.IndexOf(Me.tabBarSplitterControl.ActivePage)
			Dim oIndx As Integer = Me.tabBarSplitterControl.TabBarPages.Count+1

			Dim model As GridModel= New GridModel()
			SampleGrid.SetupGridModel(model)
			_grid = New SampleGrid(model)
			' 
			' _grid
			' 
			_grid.ContextMenuStrip = gridCMStrip
			_grid.Location = New System.Drawing.Point(0, 0)
			_grid.Name = String.Format("gridControl{0}",oIndx)
			_grid.SmartSizeBox = False
			_grid.Text = String.Format("gridControl{0}",oIndx)
			_grid.ThemesEnabled=False

			' 
			' tabBarPage
			' 
			tabBarPage.Controls.Add(_grid)
			tabBarPage.Location = New System.Drawing.Point(0, 0)
			tabBarPage.Name = String.Format("tabBarPage{0}",oIndx)
			tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both
			tabBarPage.Text = String.Format("Sheet{0}",oIndx)
			tabBarPage.ThemesEnabled = True
			_grid.ThemesEnabled=False
			GridFormulaEngine.RegisterGridAsSheet(String.Format("Sheet{0}",oIndx), _grid.Model, 1)

            Me.tabBarSplitterControl.TabBarPages.Add(tabBarPage)
		End Sub


		Private Sub deleteSheetMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles deleteSheetToolStripMenuItem.Click
			If Me.tabBarSplitterControl.TabBarPages.Count>1 Then
				Dim page As TabBarPage = Me.tabBarSplitterControl.ActivePage
				Me.tabBarSplitterControl.ActivateNextPage(True)
				Me.tabBarSplitterControl.TabBarPages.Remove(page)
			End If
		End Sub

		Private Sub HyperLinkMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hyperlinkToolStripMenuItem.Click
			Dim cc As GridCurrentCell = Me._grid.CurrentCell
			Dim style As GridStyleInfo = Me._grid.Model(cc.RowIndex,cc.ColIndex)
			If style.CellType Is "LinkLabel" Then
				style.CellType="FormulaCell"
			Else
				style.CellType= "LinkLabel"
				style.Tag = style.Text
			End If
		End Sub
		Private Sub cutMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cutToolStripMenuItem.Click
			Me._grid.Model.CutPaste.Cut()
		End Sub

		Private Sub copyMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles copyToolStripMenuItem.Click
			Me._grid.Model.CutPaste.Copy()
		End Sub

		Private Sub pasteMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pasteToolStripMenuItem.Click
			Me._grid.Model.CutPaste.Paste()
		End Sub
		Private Sub deleteMenuItem_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles deleteToolStripMenuItem.Click
			Me._grid.Model.Clear(True)
		End Sub
		#End Region

        Private Sub WorkBook_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            Dim frm As Form1 = TryCast(Me.MdiParent, Form1)
            frm.workBook = Me

            frm.gridAwareTextBoxItem1.WireGridAwareTextBox(Me.gridAwareTextBox1, Me._grid, True)
            frm.gridAwareTextBoxItem2.WireGridAwareTextBox(Me.gridAwareTextBox2, Me._grid, False)
            Me.RegisterGrid()

        End Sub

        Private Sub WorkBook_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
            Dim frm As Form1 = TryCast(Me.MdiParent, Form1)
            frm.workBook = Nothing
        End Sub


		'Register grids
		Friend Sub RegisterGrid()
			For Each page As TabBarPage In Me.tabBarSplitterControl.TabBarPages
				Dim grid As GridControl=Nothing
				For Each control As Control In page.Controls
					If TypeOf control Is GridControl Then
						grid = TryCast(control, GridControl)
						Exit For
					End If
				Next control
				If Not grid Is Nothing Then
					GridFormulaEngine.RegisterGridAsSheet(page.Text, grid.Model, 1)
					grid.Model.Refresh()
				End If
			Next page
			For Each page As TabBarPage In Me.HiddenSheets
				Dim grid As GridControl = Nothing
				For Each control As Control In page.Controls
				If TypeOf control Is GridControl Then
					grid = TryCast(control, GridControl)
					Exit For
				End If
				Next control
				If Not grid Is Nothing Then
					GridFormulaEngine.RegisterGridAsSheet(page.Text, grid.Model, 1)
					grid.Model.Refresh()
				End If
			Next page
		End Sub


		Friend Sub InvalidateFormulaCell()
			Dim range As GridRangeInfo = New GridRangeInfo()
			range = Me._grid.RectangleToRangeInfo(Me._grid.Bounds)
			For r As Integer = range.Top To range.Bottom - 1
				For c As Integer = range.Left To range.Right - 1
					If Me._grid(r,c).HasFormulaTag Then
						Me._grid(r,c).FormulaTag = Nothing
					End If
				Next c
			Next r
		End Sub

		Friend Sub HideSheet()
			If Me.tabBarSplitterControl.TabBarPages.Count > 1 Then
				Dim page As TabBarPage =Me.tabBarSplitterControl.ActivePage
				Me.HiddenSheets.Add(page)
				Me.tabBarSplitterControl.ActivateNext(True)
				Me.tabBarSplitterControl.TabBarPages.Remove(page)
			Else
				MessageBox.Show("A WorkBook must contain atleast one visible sheet!","WorkBook",MessageBoxButtons.OK,MessageBoxIcon.Stop)
			End If
		End Sub

		Friend Sub UnhideSheet()
			Dim unhideFrm As Unhide = New Unhide()

			For Each page As TabBarPage In Me.HiddenSheets
				unhideFrm.sheetListBox.Items.Add(page.Text)
			Next page

			unhideFrm.Owner = Me
			If unhideFrm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				For Each page As TabBarPage In Me.HiddenSheets
					If page.Text = CStr(unhideFrm.sheetListBox.SelectedItem) Then
						Me.tabBarSplitterControl.TabBarPages.Add(page)
						Me.HiddenSheets.Remove(page)
						Exit For
					End If
				Next page
			End If
		End Sub

		Private Sub _grid_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.InvalidateFormulaCell()
		End Sub

		Private Sub tabBarSplitterControl_ActivePageChanged(ByVal sender As Object, ByVal e As ControlEventArgs)
			'Change the Formula Bar Text to reflect the current selection in the active page
			Dim page As TabBarPage = Me.tabBarSplitterControl.ActivePage
			If Not (page Is Nothing) Then
			Dim grid As GridControl=Nothing

			If TypeOf page.Controls(1) Is GridControl Then
				grid = TryCast(page.Controls(1), GridControl)
			End If
			Dim cc As GridCurrentCell = grid.CurrentCell
			Me.gridAwareTextBox2.Text = grid(cc.RowIndex,cc.ColIndex).Text
			End If
		End Sub

		Private Sub hideItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showDialogToolStripMenuItem.Click
			HideSheet()
		End Sub

		Private Sub unhideItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles unhideItem.Click
			UnhideSheet()
		End Sub
	End Class
End Namespace