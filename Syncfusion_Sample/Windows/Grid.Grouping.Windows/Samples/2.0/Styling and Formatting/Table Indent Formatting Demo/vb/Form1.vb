Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace NestedTables
	''' <summary>
	''' This sample demonstrates how to manually specify master-details relations 
	''' between three separate tables that primary keys and foreign key columns
	''' in common. 
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private panel1 As Panel
		Private propertyGrid1 As PropertyGrid
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridGroupingControl1.Appearance.AlternateRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.AnyCell.TextColor = System.Drawing.Color.MidnightBlue
            Me.gridGroupingControl1.Appearance.AnyIndentCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.gridGroupingControl1.BackColor = System.Drawing.Color.White
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = False
            Me.gridGroupingControl1.Size = New System.Drawing.Size(329, 301)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordRowHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordRowHeaderCell.TextColor = System.Drawing.SystemColors.ControlText
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(346, 20)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 286)
            Me.panel1.TabIndex = 22
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(353, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(203, 313)
            Me.propertyGrid1.TabIndex = 21
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(566, 325)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table Indent Formatting Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim parentTable As DataTable = GetParentTable()
			Dim childTable As DataTable = GetChildTable()
			Dim grandChildTable As DataTable = GetGrandChildTable()

			' Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
			' This is the same approach that should be used if you want to set up relation ships
			' between independent IList.
			Dim parentToChildRelationDescriptor As New GridRelationDescriptor()
			parentToChildRelationDescriptor.ChildTableName = "MyChildTable" ' same as SourceListSetEntry.Name for childTable (see below)
			parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID")

			' Add relation to ParentTable 
			gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)

			Dim childToGrandChildRelationDescriptor As New GridRelationDescriptor()
			childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable" ' same as SourceListSetEntry.Name for grandChhildTable (see below)
			childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID")

			' Add relation to ChildTable 
			parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)


			' Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable)

			Me.gridGroupingControl1.DataSource = parentTable

			Me.gridGroupingControl1.TableOptions.ShowRowHeader = False
			Me.gridGroupingControl1.GetTableDescriptor("MyChildTable").TableOptions.ShowTableIndent = False
			Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Themed=False
			Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.BorderMargins = New Syncfusion.Windows.Forms.Grid.GridMarginsInfo(3, 3, 3, 3)

			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
			AddHandler gridGroupingControl1.TableControlCellButtonClicked, AddressOf gridGroupingControl1_TableControlCellButtonClicked
			Me.gridGroupingControl1.Table.ExpandAllRecords()
		End Sub

		Private Sub gridGroupingControl1_TableControlCellButtonClicked(ByVal sender As Object, ByVal e As GridTableControlCellButtonClickedEventArgs)
			Dim style As GridTableCellStyleInfo = Me.gridGroupingControl1.Table.GetTableCellStyle(e.Inner.RowIndex, e.Inner.ColIndex)
			If style.TableCellIdentity Is Nothing Then
				Return
			End If

			If style.TableCellIdentity.TableCellType = GridTableCellType.RecordPlusMinusCell Then
				If style.TableCellIdentity.DisplayElement.Kind = DisplayElementKind.NestedTable Then
					' NestedTable
					Dim nt As GridNestedTable = CType(style.TableCellIdentity.DisplayElement, GridNestedTable)

					For Each el As Element In nt.ChildTable.Elements
						If el.Kind = DisplayElementKind.Record Then
							 If style.TableCellIdentity.RowIndex = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el) Then
								 Dim r As Record = Record.GetParentRecord(el)
								 Dim shouldExpand As Boolean = Not r.IsExpanded
								 Me.gridGroupingControl1.Table.CurrentRecord = r
								 r.IsExpanded = shouldExpand
								 e.Inner.Cancel = True
							 End If
						End If
					Next el
				End If
			End If
		End Sub


		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)

			If e.TableCellIdentity.TableCellType = GridTableCellType.NestedTableIndentCell Then
				If e.TableCellIdentity.DisplayElement.Kind = DisplayElementKind.NestedTable Then
					' NestedTable
					Dim nt As GridNestedTable = CType(e.TableCellIdentity.DisplayElement, GridNestedTable)

					For Each el As Element In nt.ChildTable.Elements
						If el.Kind = DisplayElementKind.Record Then

							If e.TableCellIdentity.RowIndex = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el) Then
								Dim r As Record = Record.GetParentRecord(el)
								e.TableCellIdentity.TableCellType = GridTableCellType.RecordPlusMinusCell
								If r.IsExpanded Then
									e.Style.Description = "-"
								Else
									e.Style.Description = "+"
								End If
								e.Style.BorderMargins = New Syncfusion.Windows.Forms.Grid.GridMarginsInfo(3, 3, 3, 3)
								e.Style.Themed = False
								e.Style.Enabled = True
							End If
						End If

					Next el
				End If
			End If

		End Sub

		Private numberParentRows As Integer = 5
		Private numberChildRows As Integer = 20
		Private numberGrandChildRows As Integer = 50
		Private Function GetParentTable() As DataTable
			Dim dt As New DataTable("ParentTable")


			dt.Columns.Add(New DataColumn("parentID")) 'lower case p
			dt.Columns.Add(New DataColumn("ParentName"))
			dt.Columns.Add(New DataColumn("ParentAddr"))
			dt.Columns.Add(New DataColumn("ParentDesc"))

			For i As Integer = 0 To numberParentRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i '.ToString();
				dr(1) = String.Format("parentName{0}", i)
				dr(2) = String.Format("parentAddr{0}", i)
				dr(3) = String.Format("parentDesc{0}", i)
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetChildTable() As DataTable
			Dim dt As New DataTable("ChildTable")

			dt.Columns.Add(New DataColumn("childID")) 'lower case c
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ParentID")) 'upper case P

			For i As Integer = 0 To numberChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("ChildName{0}",i)
				dr(2) = (i Mod numberParentRows).ToString()
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetGrandChildTable() As DataTable
			Dim dt As New DataTable("GrandChildTable")

			dt.Columns.Add(New DataColumn("GrandChildID"))
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ChildID")) 'upper case C

			For i As Integer = 0 To numberGrandChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("GrandChildName{0}",i)
				dr(2) = (i Mod numberChildRows).ToString()
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function
	End Class
End Namespace
