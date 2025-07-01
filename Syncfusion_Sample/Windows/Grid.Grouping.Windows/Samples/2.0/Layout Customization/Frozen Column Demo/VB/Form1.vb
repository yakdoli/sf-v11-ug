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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Collections

Namespace ManualRelations
	''' <summary>
	''' This sample demonstrates how to manually specify master-details relations 
	''' between three separate tables that primary keys and foreign key columns
	''' in common. 
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 16)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(673, 410)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(708, 444)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Frozen Column Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
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

			' When freezing columns you have to make sure that the frozen columns 
			' in the nested tables are properly aligned with the parent table. The grid
			' does not support diffent scroll divider x-coordinates for nested tables.
			'
			' The only exception to this rule is if you turn off freezing columns
			' for all nested tables by setting/leaving ChildTableDescriptor.FrozenColumn = ""; (empty string)
			' all together.
			'
			' The TrackWidthOfParentColumn propetry of a column descriptor ensures that 
			' columns are aligned and stay in sync. 

			gridGroupingControl1.TableDescriptor.Columns(0).Width = 200
			gridGroupingControl1.TableDescriptor.Columns(1).Width = 100

			Dim freezeCol As Integer = 1 ' freeze column 0 and 1.

			' specify last column to be frozen.
			gridGroupingControl1.TableDescriptor.FrozenColumn = gridGroupingControl1.TableDescriptor.Columns(freezeCol).Name

			'// synchronize width of columns in child record with width of column in parent record.
			For n As Integer = 0 To freezeCol
				parentToChildRelationDescriptor.ChildTableDescriptor.Columns(n).TrackWidthOfParentColumn = gridGroupingControl1.TableDescriptor.Columns(n).Name
			Next n

			' specify last column to be frozen in child table.
			parentToChildRelationDescriptor.ChildTableDescriptor.FrozenColumn = parentToChildRelationDescriptor.ChildTableDescriptor.Columns(freezeCol).Name

			' same for grandchild table.
			For n As Integer = 0 To freezeCol
				childToGrandChildRelationDescriptor.ChildTableDescriptor.Columns(n).TrackWidthOfParentColumn = parentToChildRelationDescriptor.ChildTableDescriptor.Columns(n).Name
			Next n
			childToGrandChildRelationDescriptor.ChildTableDescriptor.FrozenColumn = childToGrandChildRelationDescriptor.ChildTableDescriptor.Columns(freezeCol).Name
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro

			Me.gridGroupingControl1.Table.ExpandAllRecords()
			' Modeless PropertyGrid Form
			'new GridGroupingControlSchemaBrowser(this.gridGroupingControl1).Show();
		End Sub


#If notused Then
		''' <summary>
		''' Save old width value when column width is changed.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub gridGroupingControl1_PropertyChanging(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
			Dim gcc As GridGroupingControl = CType(sender, GridGroupingControl)
			If e.PropertyName = "TableDescriptor" Then
				Dim tableDescriptor As TableDescriptor = gcc.TableDescriptor
				e = CType(e.Inner, DescriptorPropertyChangedEventArgs)

				If e.PropertyName = "Relations" Then
					e = e.GetNestedChildTableDescriptorEvent(tableDescriptor)
				End If

				Select Case e.PropertyName
					Case "Columns"
							If TypeOf e.Inner Is ListPropertyChangedEventArgs Then
								Dim le As ListPropertyChangedEventArgs = CType(e.Inner, ListPropertyChangedEventArgs)
								If le.Property = "Width" Then
									Dim cd As GridColumnDescriptor = CType(le.Item, GridColumnDescriptor)
									oldWidth = cd.Width
								End If
							End If
							Exit Select
				End Select
			End If
		End Sub

		Private oldWidth As Integer = -1

		''' <summary>
		''' Apply delta of width value to all nested tables to make sure the frozen column
		''' remains aligned.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub gridGroupingControl1_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
			Dim gcc As GridGroupingControl = CType(sender, GridGroupingControl)
			If e.PropertyName = "TableDescriptor" Then
				Dim tableDescriptor As TableDescriptor = gcc.TableDescriptor
				e = CType(e.Inner, DescriptorPropertyChangedEventArgs)

				If e.PropertyName = "Relations" Then
					e = e.GetNestedChildTableDescriptorEvent(tableDescriptor)
				End If

				Select Case e.PropertyName
					Case "Columns"
							If TypeOf e.Inner Is ListPropertyChangedEventArgs Then
								Dim le As ListPropertyChangedEventArgs = CType(e.Inner, ListPropertyChangedEventArgs)
								If le.Property = "Width" Then
									Dim cd As GridColumnDescriptor = CType(le.Item, GridColumnDescriptor)
									AlignColumnWidth(cd, oldWidth)
								End If
							End If
							Exit Select
				End Select
			End If
		End Sub

		Private inAlignColumnWidth As Boolean = False

		Private Sub AlignColumnWidth(ByVal cd As GridColumnDescriptor, ByVal oldWidth As Integer)
			If inAlignColumnWidth Then
				Return
			End If

			inAlignColumnWidth = True

			Try

				Dim delta As Integer = cd.Width - oldWidth

				Dim td As GridTableDescriptor = cd.TableDescriptor
				Dim engine As GridEngine = td.Engine
				Dim gcc As GridGroupingControl = engine.ParentControl

				RecurseAlignColumnWidth(gcc.TableDescriptor, cd, delta)
			Finally
				inAlignColumnWidth = False
			End Try
		End Sub

		Private Sub RecurseAlignColumnWidth(ByVal td As GridTableDescriptor, ByVal cd As GridColumnDescriptor, ByVal delta As Integer)
			If td.FrozenColumn = "" Then
				Return
			End If

			If cd IsNot td.Columns(td.FrozenColumn) Then
				td.Columns(td.FrozenColumn).Width += delta
			End If

			If td.Relations.NestedCount > 0 Then
				For Each rd As GridRelationDescriptor In td.Relations
					If rd.RelationKind = RelationKind.RelatedMasterDetails OrElse rd.RelationKind = RelationKind.UniformChildList Then
						Dim childTableDescriptor As GridTableDescriptor = rd.ChildTableDescriptor
						RecurseAlignColumnWidth(childTableDescriptor, cd, delta)
					End If
				Next rd
			End If
		End Sub
#End If

		Private rnd As New Random()
		Private numberParentRows As Integer = 5
		Private numberChildRows As Integer = 20
		Private numberGrandChildRows As Integer = 50
		Private Function GetParentTable() As DataTable
			Dim dt As New DataTable("ParentTable")


			dt.Columns.Add(New DataColumn("parentID")) 'lower case p
			dt.Columns.Add(New DataColumn("ParentName"))
			dt.Columns.Add(New DataColumn("ParentDec"))
			For n As Integer = 1 To 9
				dt.Columns.Add(New DataColumn("Col " & n.ToString()))
			Next n

			For i As Integer = 0 To numberParentRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i
				dr(1) = String.Format("parentName{0}", i)
				For n As Integer = 1 To 9
					dr(n + 2) = rnd.Next(100)
				Next n
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetChildTable() As DataTable
			Dim dt As New DataTable("ChildTable")

			dt.Columns.Add(New DataColumn("childID")) 'lower case c
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ParentID")) 'upper case P
			For n As Integer = 1 To 9
				dt.Columns.Add(New DataColumn("Col " & n.ToString()))
			Next n

			For i As Integer = 0 To numberChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("ChildName{0}",i)
				dr(2) = (i Mod numberParentRows).ToString()
				For n As Integer = 1 To 9
					dr(n + 2) = rnd.Next(100)
				Next n
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetGrandChildTable() As DataTable
			Dim dt As New DataTable("GrandChildTable")

			dt.Columns.Add(New DataColumn("GrandChildID"))
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ChildID")) 'upper case C
			For n As Integer = 1 To 9
				dt.Columns.Add(New DataColumn("Col " & n.ToString()))
			Next n

			For i As Integer = 0 To numberGrandChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("GrandChildName{0}",i)
				dr(2) = (i Mod numberChildRows).ToString()
				For n As Integer = 1 To 9
					dr(n + 2) = rnd.Next(100)
				Next n
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function
	End Class
End Namespace
