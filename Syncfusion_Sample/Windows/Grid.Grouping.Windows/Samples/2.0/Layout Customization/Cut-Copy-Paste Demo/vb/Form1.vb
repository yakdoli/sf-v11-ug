#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
#Region "Directives"

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections.Specialized

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms

#End Region

Namespace GGC_CutCopyPaste
	Public Class Form1
		Inherits MetroForm
		#Region "Variable Declaration"

		Private contextMenuStripEx1 As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
		Private WithEvents cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private textBox1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private gridGroupingControl1 As GridGroupingControl
		Private panel1 As Panel
		Private WithEvents lnkClearText As LinkLabel
		Private panel2 As Panel
		Private propertyGrid1 As PropertyGrid
		Private components As System.ComponentModel.IContainer = Nothing

		#End Region

		#Region "Event Handlers"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			'Initial Settings
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left
			Me.gridGroupingControl1.TableDescriptor.AllowNew = False

			'Selection Settings
			Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended
			Me.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None

			'Assign DataSource
			Me.gridGroupingControl1.DataSource = CreateDataSource()
			Me.gridGroupingControl1.DataMember = "Students"

			'Subscribe to the events as required
			AddHandler gridGroupingControl1.TableModel.ClipboardCopy, AddressOf TableModel_ClipboardCopy
			AddHandler gridGroupingControl1.TableModel.ClipboardCut, AddressOf TableModel_ClipboardCut
			AddHandler gridGroupingControl1.GetTableModel("MarkSheet").ClipboardCopy, AddressOf Form1_ClipboardCopy
			AddHandler gridGroupingControl1.GetTableModel("MarkSheet").ClipboardCut, AddressOf Form1_ClipboardCut
		End Sub
		'Cut in Child Table
		Private Sub Form1_ClipboardCut(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			CopySelectedRecords(True)
			e.Handled = True
		End Sub

		'Copy in Child Table
		Private Sub Form1_ClipboardCopy(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			CopySelectedRecords(False)
			e.Handled = True
		End Sub

		'Cut in Parent Table
		Private Sub TableModel_ClipboardCut(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			CopySelectedRecords(True)
			e.Handled = True
		End Sub

		'Copy in Parent Table
		Private Sub lnkClearText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkClearText.Click
			Me.textBox1.Clear()
		End Sub
		Private Sub TableModel_ClipboardCopy(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			CopySelectedRecords(False)
			e.Handled = True
		End Sub

		#Region "Context Menu Handlers"
		'Cut
		Private Sub cutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cutToolStripMenuItem.Click
			Me.gridGroupingControl1.TableModel.CutPaste.Cut()
		End Sub
		'Copy
		Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
			Me.gridGroupingControl1.TableModel.CutPaste.Copy()
		End Sub
		'Paste
		Private Sub pasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pasteToolStripMenuItem.Click
			Me.gridGroupingControl1.TableModel.CutPaste.Paste()
			Me.gridGroupingControl1.GetTableModel("MarkSheet").CutPaste.Paste()
		End Sub
		#End Region

		#End Region

		#Region "Methods"
		Private Sub CopySelectedRecords(ByVal cut As Boolean)
			Dim s As String = ""

			'Copying visible column names to the string buffer.
			For Each cd As GridVisibleColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.VisibleColumns
				Dim index As Integer = Me.gridGroupingControl1.TableDescriptor.VisibleColumns.IndexOf(cd)
				If index <> 0 Then
					s &= ControlChars.Tab
				End If
				s &= cd.Name
			Next cd
			s &= Environment.NewLine

			'Copying the selected records.
			If Me.gridGroupingControl1.Table.SelectedRecords.Count > 0 Then
				'Selection is made in the parent table
				For Each selRec As SelectedRecord In Me.gridGroupingControl1.Table.SelectedRecords
					s = CopySelectedRecordsToBuffer(s, selRec.Record, gridGroupingControl1.TableDescriptor, cut)
				Next selRec
			Else
				'Selection is made in the child table.
				s = ""
				Dim child As GridTable = gridGroupingControl1.GetTable("MarkSheet")
				If child.SelectedRecords.Count > 0 Then
					'Copying visible column names of the child table into the string buffer.
					For Each cd As GridVisibleColumnDescriptor In child.TableDescriptor.VisibleColumns
						Dim index As Integer = child.TableDescriptor.VisibleColumns.IndexOf(cd)
						If index <> 0 Then
							s &= ControlChars.Tab
						End If
						s &= cd.Name
					Next cd
					s &= Environment.NewLine
					For Each r As SelectedRecord In child.SelectedRecords
						s = CopySelectedRecordsToBuffer(s, r.Record, child.TableDescriptor, cut)
					Next r
				End If
			End If
			Clipboard.SetDataObject(New DataObject(s), True)
		End Sub

		Private Function CopySelectedRecordsToBuffer(ByVal buffer As String, ByVal rec As Record, ByVal tableDesc As GridTableDescriptor, ByVal cut As Boolean) As String
			'Since a 'Cut' operation in parent record eliminates the child records too, it is prohibited.
			If cut AndAlso tableDesc.Name.Equals("Students") Then
				MessageBox.Show("Parent record cannot be null")
				Return ""
			End If

			'Copying the data records into the string buffer.
			For i As Integer = 0 To tableDesc.VisibleColumns.Count - 1
				Dim vcd As GridVisibleColumnDescriptor = tableDesc.VisibleColumns(i)
				If i <> 0 Then
					buffer &= ControlChars.Tab
				End If
				buffer &= rec.GetValue(vcd.Name).ToString()
				If cut Then
					rec.SetValue(vcd.Name, "")
				End If
			Next i
			buffer &= Environment.NewLine

			'If the selection is made in a parent record, its child records are also get copied.
			If rec.HasNestedTables Then
				buffer &= Environment.NewLine
				buffer &= ControlChars.Tab
				Dim child As NestedTable = rec.NestedTables(0)
				Dim childDesc As GridTableDescriptor = gridGroupingControl1.GetTableDescriptor(child.ChildTable.Name)

				'Copying visible column names of the child table.
				For Each cd As GridVisibleColumnDescriptor In childDesc.VisibleColumns
					Dim index As Integer = childDesc.VisibleColumns.IndexOf(cd)
					If index <> 0 Then
						buffer &= Constants.vbTab
					End If
					buffer &= cd.Name
				Next cd
				buffer &= Environment.NewLine

				'Copying child records.
				For Each r As Record In child.FilteredRecords
					buffer &= Constants.vbTab
					For i As Integer = 0 To childDesc.VisibleColumns.Count - 1
						Dim vcd As GridVisibleColumnDescriptor = childDesc.VisibleColumns(i)
						If i <> 0 Then
							buffer &= ControlChars.Tab
						End If
						buffer &= r.GetValue(vcd.Name).ToString()
					Next i
					buffer &= Environment.NewLine
				Next r

				'Repeat the above process for every nested table associated with the record.
				For Each r As Record In child.FilteredRecords
					CopySelectedRecordsToBuffer(buffer, r, childDesc, cut)
				Next r
			End If
			Return buffer
		End Function

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		#Region "DataSource"
			Private Function CreateDataSource() As DataSet
				Dim dt1 As New DataTable("Students")
				dt1.Columns.Add("RollNo")
				dt1.PrimaryKey = New DataColumn() { dt1.Columns("RollNo") }
				dt1.Columns.Add("Name")
				dt1.Columns.Add("Address")
				dt1.Rows.Add(New Object() { "1002", "Catherine", "144, Matrix Square" })
				dt1.Rows.Add(New Object() { "1003", "Greg", "425, 5th Ave" })
				dt1.Rows.Add(New Object() { "1004", "Harry", "256, Eldams" })
				dt1.Rows.Add(New Object() { "1005", "James", "565, Bogh Road" })
				dt1.Rows.Add(New Object() { "1006", "Ken", "252, N G K Winch" })
				dt1.Rows.Add(New Object() { "1007", "Nancy", "628, Blue Star" })
				dt1.Rows.Add(New Object() { "1008", "Ronald", "325, Anna Square" })

				Dim dt2 As New DataTable("MarkSheet")
				dt2.Columns.Add("RollNo")
				dt2.Columns.Add("Mark1")
				dt2.Columns.Add("Mark2")
				dt2.Columns.Add("Mark3")
				dt2.Rows.Add(New Object() { "1002", "64.6", "80.5", "53.8" })
				dt2.Rows.Add(New Object() { "1002", "58.7", "78.5", "67.4" })
				dt2.Rows.Add(New Object() { "1003", "62.6", "65.0", "69.7" })
				dt2.Rows.Add(New Object() { "1003", "55.0", "75.0", "73.2" })
				dt2.Rows.Add(New Object() { "1003", "79.0", "70.0", "83.3" })
				dt2.Rows.Add(New Object() { "1004", "80.4", "75.6", "67.1" })
				dt2.Rows.Add(New Object() { "1004", "54.4", "72.5", "75.5" })
				dt2.Rows.Add(New Object() { "1004", "48.8", "71.2", "67.6" })
				dt2.Rows.Add(New Object() { "1005", "73.5", "77.4", "83.8" })
				dt2.Rows.Add(New Object() { "1005", "59.6", "70.1", "56.8" })
				dt2.Rows.Add(New Object() { "1006", "95.3", "93.6", "85.0" })
				dt2.Rows.Add(New Object() { "1007", "63.5", "69.3", "72.0" })
				dt2.Rows.Add(New Object() { "1007", "51.4", "65.5", "64.4" })
				dt2.Rows.Add(New Object() { "1007", "82.8", "87.2", "88.5" })
				dt2.Rows.Add(New Object() { "1008", "67.3", "72.4", "68.5" })

				Dim ds As New DataSet()
				ds.Tables.Add(dt1)
				ds.Tables.Add(dt2)

				ds.Relations.Add(New DataRelation("StudMarks", ds.Tables(0).Columns(0), ds.Tables(1).Columns(0)))

				Return ds
			End Function
			#End Region

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

		#End Region

		#Region "Windows Form Designer generated code"

		Public Sub New()
			InitializeComponent()
			Me.gridGroupingControl1.GridGroupDropArea.DragColumnHeaderText = "Drag here to Group"
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.contextMenuStripEx1 = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
			Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.textBox1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.lnkClearText = New System.Windows.Forms.LinkLabel()
			Me.contextMenuStripEx1.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contextMenuStripEx1
			' 
			Me.contextMenuStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem})
			Me.contextMenuStripEx1.Name = "contextMenuStripEx1"
			Me.contextMenuStripEx1.Size = New System.Drawing.Size(103, 70)
			' 
			' cutToolStripMenuItem
			' 
			Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
			Me.cutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
			Me.cutToolStripMenuItem.Text = "Cut"
'			Me.cutToolStripMenuItem.Click += New System.EventHandler(Me.cutToolStripMenuItem_Click)
			' 
			' copyToolStripMenuItem
			' 
			Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
			Me.copyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
			Me.copyToolStripMenuItem.Text = "Copy"
'			Me.copyToolStripMenuItem.Click += New System.EventHandler(Me.copyToolStripMenuItem_Click)
			' 
			' pasteToolStripMenuItem
			' 
			Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
			Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
			Me.pasteToolStripMenuItem.Text = "Paste"
'			Me.pasteToolStripMenuItem.Click += New System.EventHandler(Me.pasteToolStripMenuItem_Click)
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textBox1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox1.Location = New System.Drawing.Point(3, 355)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
			Me.textBox1.Size = New System.Drawing.Size(596, 184)
			Me.textBox1.TabIndex = 0
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.ShowToolTipInPopUp = False
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ContextMenuStrip = Me.contextMenuStripEx1
			Me.gridGroupingControl1.Location = New System.Drawing.Point(3, 4)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.Size = New System.Drawing.Size(287, 333)
			Me.gridGroupingControl1.TabIndex = 2
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255)))))))
			Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.VersionInfo = "5.102.0.51"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.propertyGrid1)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.lnkClearText)
			Me.panel1.Controls.Add(Me.gridGroupingControl1)
			Me.panel1.Controls.Add(Me.textBox1)
			Me.panel1.Location = New System.Drawing.Point(12, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(602, 542)
			Me.panel1.TabIndex = 5
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.propertyGrid1.BackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(301, 5)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.propertyGrid1.Size = New System.Drawing.Size(297, 332)
			Me.propertyGrid1.TabIndex = 11
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.LightGray
			Me.panel2.Location = New System.Drawing.Point(294, 14)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(1, 320)
			Me.panel2.TabIndex = 10
			' 
			' lnkClearText
			' 
			Me.lnkClearText.AutoSize = True
			Me.lnkClearText.Location = New System.Drawing.Point(240, 339)
			Me.lnkClearText.Name = "lnkClearText"
			Me.lnkClearText.Size = New System.Drawing.Size(53, 13)
			Me.lnkClearText.TabIndex = 3
			Me.lnkClearText.TabStop = True
			Me.lnkClearText.Text = "ClearText"
'			Me.lnkClearText.Click += New System.EventHandler(Me.lnkClearText_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(624, 565)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cut-Copy-Paste Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.contextMenuStripEx1.ResumeLayout(False)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub


		#End Region
	End Class
End Namespace