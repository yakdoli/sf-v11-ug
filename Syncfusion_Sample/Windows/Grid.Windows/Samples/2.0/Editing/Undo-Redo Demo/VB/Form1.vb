Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms

Namespace UndoRedoSample

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "members"
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private listBox1 As System.Windows.Forms.ListBox
		Private listBox2 As System.Windows.Forms.ListBox

		'needed to conditionally display new stacks
		Private oldRedoCount As Integer
		Private oldUndoCount As Integer

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents contextMenuStrip1 As ContextMenuStrip
		Private editToolStripMenuItem As ToolStripMenuItem
		Private WithEvents undoToolStripMenuItem As ToolStripMenuItem
		Private WithEvents redoToolStripMenuItem As ToolStripMenuItem
		Private transactionsToolStripMenuItem1 As ToolStripMenuItem
		Private WithEvents beginToolStripMenuItem As ToolStripMenuItem
		Private WithEvents commitToolStripMenuItem1 As ToolStripMenuItem
		Private WithEvents rollBackToolStripMenuItem1 As ToolStripMenuItem
		Private helpToolStripMenuItem As ToolStripMenuItem
		Private WithEvents helpToolStripMenuItem1 As ToolStripMenuItem
		Private WithEvents aboutToolStripMenuItem As ToolStripMenuItem
		Private textBox2 As TextBox
		Private textBox1 As TextBox
		Private components As System.ComponentModel.IContainer
		#End Region

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try


'			#Region "Grid Properties"
			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 70
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
			Me.gridControl1.ContextMenuStrip = Me.contextMenuStrip1
'			#End Region

'			#Region "Populate the Grid"

			'turn off undo buffer so initial population cannot be undone
			Me.gridControl1.CommandStack.Enabled = False

			'call a routine to populate the grid somehow...
			PopulateMyGrid()

			'turn undo buffer back on...
			Me.gridControl1.CommandStack.Enabled = True

			'handle adding list changes -- handler allows the updating of the display
			AddHandler gridControl1.Invalidated, AddressOf UpdateListBoxes

			oldRedoCount = 0
			oldUndoCount = 0

			Me.gridControl1.RowHeights(0)=0
			Me.gridControl1.ColWidths(0)=0

			Me.gridControl1.TableStyle.BackColor = System.Drawing.Color.White
'			this.gridControl1.ActivateCurrentCellBehavior=GridCellActivateAction.ClickOnCell;
'          this.gridControl1.ShowCurrentCellBorderBehavior=GridShowCurrentCellBorder.WhenGridActive;
'#End Region

		End Sub

		#Region "Form Handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Me.components = New System.ComponentModel.Container()
			Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.listBox2 = New System.Windows.Forms.ListBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.redoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.transactionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.beginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.commitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.rollBackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.helpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.contextMenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.AllowDragSelectedCols = True
			Me.gridControl1.AllowDragSelectedRows = True
			Me.gridControl1.AllowDrop = True
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			gridBaseStyle1.Name = "Row Header"
			gridBaseStyle1.StyleInfo.BaseStyle = "Header"
			gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridBaseStyle2.Name = "Column Header"
			gridBaseStyle2.StyleInfo.BaseStyle = "Header"
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle3.Name = "Standard"
			gridBaseStyle3.StyleInfo.AllowEnter = False
			gridBaseStyle3.StyleInfo.AutoSize = False
			gridBaseStyle3.StyleInfo.BaseStyle = ""
			gridBaseStyle3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridBaseStyle3.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridBaseStyle3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridBaseStyle3.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridBaseStyle3.StyleInfo.CellAppearance = Syncfusion.Windows.Forms.Grid.GridCellAppearance.Flat
			gridBaseStyle3.StyleInfo.CellType = "TextBox"
			gridBaseStyle3.StyleInfo.CellValueType = Nothing
			gridBaseStyle3.StyleInfo.Clickable = True
			gridBaseStyle3.StyleInfo.CultureInfo = Nothing
			gridBaseStyle3.StyleInfo.Description = ""
			gridBaseStyle3.StyleInfo.DropDownStyle = Syncfusion.Windows.Forms.Grid.GridDropDownStyle.Editable
			gridBaseStyle3.StyleInfo.Enabled = True
			gridBaseStyle3.StyleInfo.FloatCell = True
			gridBaseStyle3.StyleInfo.FloodCell = True
			gridBaseStyle3.StyleInfo.Font.Bold = False
			gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI"
			gridBaseStyle3.StyleInfo.Font.Italic = False
			gridBaseStyle3.StyleInfo.Font.Size = 8.25F
			gridBaseStyle3.StyleInfo.Font.Strikeout = False
			gridBaseStyle3.StyleInfo.Font.Underline = False
			gridBaseStyle3.StyleInfo.Format = ""
			gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle3.StyleInfo.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
			gridBaseStyle3.StyleInfo.ImageList = Nothing
			gridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle3.StyleInfo.MaxLength = 0
			gridBaseStyle3.StyleInfo.ReadOnly = False
			gridBaseStyle3.StyleInfo.ShowButtons = Syncfusion.Windows.Forms.Grid.GridShowButtons.Show
			gridBaseStyle3.StyleInfo.Text = ""
			gridBaseStyle3.StyleInfo.TextAlign = Syncfusion.Windows.Forms.Grid.GridTextAlign.Default
			gridBaseStyle3.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue
			gridBaseStyle3.StyleInfo.TextMargins.Bottom = 1
			gridBaseStyle3.StyleInfo.TextMargins.Left = 1
			gridBaseStyle3.StyleInfo.TextMargins.Right = 1
			gridBaseStyle3.StyleInfo.TextMargins.Top = 1
			gridBaseStyle3.StyleInfo.Trimming = System.Drawing.StringTrimming.Character
			gridBaseStyle3.StyleInfo.TriState = False
			gridBaseStyle3.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Top
			gridBaseStyle3.StyleInfo.VerticalScrollbar = False
			gridBaseStyle3.StyleInfo.WrapText = True
			gridBaseStyle4.Name = "Header"
			gridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.CellType = "Header"
			gridBaseStyle4.StyleInfo.Font.Bold = True
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.DefaultColWidth = 70
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.DragSelectedCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			gridCellInfo1.Col = -1
			gridCellInfo1.Row = -1
			gridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo1})
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.Location = New System.Drawing.Point(3, 3)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RowCount = 30
			Me.gridControl1.Size = New System.Drawing.Size(546, 355)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			' 
			' listBox1
			' 
			Me.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.listBox1.ItemHeight = 15
			Me.listBox1.Location = New System.Drawing.Point(565, 221)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(269, 137)
			Me.listBox1.TabIndex = 1
			' 
			' listBox2
			' 
			Me.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.listBox2.ItemHeight = 15
			Me.listBox2.Location = New System.Drawing.Point(565, 43)
			Me.listBox2.Name = "listBox2"
			Me.listBox2.Size = New System.Drawing.Size(269, 122)
			Me.listBox2.TabIndex = 2
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.textBox2)
			Me.panel1.Controls.Add(Me.textBox1)
			Me.panel1.Controls.Add(Me.gridControl1)
			Me.panel1.Controls.Add(Me.listBox2)
			Me.panel1.Controls.Add(Me.listBox1)
			Me.panel1.Location = New System.Drawing.Point(12, -1)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(844, 370)
			Me.panel1.TabIndex = 4
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(565, 192)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(269, 23)
			Me.textBox2.TabIndex = 4
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(565, 13)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(269, 23)
			Me.textBox1.TabIndex = 3
			' 
			' contextMenuStrip1
			' 
			Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.editToolStripMenuItem, Me.helpToolStripMenuItem})
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.Size = New System.Drawing.Size(100, 48)
'			Me.contextMenuStrip1.Opening += New System.ComponentModel.CancelEventHandler(Me.contextMenuStrip1_Opening)
			' 
			' editToolStripMenuItem
			' 
			Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.transactionsToolStripMenuItem1})
			Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
			Me.editToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
			Me.editToolStripMenuItem.Text = "Edit"
			' 
			' undoToolStripMenuItem
			' 
			Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
			Me.undoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
			Me.undoToolStripMenuItem.Text = "Undo"
'			Me.undoToolStripMenuItem.Click += New System.EventHandler(Me.undoToolStripMenuItem_Click)
			' 
			' redoToolStripMenuItem
			' 
			Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
			Me.redoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
			Me.redoToolStripMenuItem.Text = "Redo"
'			Me.redoToolStripMenuItem.Click += New System.EventHandler(Me.redoToolStripMenuItem_Click)
			' 
			' transactionsToolStripMenuItem1
			' 
			Me.transactionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.beginToolStripMenuItem, Me.commitToolStripMenuItem1, Me.rollBackToolStripMenuItem1})
			Me.transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1"
			Me.transactionsToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
			Me.transactionsToolStripMenuItem1.Text = "Transactions"
			' 
			' beginToolStripMenuItem
			' 
			Me.beginToolStripMenuItem.Name = "beginToolStripMenuItem"
			Me.beginToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
			Me.beginToolStripMenuItem.Text = "Begin"
'			Me.beginToolStripMenuItem.Click += New System.EventHandler(Me.beginToolStripMenuItem_Click)
			' 
			' commitToolStripMenuItem1
			' 
			Me.commitToolStripMenuItem1.Name = "commitToolStripMenuItem1"
			Me.commitToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
			Me.commitToolStripMenuItem1.Text = "Commit"
'			Me.commitToolStripMenuItem1.Click += New System.EventHandler(Me.commitToolStripMenuItem1_Click)
			' 
			' rollBackToolStripMenuItem1
			' 
			Me.rollBackToolStripMenuItem1.Name = "rollBackToolStripMenuItem1"
			Me.rollBackToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
			Me.rollBackToolStripMenuItem1.Text = "RollBack"
'			Me.rollBackToolStripMenuItem1.Click += New System.EventHandler(Me.rollBackToolStripMenuItem1_Click)
			' 
			' helpToolStripMenuItem
			' 
			Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.helpToolStripMenuItem1, Me.aboutToolStripMenuItem})
			Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
			Me.helpToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
			Me.helpToolStripMenuItem.Text = "Help"
			' 
			' helpToolStripMenuItem1
			' 
			Me.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1"
			Me.helpToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
			Me.helpToolStripMenuItem1.Text = "Help"
'			Me.helpToolStripMenuItem1.Click += New System.EventHandler(Me.helpToolStripMenuItem1_Click)
			' 
			' aboutToolStripMenuItem
			' 
			Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
			Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
			Me.aboutToolStripMenuItem.Text = "About"
'			Me.aboutToolStripMenuItem.Click += New System.EventHandler(Me.aboutToolStripMenuItem_Click)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(868, 378)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Undo-Redo Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.contextMenuStrip1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

        <STAThread()> _
  Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub
#End Region

		#Region "Populate the grid"
		Private Sub PopulateMyGrid()
			'			//used to time things if desired
			'			int startTime = Environment.TickCount;

			'populate with random numbers
			'just place values directly into style, slow but straight-forward
			Dim r As New Random()
			For i As Integer = 1 To Me.gridControl1.RowCount
				For j As Integer = 1 To Me.gridControl1.ColCount
					Me.gridControl1(i,j).CellValue = r.Next(1000)
				Next j
			Next i

			'			//for more efficient population, could use a call to PopulateValues
			'			//for example, this code is more than a factor of ten quicker...
			'			Random r = new Random();
			'			int[,] table = new int[this.gridControl1.RowCount, this.gridControl1.ColCount];
			'			for(int i = 1; i <= this.gridControl1.RowCount; ++i)
			'				for(int j = 1; j <= this.gridControl1.ColCount; ++j)
			'					table[i-1, j-1] = r.Next(1000);
			'
			'			this.gridControl1.PopulateValues(
			'							GridRangeInfo.Cells(1, 1, this.gridControl1.RowCount, this.gridControl1.ColCount),
			'							table); 

			'			MessageBox.Show((Environment.TickCount - startTime).ToString() + " ticks");


		End Sub

		#End Region

		#Region "Menu Handlers"
		Private Sub EditUndo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			If Not Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.Undo()
				ShowStacks()
			End If
		End Sub

		Private Sub EditRedo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			If Not Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.Redo()
				ShowStacks()
			End If
		End Sub

		Private Sub EditClearUndo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			If Not Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.UndoStack.Clear()
				ShowStacks()
			End If
		End Sub

		Private Sub EditClearRedo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.gridControl1.CommandStack.RedoStack.Clear()
			ShowStacks()
		End Sub

		Private Sub EditTransactionsBegin_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.gridControl1.CommandStack.BeginTrans("Transaction beginning-")
			ShowStacks()
			'this.toolBeginTrans.ImageIndex = 5;
		End Sub

		Private Sub EditTransactionsCommit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			If Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.CommitTrans()
				'this.toolBeginTrans.ImageIndex = 2;
				ShowStacks()
			End If
		End Sub

		Private Sub EditTransactionsRollBack_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			If Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.Rollback()
				'this.toolBeginTrans.ImageIndex = 2;
				ShowStacks()
			End If
		End Sub
		#End Region

		#Region "Updates to the display lists"

		Private Sub UpdateListBoxes(ByVal sender As Object, ByVal e As InvalidateEventArgs)
			ShowStacks()
		End Sub

		Private Sub ShowStacks()
			ShowRedoStack()
			ShowUndoStack()
		End Sub

		Private Sub ShowUndoStack()
			Dim numUndos As Integer = Me.gridControl1.CommandStack.UndoStack.Count
			If numUndos <> Me.oldUndoCount OrElse Me.gridControl1.CommandStack.InTransaction Then
				Me.listBox1.Items.Clear()
				Me.textBox2.Text=String.Format("{0} Undo items", numUndos)

				If numUndos > 0 OrElse Me.gridControl1.CommandStack.IsRecording Then
					DisplayCommandsInStack(Me.gridControl1.CommandStack.UndoStack.ToArray(), "", listBox1, True)
				End If
				Me.oldUndoCount = numUndos
			End If

		End Sub

		Private Sub ShowRedoStack()
			Dim numRedos As Integer = Me.gridControl1.CommandStack.RedoStack.Count
			If numRedos <> Me.oldRedoCount OrElse Me.gridControl1.CommandStack.InTransaction Then
				Me.listBox2.Items.Clear()
				Me.textBox1.Text = String.Format("{0} Redo items", numRedos)
				If numRedos > 0 OrElse Me.gridControl1.CommandStack.IsRecording Then
					DisplayCommandsInStack(Me.gridControl1.CommandStack.RedoStack.ToArray(), "", listBox2, False)
				End If
				Me.oldRedoCount = numRedos
			End If
		End Sub


		Private Sub DisplayCommandsInStack(ByVal items() As Object, ByVal indent As String, ByVal _listbox As ListBox, ByVal includeCurrentCommand As Boolean)
			Dim s As String
			Dim c As SyncfusionCommand
			Dim tc As GridTransactionCommand
			Dim cutOff As Integer

			'handle the case where we are recording a transaction
			If includeCurrentCommand AndAlso Me.gridControl1.CommandStack.InTransaction Then
				Try
					tc = Me.gridControl1.CommandStack.CurrentTransactionCommand
					DisplayCommandsInStack(tc.Stack.ToArray(), "    > ", _listbox, False)
				Catch
				End Try
			End If

			For Each o As Object In items
				Try
					c = CType(o, SyncfusionCommand)
					If c IsNot Nothing AndAlso c.Description IsNot Nothing Then
						s = c.Description
					Else
						s = o.ToString()
					End If
					cutOff = 1 + Math.Max(s.LastIndexOf("+"), s.LastIndexOf("."))
					_listbox.Items.Add(indent & s.Substring(cutOff))
				Catch
				End Try

				'check if is a transaction command
				Try
					tc = TryCast(o, GridTransactionCommand)
					If tc IsNot Nothing Then
						DisplayCommandsInStack(tc.Stack.ToArray(), "    > ", _listbox, False)
					End If
				Catch
				End Try

			Next o


		End Sub

		#End Region

		#Region "Event Handlers"
		Private Sub menuHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			MessageBox.Show("Change some cells, or move columns or rows in the" & Constants.vbCrLf & "grid. You will see the Undo list start to grow. " & Constants.vbCrLf & Constants.vbCrLf & "Click the Undo button or use the menu to undo an action." & Constants.vbCrLf & " You will see the Redo list change." & Constants.vbCrLf & Constants.vbCrLf & "Use the Begin Transaction to start a group of changes that" & Constants.vbCrLf & "are treated as a single Undo/Redo command. Use Commit " & Constants.vbCrLf & "Transaction to signal the end of a transaction group.")
		End Sub

		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			abtForm.ShowDialog()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub undoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles undoToolStripMenuItem.Click
			If Not Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.Undo()
				ShowStacks()
			End If
		End Sub

		Private Sub redoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles redoToolStripMenuItem.Click
			If Not Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.Redo()
				ShowStacks()
			End If
		End Sub

		Private Sub contextMenuStrip1_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles contextMenuStrip1.Opening

		End Sub

		Private Sub beginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles beginToolStripMenuItem.Click
			Me.gridControl1.CommandStack.BeginTrans("Transaction beginning-")
			ShowStacks()
		End Sub

		Private Sub rollBackToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rollBackToolStripMenuItem1.Click
			If Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.Rollback()
				'this.toolBeginTrans.ImageIndex = 2;
				ShowStacks()
			End If
		End Sub

		Private Sub commitToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles commitToolStripMenuItem1.Click
			If Me.gridControl1.CommandStack.InTransaction Then
				Me.gridControl1.CommandStack.CommitTrans()
				'this.toolBeginTrans.ImageIndex = 2;
				ShowStacks()
			End If
		End Sub

		Private Sub helpToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles helpToolStripMenuItem1.Click
			MessageBox.Show("Change some cells, or move columns or rows in the" & Constants.vbCrLf & "grid. You will see the Undo list start to grow. " & Constants.vbCrLf & Constants.vbCrLf & "Click the Undo button or use the menu to undo an action." & Constants.vbCrLf & " You will see the Redo list change." & Constants.vbCrLf & Constants.vbCrLf & "Use the Begin Transaction to start a group of changes that" & Constants.vbCrLf & "are treated as a single Undo/Redo command. Use Commit " & Constants.vbCrLf & "Transaction to signal the end of a transaction group.")
		End Sub

		Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
			Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			abtForm.ShowDialog()
		End Sub
		#End Region
	End Class
End Namespace
