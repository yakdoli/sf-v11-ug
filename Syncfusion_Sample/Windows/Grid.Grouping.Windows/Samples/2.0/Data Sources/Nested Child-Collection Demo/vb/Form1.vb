#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports System.Diagnostics
Imports Syncfusion.Windows.Forms


Namespace RecursiveNestedCollection
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			'Customize the engine to hide the empty child tables.
			GridEngineFactory.Factory = New GroupingEngineFactory()
			InitializeComponent()

			'Setup Grid
			Dim theList As BaseClassList = CreateDataLists()
			gridGroupingControl1.DataSource = theList

			'Handle this event to hide the +/- on the empty records
			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.Table.ExpandAllRecords()

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


		Public Class BaseClassList
			Inherits List(Of BaseClass)
			Implements ITypedList
			#Region "ITypedList Members"

			Public Function GetItemProperties(ByVal listAccessors() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
				Dim retProperties As New List(Of PropertyDescriptor)()

				If Count > 0 Then
					Dim instance As BaseClass = Me(0)

					' Data
					For Each data As KeyValuePair(Of String, MyData) In instance.Data
						retProperties.Add(New BaseClassMyDataPropertyDescriptor(data.Key))
					Next data

					Dim childKeys As New Dictionary(Of String, String)()

					For n As Integer = 0 To Count - 1
						instance = Me(n)

						' Children - return property descriptors for all possible children here.
						For Each child As KeyValuePair(Of String, List(Of BaseClass)) In instance.ChildTables
							If Not childKeys.ContainsKey(child.Key) Then
								retProperties.Add(New BaseClassChildrenPropertyDescriptor(child.Key))
								childKeys.Add(child.Key, child.Key)
							End If
						Next child
					Next n
				End If

				Return New PropertyDescriptorCollection(retProperties.ToArray())
			End Function

			Public Function GetListName(ByVal listAccessors() As PropertyDescriptor) As String Implements ITypedList.GetListName
				Return Me.GetType().Name
			End Function

			#End Region
		End Class

		Private Function CreateDataLists() As BaseClassList
			Dim list As BaseClassList
			Dim newList As BaseClassList

			'The main list
			list = New BaseClassList()
			list.Add(New FirstClass(Nothing, 0, "row0"))
			list.Add(New FirstClass(Nothing, 1, "row1"))
			list.Add(New FirstClass(Nothing, 2, "row2"))
			list.Add(New FirstClass(Nothing, 3, "row3"))
			list.Add(New FirstClass(Nothing, 4, "row4"))
			newList = list


'			#Region "Child Tables of List[0]"
			'First Child of List[0]
			list = New BaseClassList()
			list.Add(New SecondClass(newList(0), 0, "row0_childtable0_row0"))
			list.Add(New SecondClass(newList(0), 1, "row0_childtable0_row1"))
			list.Add(New SecondClass(newList(0), 2, "row0_childtable0_row2"))
			list.Add(New SecondClass(newList(0), 3, "row0_childtable0_row3"))
			list.Add(New SecondClass(newList(0), 4, "row0_childtable0_row4"))
			list.Add(New SecondClass(newList(0), 5, "row0_childtable0_row5"))
			newList(0).ChildTables.Add("List0_Child0", list)

'				#Region "Child of First Child of List[0]"
				'first child table of first child of base[0]
				list = New BaseClassList()
				list.Add(New SecondClass(newList(0).ChildTables("List0_Child0")(0), 0, "row0_childtable0_row0_childtable0_row0"))
				list.Add(New SecondClass(newList(0).ChildTables("List0_Child0")(0), 1, "row0_childtable0_row0_childtable0_row1"))
				list.Add(New SecondClass(newList(0).ChildTables("List0_Child0")(0), 2, "row0_childtable0_row0_childtable0_row2"))
				list.Add(New SecondClass(newList(0).ChildTables("List0_Child0")(0), 3, "row0_childtable0_row0_childtable0_row3"))
				list.Add(New SecondClass(newList(0).ChildTables("List0_Child0")(0), 4, "row0_childtable0_row0_childtable0_row4"))
				list.Add(New SecondClass(newList(0).ChildTables("List0_Child0")(0), 5, "row0_childtable0_row0_childtable0_row5"))
				newList(0).ChildTables("List0_Child0")(0).ChildTables.Add("List0_NestedChild0", list)
'				#End Region

			'Second Child of List[0]
			list = New BaseClassList()
			list.Add(New FirstClass(newList(0), 0, "row0_childtable1_row0"))
			list.Add(New FirstClass(newList(0), 1, "row0_childtable1_row1"))
			list.Add(New FirstClass(newList(0), 2, "row0_childtable1_row2"))
			list.Add(New FirstClass(newList(0), 3, "row0_childtable1_row3"))
			list.Add(New FirstClass(newList(0), 4, "row0_childtable1_row4"))
			list.Add(New FirstClass(newList(0), 5, "row0_childtable1_row5"))
			newList(0).ChildTables.Add("List0_Child1", list)
'			#End Region

'			#Region "Child Table of List[1]"
			'Child of List[1]
			list = New BaseClassList()
			list.Add(New SecondClass(newList(1), 0, "row2_childtable1_row0"))
			list.Add(New SecondClass(newList(1), 1, "row2_childtable1_row1"))
			list.Add(New SecondClass(newList(1), 2, "row2_childtable1_row2"))
			list.Add(New SecondClass(newList(1), 3, "row2_childtable1_row3"))
			list.Add(New SecondClass(newList(1), 4, "row2_childtable1_row4"))
			list.Add(New SecondClass(newList(1), 5, "row2_childtable1_row5"))
			newList(1).ChildTables.Add("List1_Child0", list)
'			#End Region

			'No Childs for List[2]

'			#Region "Child Tables of List[3]"
			'First Child of List[3]
			list = New BaseClassList()
			list.Add(New FirstClass(newList(3), 0, "row4_childtable0_row0"))
			list.Add(New FirstClass(newList(3), 1, "row4_childtable0_row1"))
			list.Add(New FirstClass(newList(3), 2, "row4_childtable0_row2"))
			list.Add(New FirstClass(newList(3), 3, "row4_childtable0_row3"))
			list.Add(New FirstClass(newList(3), 4, "row4_childtable0_row4"))
			list.Add(New FirstClass(newList(3), 5, "row4_childtable0_row5"))
			newList(3).ChildTables.Add("List3_Child0", list)

			'Second Child of List[3]
			list = New BaseClassList()
			list.Add(New SecondClass(newList(3), 0, "row4_childtable1_row0"))
			list.Add(New SecondClass(newList(3), 1, "row4_childtable1_row1"))
			list.Add(New SecondClass(newList(3), 2, "row4_childtable1_row2"))
			list.Add(New SecondClass(newList(3), 3, "row4_childtable1_row3"))
			list.Add(New SecondClass(newList(3), 4, "row4_childtable1_row4"))
			list.Add(New SecondClass(newList(3), 5, "row4_childtable1_row5"))
			newList(3).ChildTables.Add("List3_Child1", list)
'			#End Region

			'No Childs for List[4]

			Return newList
		End Function

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			If e.TableCellIdentity.TableCellType = GridTableCellType.RecordPlusMinusCell Then
				Dim cell As Element = e.TableCellIdentity.DisplayElement
				Dim r As Record = TryCast(cell.ParentRecord, Record)
				Dim makeStatic As Boolean = True
				If r IsNot Nothing AndAlso r.NestedTables.Count > 0 Then
					For Each nt As NestedTable In r.NestedTables
						If nt.ChildTable.GetFilteredRecordCount() <> 0 Then
							makeStatic = False
						End If
					Next nt
				End If
				If makeStatic Then
					e.Style.CellType = "Static"
					e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(208,215,229))
				End If
			End If
		End Sub
	End Class
End Namespace