#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO


Imports Syncfusion.XlsIO

Imports Syncfusion.GridExcelConverter
Imports Syncfusion.GroupingGridExcelConverter


Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace GridExcelConverter
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
		Private checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label1 As Label
		Private WithEvents comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private checkBox4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private checkBox5 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private checkBox6 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private groupBox1 As GroupBox
		Private WithEvents gridGroupingControl1 As GridGroupingControl
		Private colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private groupBox2 As GroupBox
		Private groupBox3 As GroupBox
		Private label4 As Label
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'

'			#Region "SetUpGroupingGrid"

			Dim parentTable As DataTable = GetParentTable()
			Dim childTable As DataTable = GetChildTable()
			Dim grandChildTable As DataTable = GetGrandChildTable()

			'Add Summary row to parent table
			Dim gridSummaryColumnDescriptor As New GridSummaryColumnDescriptor()
			gridSummaryColumnDescriptor.DisplayColumn = "GroupID"
			gridSummaryColumnDescriptor.Format = "  {Count} Records."
			gridSummaryColumnDescriptor.Name = "SummaryColumn"
			gridSummaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.Count
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("SummaryRow", New GridSummaryColumnDescriptor() { gridSummaryColumnDescriptor}))


			' Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
			' This is the same approach that should be used if you want to set up relation ships
			' between independent IList.
			Dim parentToChildRelationDescriptor As New GridRelationDescriptor()
			parentToChildRelationDescriptor.ChildTableName = "MyChildTable" ' same as SourceListSetEntry.Name for childTable (see below)
			parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID")

			'Add Summary Row to child table
			gridSummaryColumnDescriptor = New GridSummaryColumnDescriptor()
			gridSummaryColumnDescriptor.DisplayColumn = "ChildGroupID"
			gridSummaryColumnDescriptor.Format = "  {Count} Records."
			gridSummaryColumnDescriptor.Name = "SummaryColumn"
			gridSummaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.Count
			parentToChildRelationDescriptor.ChildTableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("SummaryRow", New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor() { gridSummaryColumnDescriptor}))


			' Add relation to ParentTable 
			gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)

			Dim childToGrandChildRelationDescriptor As New GridRelationDescriptor()
			childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable" ' same as SourceListSetEntry.Name for grandChhildTable (see below)
			childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID")

			'Add Summary row to GrandChildTable 
			gridSummaryColumnDescriptor = New GridSummaryColumnDescriptor()
			gridSummaryColumnDescriptor.DisplayColumn = "GrandChildGroupID"
			gridSummaryColumnDescriptor.Format = "  {Count} Records."
			gridSummaryColumnDescriptor.Name = "SummaryColumn"
			gridSummaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.Count
			childToGrandChildRelationDescriptor.ChildTableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("SummaryRow", New GridSummaryColumnDescriptor() { gridSummaryColumnDescriptor}))


			' Add relation to ChildTable 
			parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)

			' Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable)

			Me.gridGroupingControl1.DataSource = parentTable
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.AddGroupDropArea("MyChildTable")
			Me.gridGroupingControl1.AddGroupDropArea("MyGrandChildTable")


			'Sync the col width with nested table to avoid messing up of RecordPreviewCell

			' The TrackWidthOfParentColumn propetry of a column descriptor ensures that 
			' columns are aligned and stay in sync. 

			Me.gridGroupingControl1.TableDescriptor.Columns(0).Width = 200
			Me.gridGroupingControl1.TableDescriptor.Columns(1).Width = 150
			Me.gridGroupingControl1.TableDescriptor.Columns(2).Width = 150

			'// synchronize width of columns in child record with width of column in parent record.
			For n As Integer = 0 To 2
			parentToChildRelationDescriptor.ChildTableDescriptor.Columns(n).TrackWidthOfParentColumn = gridGroupingControl1.TableDescriptor.Columns(n).Name
			Next n

			'''same for grandchild table.
			For n As Integer = 0 To 2
			childToGrandChildRelationDescriptor.ChildTableDescriptor.Columns(n).TrackWidthOfParentColumn = parentToChildRelationDescriptor.ChildTableDescriptor.Columns(n).Name
			Next n


			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("GroupID")
			Me.gridGroupingControl1.TableOptions.ShowRecordPreviewRow = True
			Me.gridGroupingControl1.ChildGroupOptions.ShowGroupPreview = True
			gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.gridGroupingControl1.TableDescriptor.Columns("GroupID").Appearance.AnyHeaderCell.HorizontalAlignment = GridHorizontalAlignment.Right
			Me.gridGroupingControl1.TableDescriptor.Columns("GroupID").Appearance.AnyHeaderCell.VerticalAlignment = GridVerticalAlignment.Bottom

'			#End Region

			Me.comboBox1.Items.Add(ConverterOptions.Default)
			Me.comboBox1.Items.Add(ConverterOptions.Visible)
			Me.comboBox1.SelectedIndex = 0

			Me.checkBox2.Checked = True
			Me.checkBox3.Checked = True
			Me.checkBox5.Checked = True
			Me.checkBox6.Checked = True
			Me.colorPickerButton1.SelectedColor = Color.Empty
			Me.colorPickerButton2.SelectedColor = Color.Empty

			AddHandler comboBox1.SelectedIndexChanged, AddressOf comboBox1_SelectedIndexChanged

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico

		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		#Region "DataTable"
		Private numberParentRows As Integer = 50
		Private numberChildRows As Integer = 200
		Private numberGrandChildRows As Integer = 500
		Private Function GetParentTable() As DataTable
			Dim dt As New DataTable("ParentTable")


			dt.Columns.Add(New DataColumn("parentID")) 'lower case p
			dt.Columns.Add(New DataColumn("ParentName"))
			dt.Columns.Add(New DataColumn("GroupID"))

			Dim r As New Random()
			For i As Integer = 0 To numberParentRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i '.ToString();
				dr(1) = String.Format("parentName{0}", i)
				dr(2) = r.Next(99,111)
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetChildTable() As DataTable
			Dim dt As New DataTable("ChildTable")

			dt.Columns.Add(New DataColumn("childID")) 'lower case c
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ParentID")) 'upper case P
			dt.Columns.Add(New DataColumn("ChildGroupID"))

			Dim r As New Random()
			For i As Integer = 0 To numberChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("ChildName{0}",i)
				dr(2) = (i Mod numberParentRows).ToString()
				dr(3) = r.Next(994,1006)
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetGrandChildTable() As DataTable
			Dim dt As New DataTable("GrandChildTable")

			dt.Columns.Add(New DataColumn("GrandChildID"))
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ChildID")) 'upper case C
			dt.Columns.Add(New DataColumn("GrandChildGroupID"))

			Dim r As New Random()
			For i As Integer = 0 To numberGrandChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("GrandChildName{0}",i)
				dr(2) = (i Mod numberChildRows).ToString()
				dr(3) = r.Next(100,112)
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function
		#End Region

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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.label1 = New System.Windows.Forms.Label()
			Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox6 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button2
			' 
			Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(36, 511)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(174, 28)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Export Grid"
			Me.button2.UseVisualStyle = True
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' checkBox1
			' 
			Me.checkBox1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.DrawFocusRectangle = False
			Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(45, 26)
			Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(115, 17)
			Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox1.TabIndex = 4
			Me.checkBox1.Text = "Export Grid Style"
			Me.checkBox1.ThemesEnabled = False
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(11, 41)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(108, 13)
			Me.label1.TabIndex = 8
			Me.label1.Text = "Converter Options: "
			' 
			' comboBox1
			' 
			Me.comboBox1.BackColor = System.Drawing.Color.White
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox1.Location = New System.Drawing.Point(122, 38)
			Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(101, 21)
			Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBox1.TabIndex = 9
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged)
			' 
			' checkBox2
			' 
			Me.checkBox2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkBox2.DrawFocusRectangle = False
			Me.checkBox2.Location = New System.Drawing.Point(8, 98)
			Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(134, 30)
			Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox2.TabIndex = 10
			Me.checkBox2.Text = "ExportPreviewRows"
			Me.checkBox2.ThemesEnabled = False
			' 
			' checkBox3
			' 
			Me.checkBox3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkBox3.DrawFocusRectangle = False
			Me.checkBox3.Location = New System.Drawing.Point(8, 134)
			Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(196, 34)
			Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox3.TabIndex = 11
			Me.checkBox3.Text = "Hook QueryExporPreviewRowInfo event handler.  "
			Me.checkBox3.ThemesEnabled = False
			' 
			' checkBox4
			' 
			Me.checkBox4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkBox4.Checked = True
			Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox4.DrawFocusRectangle = False
			Me.checkBox4.Location = New System.Drawing.Point(45, 53)
			Me.checkBox4.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New System.Drawing.Size(99, 17)
			Me.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox4.TabIndex = 14
			Me.checkBox4.Text = "Export Borders"
			Me.checkBox4.ThemesEnabled = False
			' 
			' checkBox5
			' 
			Me.checkBox5.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkBox5.Checked = True
			Me.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox5.DrawFocusRectangle = False
			Me.checkBox5.Location = New System.Drawing.Point(8, 67)
			Me.checkBox5.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox5.Name = "checkBox5"
			Me.checkBox5.Size = New System.Drawing.Size(145, 25)
			Me.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox5.TabIndex = 15
			Me.checkBox5.Text = "ExportGroupPlusMinus"
			Me.checkBox5.ThemesEnabled = False
			' 
			' checkBox6
			' 
			Me.checkBox6.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkBox6.Checked = True
			Me.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox6.DrawFocusRectangle = False
			Me.checkBox6.Location = New System.Drawing.Point(8, 35)
			Me.checkBox6.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox6.Name = "checkBox6"
			Me.checkBox6.Size = New System.Drawing.Size(148, 26)
			Me.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox6.TabIndex = 16
			Me.checkBox6.Text = "ExportRecordPlusMinus"
			Me.checkBox6.ThemesEnabled = False
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
			Me.groupBox1.Controls.Add(Me.groupBox3)
			Me.groupBox1.Controls.Add(Me.groupBox2)
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox1.Location = New System.Drawing.Point(636, 24)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(246, 563)
			Me.groupBox1.TabIndex = 17
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Export Options"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.label4)
			Me.groupBox3.Controls.Add(Me.checkBox6)
			Me.groupBox3.Controls.Add(Me.checkBox5)
			Me.groupBox3.Controls.Add(Me.checkBox3)
			Me.groupBox3.Controls.Add(Me.checkBox2)
			Me.groupBox3.Location = New System.Drawing.Point(14, 250)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(213, 248)
			Me.groupBox3.TabIndex = 11
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Other Options"
			' 
			' label4
			' 
			Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.Location = New System.Drawing.Point(7, 179)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(197, 53)
			Me.label4.TabIndex = 17
			Me.label4.Text = "[ Handle this event when you want to export PreviewRow for non-display elements ]" & ""
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.checkBox1)
			Me.groupBox2.Controls.Add(Me.checkBox4)
			Me.groupBox2.Controls.Add(Me.colorPickerButton2)
			Me.groupBox2.Controls.Add(Me.colorPickerButton1)
			Me.groupBox2.Location = New System.Drawing.Point(14, 82)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(213, 162)
			Me.groupBox2.TabIndex = 10
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Export Style"
			' 
			' colorPickerButton2
			' 
			Me.colorPickerButton2.BackColor = System.Drawing.Color.DarkGray
			Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton2.Location = New System.Drawing.Point(45, 119)
			Me.colorPickerButton2.Name = "colorPickerButton2"
			Me.colorPickerButton2.SelectedAsBackcolor = True
			Me.colorPickerButton2.SelectedColor = System.Drawing.Color.DarkGray
			Me.colorPickerButton2.Size = New System.Drawing.Size(126, 25)
			Me.colorPickerButton2.TabIndex = 18
			Me.colorPickerButton2.Text = "Caption BackColor"
			Me.colorPickerButton2.UseVisualStyleBackColor = False
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.BackColor = System.Drawing.Color.Gray
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton1.Location = New System.Drawing.Point(45, 84)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedAsBackcolor = True
			Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Gray
			Me.colorPickerButton1.Size = New System.Drawing.Size(126, 24)
			Me.colorPickerButton1.TabIndex = 17
			Me.colorPickerButton1.Text = "Header BackColor"
			Me.colorPickerButton1.UseVisualStyleBackColor = False
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridGroupingControl1.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(162)))))))
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.Location = New System.Drawing.Point(10, 10)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(618, 588)
			Me.gridGroupingControl1.TabIndex = 3
			Me.gridGroupingControl1.TableDescriptor.AllowNew = False
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235)))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
			Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
			Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
			Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229)))))))
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.VersionInfo = "4.401.0.51"
'			Me.gridGroupingControl1.QueryCellStyleInfo += New Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(Me.gridGroupingControl1_QueryCellStyleInfo)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(892, 609)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Excel Export Demo"
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()

			#If FrameWork20 OrElse FrameWork11 Then
				Application.EnableVisualStyles()
			#End If
			Application.Run(New Form1())
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click

			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.Filter = "Files(*.XLS)|*.XLS"
			saveFileDialog.AddExtension = True
			saveFileDialog.DefaultExt = ".XLS"

			If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso saveFileDialog.CheckPathExists Then
				Dim converter As New GroupingGridExcelConverterControl()

				'Properties

				'ExportStyle
				If checkBox1.Checked Then
					'by default ExportStyle is true


					converter.ExportBorders = Me.checkBox4.Checked
				Else
					converter.ExportStyle = False
				End If

				If colorPickerButton1.SelectedColor <> Color.Empty Then
					converter.HeaderBackColor = Me.colorPickerButton1.SelectedColor
				End If
				If colorPickerButton2.SelectedColor <> Color.Empty Then
					converter.CaptionBackColor = Me.colorPickerButton2.SelectedColor
				End If


				'by default ExportPreviewRows is false
				converter.ExportPreviewRows = Me.checkBox2.Checked

				converter.ExportGroupPlusMinus = Me.checkBox5.Checked
				converter.ExportRecordPlusMinus = Me.checkBox6.Checked

				'Hook QueryExportPreviewRowInfo event for non display elements.
				If Me.checkBox3.Checked Then
					'must handle the QueryExportPreviewRowInfo event when the ConverterOptions is
					'not Visible
					AddHandler converter.QueryExportPreviewRowInfo, AddressOf converter_QueryExportPreviewRowInfo
				Else
					RemoveHandler converter.QueryExportPreviewRowInfo, AddressOf converter_QueryExportPreviewRowInfo
				End If

				Dim options As ConverterOptions = CType(Me.comboBox1.SelectedItem, ConverterOptions)
				converter.GroupingGridToExcel(Me.gridGroupingControl1, saveFileDialog.FileName, options)
				converter.Dispose()
				If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
					Dim proc As New System.Diagnostics.Process()
					proc.StartInfo.FileName = saveFileDialog.FileName
					proc.Start()
				End If
			End If

		End Sub

		Private Sub converter_QueryExportPreviewRowInfo(ByVal sender As Object, ByVal e As GroupingGridExportPreviewRowQueryInfoEventArgs)
			If e.Element.Kind = DisplayElementKind.GroupPreview Then
				Dim el As Element = e.Element
				e.Style.CellValue = "Preview notes for Group (" & el.ParentGroup.Name & ": " & el.ParentGroup.Category.ToString() & ")"
				e.Style.BackColor = Color.MistyRose
				e.Handled = True
			End If
			If e.Element.Kind = DisplayElementKind.RecordPreview Then

				Dim el As Element = e.Element
				e.Style.CellValue = "Preview notes for Record (" & el.ParentTableDescriptor.Fields(0).Name & ": " & el.ParentRecord.GetValue(el.ParentTableDescriptor.Fields(0).Name) & ")"
				e.Style.BackColor = Color.MistyRose
				e.Handled = True
			End If
		End Sub


		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs) Handles gridGroupingControl1.QueryCellStyleInfo
			If e.TableCellIdentity.TableCellType = GridTableCellType.RecordPreviewCell Then
				Dim el As Element = e.TableCellIdentity.DisplayElement
				e.Style.CellValue = "Preview notes for Record (" & el.ParentTableDescriptor.Fields(0).Name & ": " & el.ParentRecord.GetValue(el.ParentTableDescriptor.Fields(0).Name) & ")"
			End If
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupPreviewCell Then
				Dim el As Element = e.TableCellIdentity.DisplayElement
				e.Style.CellValue = "Preview notes for Group (" & el.ParentGroup.Name & ": " & el.ParentGroup.Category.ToString() & ")"
			End If
		End Sub


		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			If Me.comboBox1.SelectedIndex = 1 Then
				Me.checkBox3.Checked = False
			Else
				Me.checkBox3.Checked = True
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If checkBox1.Checked Then
				Me.checkBox4.Enabled = True
				Me.checkBox4.Checked = True
			Else
				Me.checkBox4.Checked = False
				Me.checkBox4.Enabled = False
			End If
		End Sub

		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.checkBox2.Checked Then
				Me.checkBox3.Enabled = True
				If comboBox1.SelectedIndex = 0 Then
					Me.checkBox3.Checked = True
				Else
					Me.checkBox3.Checked = False
				End If
			Else
				Me.checkBox3.Checked = False
				Me.checkBox3.Enabled = False
			End If
		End Sub


	End Class
End Namespace
