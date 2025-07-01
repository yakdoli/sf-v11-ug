Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics

Namespace GridSample
	''' <summary>
	''' Summary description for MainForm.
	''' </summary>
	Public Class MainForm
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private splitterControl1 As Syncfusion.Windows.Forms.SplitterControl
		Private dataSet11 As DataSet1
		Private form As Form1

		Public Sub New(ByVal form As Form1)
			Me.form = form
			Me.gridControl1 = form.gridControl1
			Me.splitterControl1 = form.splitterControl1
			Me.dataSet11 = form.dataSet11
			InitializeForm()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If
            Dim form As New Form1()
            Dim main As New MainForm(form)
            Application.Run(form)
        End Sub

		Private Sub InitializeForm()
			form.Text = "Grid Control Event Logger Demo"

			gridControl1.BeginUpdate()
			gridControl1.TableStyle.FloatCell = True
			gridControl1.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation
			'gridControl1.FloatingCells.DelayFloatCells(GridRangeInfo.Table());
			gridControl1.ColWidths(3) *= 2

			Dim rowIndex As Integer = 2

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

			rowIndex = 1
			gridControl1(rowIndex, 1).Text = "CellTypes"
			
			
			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "CheckBox"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.ColorEdit
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "ColorEdit"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.ComboBox
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "ComboBox"
			gridControl1(rowIndex, 2).DataSource = items
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			Dim be As New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.Control
			gridControl1(rowIndex, 2).Control = be
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "Control"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.Currency
			gridControl1(rowIndex, 2).CellValue = "5.0"
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "Currency"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.DropDownGrid
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "DropDownGrid"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = "Static"
			gridControl1(rowIndex, 2).CellValue = 5
			gridControl1(rowIndex, 3).CellType = "Static"
			gridControl1(rowIndex, 3).CellValue = 10
			gridControl1(rowIndex, 4).CellType = GridCellTypeName.FormulaCell
			Dim str As String = "= B" & rowIndex.ToString() & " + C" & rowIndex.ToString()
			gridControl1(rowIndex, 4).CellValue = str
			gridControl1(rowIndex, 1).Text = "Formula Cell"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.GridListControl
			gridControl1(rowIndex, 2).DataSource = dataSet11.Customers
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).Text = "GridListControl"
			gridControl1(rowIndex, 2).ValueMember = "CustomerID"
			gridControl1(rowIndex, 2).DisplayMember = "CustomerID"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.Image
			gridControl1(rowIndex, 2).ImageList = imageList
			gridControl1(rowIndex, 2).ImageIndex = 0
			gridControl1(rowIndex, 1).Text = "Image"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.MaskEdit
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "MaskEdit"
			gridControl1(rowIndex, 2).MaskEdit.Mask = "(99)-(99)-(9999)"
			gridControl1(rowIndex, 2).Text = "12345678"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.MonthCalendar
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "MonthCalendar"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.NumericUpDown
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "NumericUpDown"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.OriginalTextBox
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "OriginalTextBox"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.ProgressBar
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "ProgressBar"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)


			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, 2).Description = "PushButton"
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "PushButton"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			Dim sc As New StringCollection()
			sc.AddRange(New String() { "radio 0", "radio 1"})
			gridControl1(rowIndex, 2).ChoiceList=sc
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.RadioButton
			gridControl1(rowIndex, 2).CellValue = 1
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).Text = "RadioButton"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			rowIndex += 1
			gridControl1(rowIndex, 2).CellType = GridCellTypeName.RichText
			gridControl1(rowIndex, 2).Text = "This is RichTextBox Cell"
			gridControl1(rowIndex, 1).CellType = "Static"
			gridControl1(rowIndex, 1).BaseStyle = "Heading 2"
			gridControl1(rowIndex, 1).Text = "RichText"
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells)

			gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.None
			gridControl1.EndUpdate(True)

			gridControl1.ForceCurrentCellMoveTo = True
			gridControl1.CurrentCell.MoveTo(4, 3)
			form.ShowPropertyGridItem("Data", "ValueMember")

			gridControl1.RowHeights(1) = 30
			AddHandler gridControl1.PrepareViewStyleInfo, AddressOf gridControl1_PrepareViewStyleInfo
			AddHandler gridControl1.CurrentCellCloseDropDown, AddressOf gridControl1_CurrentCellCloseDropDown
		End Sub

		Private Sub gridControl1_CurrentCellCloseDropDown(ByVal sender As Object, ByVal e As PopupClosedEventArgs)
			Dim gcc As GridCurrentCell = Me.gridControl1.CurrentCell
			If gridControl1(gcc.RowIndex, gcc.ColIndex).CellType Is "DropDownGrid" Then
				gridControl1.Refresh()
			End If
		End Sub

		Private Sub gridControl1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
			If e.RowIndex = 1 AndAlso e.ColIndex = 1 Then
				e.Style.TextColor = Color.Black 'Color.FromArgb( 0xde, 0x64, 0x13 );
				e.Style.Font.Facename = "Arial"
				e.Style.Font.Size = 12
				e.Style.Font.Bold = True
			ElseIf e.RowIndex > 1 AndAlso e.ColIndex = 1 Then
				e.Style.TextColor = Color.Orange 'Color.FromArgb( 0xde, 0x64, 0x13 );
				e.Style.Font.Facename = "Arial"
				e.Style.Font.Size = 10
				e.Style.Font.Bold = True
			End If
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
			gridControl1(rowIndex, 1).Text = "Autocomplete "
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
			gridControl1(rowIndex, 1).Text = "Readonly"
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

	End Class


    <Serializable()> _
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
End Namespace
