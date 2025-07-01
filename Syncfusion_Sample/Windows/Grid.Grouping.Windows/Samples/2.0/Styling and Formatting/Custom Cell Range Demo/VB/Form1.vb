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
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Drawing
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace CellRanges
	Partial Public Class Form1
		Inherits MetroForm
		Private Customers_ContactName As String = "Customers_ContactName"
		Private Employees_Photo As String = "Employees_Photo"
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
		Public Sub New()
			InitializeComponent()

			Dim commandstring1 As String = "select * from Orders"
			Dim commandstring2 As String = "select * from Employees"
			Dim commandstring3 As String = "select * from Customers"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Dim da3 As New SqlCeDataAdapter(commandstring3, connString)
			Try
				da2.Fill(dataSet11, "Employees")
				da3.Fill(dataSet11, "Customers")
				da1.Fill(dataSet11, "Orders")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			Me.gridGroupingControl1.TableOptions.AllowDropDownCell = False
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(Customers_ContactName)
			Me.gridGroupingControl1.TableDescriptor.Columns(Customers_ContactName).HeaderText = "Employee"
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove(Customers_ContactName)

			Me.gridGroupingControl1.TableDescriptor.Columns(Customers_ContactName).GroupByOptions.ShowGroupIndentAsCoveredRange = True
			AddHandler gridGroupingControl1.TableControl.PrepareViewStyleInfo, AddressOf TableControl_PrepareViewStyleInfo

			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Move(gridGroupingControl1.TableDescriptor.VisibleColumns.IndexOf(Employees_Photo), 0)
			AddHandler gridGroupingControl1.TableModel.QueryCoveredRange, AddressOf TableModel_QueryCoveredRange
			AddHandler gridGroupingControl1.TableControlCellDrawn, AddressOf gridGroupingControl1_TableControlCellDrawn

			Me.gridGroupingControl1.Table.ExpandAllGroups()

			Me.gridGroupingControl1.IntelliMousePanning = True

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub
		Private Shared Function FindFile(ByVal fileName As String) As String
			' Check both in parent folder and Parent\Data folders.
			Dim dataFileName As String = "Common\Data\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(fileName) Then
					Return New FileInfo(fileName).FullName
				End If
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				fileName = "..\" & fileName
				dataFileName = "..\" & dataFileName
			Next n

			Return fileName
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


		Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
			If ex.Number = 11001 Then
				MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 208 Then
				MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 156 OrElse ex.Number = 102 Then
				MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

		End Sub

		#Region "Employees_Photo Column Covered Range"
		''' <summary>
		''' Helper routine for drawing picture in covered range of column Employees_Photo.
		''' </summary>
		Private Sub TableModel_QueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
			Dim model As GridTableModel = CType(sender, GridTableModel)
			Dim table As GridTable = model.Table

			If e.RowIndex < table.DisplayElements.Count Then
				' Get the element displayed at the row
				Dim el As Element = table.DisplayElements(e.RowIndex)

				' Check if element is a record (could also be a column header or group caption ...)
				If Element.IsRecord(el) AndAlso el.ParentGroup IsNot Nothing Then
					Dim style As GridTableCellStyleInfo = model(e.RowIndex, e.ColIndex)
					Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity
					' The cell identity contains column information. We check if the column is Employees_Photo
					If id.Column IsNot Nothing AndAlso id.Column.MappingName = Employees_Photo Then
						Dim group As Group = el.ParentGroup

						' Grouped by Customers_ContactName - Do not cover cells if not grouped by Employee ...
						If group IsNot Nothing AndAlso group.CategoryColumns.Count > 0 AndAlso group.CategoryColumns(0).Name = Customers_ContactName Then
							Dim tablePos As Integer = table.DisplayElements.IndexOf(group)
							Dim firstRow As Integer = tablePos + 1
							Dim lastRow As Integer = tablePos + group.GetVisibleCount() - 1
							e.Range = GridRangeInfo.Cells(firstRow, e.ColIndex, lastRow, e.ColIndex)
							gridGroupingControl1.TableModel.CoveredRanges.Add(e.Range)
							e.Handled = True
						End If
					End If
				End If
			End If
		End Sub

		''' <summary>
		''' Helper routine for drawing picture in covered range of column Employees_Photo.
		''' </summary>
		Private Sub gridGroupingControl1_TableControlCellDrawn(ByVal sender As Object, ByVal e As GridTableControlDrawCellEventArgs)
			Dim style As GridTableCellStyleInfo = CType(e.Inner.Style, GridTableCellStyleInfo)
			Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity

			' Employees_Photo column
			If id.Column IsNot Nothing AndAlso id.Column.MappingName = Employees_Photo Then
				Dim group As Group = id.DisplayElement.ParentGroup

				' Grouped by Customers_ContactName
				If group IsNot Nothing AndAlso group.CategoryColumns.Count > 0 AndAlso group.CategoryColumns(0).Name = Customers_ContactName Then
					If group.Records.Count > 0 Then
						Dim r As Record = group.Records(0)

						Dim value As Object = r.GetValue(id.Column.FieldDescriptor)

						' Should be byte[] (image stream ...)
						Dim byteStream() As Byte = TryCast(value, Byte())

						If byteStream IsNot Nothing Then
							Dim graphics As Graphics = e.Inner.Graphics
							Dim image As Image = GridImageUtil.ConvertToImage(byteStream)
							Dim bounds As Rectangle = e.Inner.Bounds
							bounds = GridMargins.RemoveMargins(bounds, style.TextMargins.ToMargins())
							bounds = GridMargins.RemoveMargins(bounds, style.BorderMargins.ToMargins())
							style.ImageSizeMode = GridImageSizeMode.CenterImage
							GridImageUtil.DrawImage(image, bounds, graphics, bounds, style, False)
							e.Inner.Cancel = True ' signals you did your own drawing.
						End If
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "Rotated EmployeeName in Indent column"
		Private Sub TableControl_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
			Dim style As GridTableCellStyleInfo = CType(e.Style, GridTableCellStyleInfo)
			Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity
			' Cell identity contains information about the cell (element, column etc.)

			' Check if this is a indent cell
			If id.TableCellType = GridTableCellType.GroupIndentCell Then
				Dim group As Group = id.DisplayElement.ParentGroup

				' Check if this is the indent of a Categories_CategoryName group.
				If group IsNot Nothing AndAlso group.CategoryColumns.Count > 0 AndAlso group.CategoryColumns(0).Name = Customers_ContactName Then
					' And if the group is not empty ...
					If group.Records.Count > 0 Then
						' Get the category name from the first record
						Dim r As Record = group.Records(0)
						Dim value As Object = r.GetValue(Customers_ContactName)

						' Should be a string
						Dim empName As String = TryCast(value, String)

						' Assign the name to the CellValue of the Indent cell and also adjust the font, color and other style settings.
						If empName IsNot Nothing Then
							style.Interior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(219, 226, 242), Color.FromArgb(255, 187, 111))
							style.CellValue = empName
							style.CellType = "Static"
							style.HorizontalAlignment = GridHorizontalAlignment.Center
							style.VerticalAlignment = GridVerticalAlignment.Middle
							style.Trimming = StringTrimming.EllipsisCharacter
							style.Font.Bold = True
							style.Font.Italic = True
							style.Font.Orientation = 270
						End If
					End If
				End If
			End If
			If e.Style.CellType.ToString() = "Image" Then
				e.Style.ImageSizeMode = GridImageSizeMode.StretchImage
			End If
		End Sub
		#End Region
	End Class
End Namespace