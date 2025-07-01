Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports System.Collections.Specialized
Imports System.Collections

Namespace DropDownCellDemo
	Partial Public Class Form1
		Inherits MetroForm
		Friend dataSet11 As DataSet1
		Public Sub New()
			dataSet11 = New DataSet1()
			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			' read the data from a local XML file
			ReadXml(Me.dataSet11, "GDBDdata.XML")

			InitializeGrid()
		End Sub

		#Region "XML and Icon handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		'hunt the folder tree for the data\*.xml file..
		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			If ds Is Nothing Then
				Return
			End If

			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
		End Sub

		#End Region

		Private Sub InitializeGrid()
			Me.gridControl1.BeginUpdate()

'			#Region "Cell Styles"
			gridControl1.TableStyle.FloatCell = True
			gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation
			gridControl1.ColWidths(3) *= 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount))
			gridControl1(1, 1).CellValue = "DropDown Cells"
			gridControl1(1, 1).Font.Size = 14
			gridControl1(1, 1).Font.Bold = True
			gridControl1(1, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(1, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(1, 1).CellType = "Static"
			AddHandler gridControl1.CheckBoxClick, AddressOf gridControl1_CheckBoxClick
'			#End Region

'			#Region "DataSources"
			Dim items As New StringCollection()
			items.Add("One")
			items.Add("Two")
			items.Add("Three")
			items.Add("Four")
			items.Add("Five")
			items.Add("Six")
			items.Add("Seven")
			items.Add("Eight")
			items.Add("Nine")
			items.Add("Ten")
			Dim imageList As New ImageList()
			imageList.Images.Add(SystemIcons.Warning.ToBitmap())
			imageList.Images.Add(SystemIcons.Application.ToBitmap())
			imageList.Images.Add(SystemIcons.Asterisk.ToBitmap())
			imageList.Images.Add(SystemIcons.Error.ToBitmap())
			imageList.Images.Add(SystemIcons.Information.ToBitmap())
			imageList.Images.Add(SystemIcons.Question.ToBitmap())
			Me.gridControl1.TableStyle.ImageList = imageList

			Dim icons As New ArrayList()
			icons.Add(New IconDesc("Warning", "WA", 0))
			icons.Add(New IconDesc("Application", "AP", 1))
			icons.Add(New IconDesc("Asterisk", "AS", 2))
			icons.Add(New IconDesc("Error", "ER", 3))
			icons.Add(New IconDesc("Information", "INF", 4))
			icons.Add(New IconDesc("Question", "QUE", 5))

'			#End Region

'			#Region "ComboBox Cells"
			Dim rowIndex As Integer = 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "ComboBox with AutoComplete in Editmode"
			gridControl1(rowIndex, 1).Font.Bold = True
			AddChoices(rowIndex, "ComboBox", items, Nothing, "", "")
			For i As Integer = 5 To 8
				Me.gridControl1.HideRows(i) = True
			Next i

			' ComboBox using ChoiceList
			rowIndex = 10
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "ComboBox using ChoiceList"
			gridControl1(rowIndex, 1).Font.Bold = True
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)
			AddEntries(rowIndex, "ComboBox", items, Nothing, "", "")
			For i As Integer = 11 To 19
				Me.gridControl1.HideRows(i) = True
			Next i

			 'ComboBox using Datasource";
			rowIndex = 21
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "ComboBox using Datasource, DisplayMember = CompanyName"
			gridControl1(rowIndex, 1).Font.Bold = True
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)
			AddEntries(rowIndex, "ComboBox", Nothing, dataSet11.Customers, "CustomerID", "CompanyName")
			For i As Integer = 22 To 30
				Me.gridControl1.HideRows(i) = True
			Next i

			rowIndex = 32
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "ComboBox using Datasource, ValueMember = empty "
			gridControl1(rowIndex, 1).Font.Bold = True
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)
			AddEntries(rowIndex, "ComboBox", Nothing, dataSet11.Customers, "", "CompanyName")
			For i As Integer = 33 To 41
				Me.gridControl1.HideRows(i) = True
			Next i

			rowIndex = 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, 1).Text = "ComboBox Cells :    Following Categories illustrates the features supported by a ComboBox cell"
			gridControl1(rowIndex, 1).TextColor = Color.Black
			gridControl1(rowIndex, 1).Font.Bold = True

'			#End Region

'			#Region "GridListControl Cells"
			rowIndex = 46
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "GridListControl using Datasource, DisplayMember = CompanyName"
			gridControl1(rowIndex, 1).Font.Bold = True
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)
			AddEntries(rowIndex, "GridListControl", Nothing, dataSet11.Customers, "CustomerID", "CompanyName")
			For i As Integer = 47 To 55
				Me.gridControl1.HideRows(i) = True
			Next i

			rowIndex = 57
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "GridListControl using Datasource, ValueMember = empty"
			gridControl1(rowIndex, 1).Font.Bold = True
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)
			AddEntries(rowIndex, "GridListControl", Nothing, dataSet11.Customers, "", "CompanyName")
			For i As Integer = 58 To 66
				Me.gridControl1.HideRows(i) = True
			Next i


			rowIndex = 68
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "GridListControl showing ArrayList with Icons"
			gridControl1(rowIndex, 1).Font.Bold = True
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)
			AddEntries(rowIndex, "GridListControl", Nothing, icons, "", "LongName")
			For i As Integer = 69 To 77
				Me.gridControl1.HideRows(i) = True
			Next i

			rowIndex = 43
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, 1).Text = "GridListControl Cells :    Following Categories illustrates the features supported by a GridListControl cell"
			gridControl1(rowIndex, 1).TextColor = Color.Black
			gridControl1(rowIndex, 1).Font.Bold = True
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).Text = "GridListControl using ChoiceList : Not Supported"
			gridControl1(rowIndex, 1).Font.Bold = True


'			#End Region

'			#Region "MonthCalendar Cells"
			rowIndex = 79
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 4))
			gridControl1(rowIndex, 1).Text = "DropDown Calendar Cells"
			gridControl1(rowIndex, 1).TextColor = Color.Black
			gridControl1(rowIndex, 1).Font.Bold = True
			rowIndex += 1
			gridControl1(rowIndex, 1).CellType = "MonthCalendar"
			gridControl1(rowIndex, 1).CellValue = DateTime.Now
			gridControl1(rowIndex, 1).Font.Size = 8
			gridControl1(rowIndex, 3).CellType = "MonthCalendar"
			gridControl1(rowIndex, 3).CellValue = DateTime.Now
			gridControl1(rowIndex, 3).Font.Size = 8
			gridControl1.RowHeights(rowIndex) = gridControl1.DefaultRowHeight - 2

            '			#End Region

            rowIndex = 79
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex, gridControl1.ColCount))
            gridControl1(rowIndex, 5).Text = "DropDown ColorEdit Cells"
            gridControl1(rowIndex, 5).TextColor = Color.Black
            gridControl1(rowIndex, 5).Font.Bold = True
            rowIndex += 1
            gridControl1(rowIndex, 5).CellType = GridCellTypeName.ColorEdit
            gridControl1(rowIndex, 5).TextColor = Color.Black
            gridControl1(rowIndex, 5).Font.Size = 8
            gridControl1(rowIndex, 7).CellType = GridCellTypeName.ColorEdit
            gridControl1(rowIndex, 7).TextColor = Color.Black
            gridControl1(rowIndex, 7).Font.Size = 8
            gridControl1.RowHeights(rowIndex) = gridControl1.DefaultRowHeight

'			#Region "RichTextCells"
			rowIndex = 82
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "Rich Text Cells :    Check this to view a drop-down menu which displays formatting helpers to modify the text"
			gridControl1(rowIndex, 1).TextColor = Color.Black
			gridControl1(rowIndex, 1).Font.Bold = True
			rowIndex = 83
				' font table
				' color table
				' first line
				' second line
				' third line
				' fourth line
				' closing bracket
			rtf2 = "{\rtf1\ansi" & "{\fonttbl" & "\f0\froman Times New Roman; " & "\f1\fdecor Courier New; " & "\f2\fswiss Arial;} " & "\deff0 " & "{\colortbl" & "\red250\green177\blue146; " & "\red229\green 118\blue145; " & "\red101\green121\blue219; " & "\red240\green224\blue255;} " & "\highlight2\cb1\qc\cf0\f0\fs20 12 point, Times New Roman, " & "red, centered\plain\par" & "\highlight0\ql\cf3\f1\fs28 14 point, Courier New, blue, " & "left aligned\plain\par" & "\highlight1\qr\cf0\f2\fs36 18 point, Arial, black, " & "right aligned\plain\par" & "\qc Default font and color, \b Bold\plain , \ul Underline\plain , \i Italic \plain\par" & "}"
			gridControl1(rowIndex, 1).CellType = "RichText"
			gridControl1(rowIndex, 1).Text = rtf2
			gridControl1.RowHeights(rowIndex) = 150
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 5))
			Me.gridControl1.HideRows(rowIndex) = True
'			#End Region

			Me.gridControl1.EndUpdate(True)
		End Sub
		Private rtf2 As String

		#Region "EventHandlers"
		Private Sub gridControl1_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			Me.gridControl1.BeginUpdate()

			Select Case e.RowIndex
				Case 4
					For i As Integer = 5 To 8
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 10
					For i As Integer = 11 To 19
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 21
					For i As Integer = 22 To 30
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 32
					For i As Integer = 33 To 41
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 46
					For i As Integer = 47 To 55
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 57
					For i As Integer = 58 To 66
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 68
					For i As Integer = 69 To 77
						Me.gridControl1.HideRows(i) = Not Me.gridControl1.HideRows(i)
					Next i
				Case 82
					Me.gridControl1.HideRows(e.RowIndex + 1) = Not Me.gridControl1.HideRows(e.RowIndex + 1)
			End Select

			Me.gridControl1.EndUpdate(True)
			Me.gridControl1.Refresh()
		End Sub

		#End Region

		#Region "HelperMethods"
		Private Sub AddChoices(ByRef rowIndex As Integer, ByVal cellType As String, ByVal items As StringCollection, ByVal dataSource As Object, ByVal valueMember As String, ByVal displayMember As String)
			gridControl1.DiscardReadOnly = True

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "AutoComplete "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).AutoCompleteInEditMode = GridComboSelectionOptions.AutoComplete
			gridControl1(rowIndex, 3).ChoiceList = items
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "AutoSuggest "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).AutoCompleteInEditMode = GridComboSelectionOptions.AutoSuggest
			gridControl1(rowIndex, 3).ChoiceList = items
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Both "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).AutoCompleteInEditMode = GridComboSelectionOptions.Both
			gridControl1(rowIndex, 3).ChoiceList = items
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "None "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).AutoCompleteInEditMode = GridComboSelectionOptions.None
			gridControl1(rowIndex, 3).ChoiceList = items
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If
			rowIndex += 1
		End Sub

		Private Sub AddEntries(ByRef rowIndex As Integer, ByVal cellType As String, ByVal items As StringCollection, ByVal dataSource As Object, ByVal valueMember As String, ByVal displayMember As String)
			gridControl1.DiscardReadOnly = True

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Editable "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "AutoComplete "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.AutoComplete
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Exclusive "
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Exclusive
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Not clickable"
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).Clickable = False
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Disabled"
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).Enabled = False
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Hide Buttons"
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).ShowButtons = GridShowButtons.Hide
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Buttons when editing"
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			gridControl1(rowIndex, 3).ShowButtons = GridShowButtons.ShowCurrentCellEditing
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Read-only"
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).ChoiceList = items
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable
			If dataSource IsNot Nothing Then
				gridControl1(rowIndex, 3).DataSource = dataSource
				gridControl1(rowIndex, 3).DisplayMember = displayMember
				gridControl1(rowIndex, 3).ValueMember = valueMember
			End If
			gridControl1(rowIndex, 3).ReadOnly = True

			rowIndex += 1
			gridControl1(rowIndex, 1).Text = "Empty"
			gridControl1(rowIndex, 3).CellType = cellType
			gridControl1(rowIndex, 3).DropDownStyle = GridDropDownStyle.Editable

			rowIndex += 1

			gridControl1.DiscardReadOnly = False
		End Sub
		#End Region
	End Class

	#Region "IconClass"
	<Serializable> _
	Public Class IconDesc
		Private myShortName As String
		Private myLongName As String
		Private _imageIndex As Integer

		Public Sub New(ByVal strLongName As String, ByVal strShortName As String, ByVal _imageIndex As Integer)
			Me.myShortName = strShortName
			Me.myLongName = strLongName
			Me._imageIndex = _imageIndex
		End Sub

		Public ReadOnly Property ShortName() As String
			Get
				Return myShortName
			End Get
		End Property

		Public ReadOnly Property LongName() As String

			Get
				Return myLongName
			End Get
		End Property

		Public Property ImageIndex() As Integer
			Get
				Return _imageIndex
			End Get
			Set(ByVal value As Integer)
				_imageIndex = value
			End Set
		End Property


		Public Overrides Function ToString() As String
			Return Me.ShortName & " - " & Me.LongName
		End Function
	End Class
	#End Region
End Namespace
