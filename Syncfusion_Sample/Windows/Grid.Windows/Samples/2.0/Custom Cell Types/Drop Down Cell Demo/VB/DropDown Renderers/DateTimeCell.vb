Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports System.Windows.Forms
Imports System.Drawing

Namespace DropDownCellDemo
	#Region "the cell model class"
	Public Class DateTimeCellModel
		Inherits GridStaticCellModel
		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)

		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New DateTimeCellRenderer(control, Me)
		End Function
	End Class
	#End Region

	#Region "the cell renderer class"

	Public Class DateTimeCellRenderer
		Inherits GridStaticCellRenderer
		Private dateTimePicker As MyDateTimePicker

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			dateTimePicker = New MyDateTimePicker()

			dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			dateTimePicker.ShowUpDown = False
			dateTimePicker.ShowCheckBox = False
			dateTimePicker.ShowDropButton = True
			dateTimePicker.Border3DStyle = Border3DStyle.Flat

			grid.Controls.Add(dateTimePicker)

			'show & hide to make sure it is initilized properly for teh first use...
			dateTimePicker.Show()
			dateTimePicker.Hide()
			AddHandler Me.Grid.HScrollBar.ValueChanged, AddressOf HScrollBar_ValueChanged
			AddHandler Me.Grid.VScrollBar.ValueChanged, AddressOf VScrollBar_ValueChanged
		End Sub

		Private Sub VScrollBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim row, col As Integer
			Grid.PointToRowCol(dateTimePicker.Location, row, col)
			If (Not Grid.ViewLayout.VisibleCellsRange.IntersectsWith(GridRangeInfo.Cell(row, col))) OrElse (row <= Me.Grid.Model.Rows.HeaderCount) OrElse Not(row.Equals(RowIndex) AndAlso col.Equals(ColIndex)) Then
				Me.dateTimePicker.Hide()
				Me.dateTimePicker.ShowDropButton = False
			Else
				Me.dateTimePicker.Show()
				Me.dateTimePicker.ShowDropButton = True
			End If

		End Sub

		Private Sub HScrollBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim row, col As Integer
			Grid.PointToRowCol(dateTimePicker.Location, row, col)
			If (Not Grid.ViewLayout.VisibleCellsRange.IntersectsWith(GridRangeInfo.Cell(row, col))) OrElse (row <= Me.Grid.Model.Rows.HeaderCount) OrElse Not(row.Equals(RowIndex) AndAlso col.Equals(ColIndex)) Then
				Me.dateTimePicker.Hide()
				Me.dateTimePicker.ShowDropButton = False
			Else
				Me.dateTimePicker.Show()
				Me.dateTimePicker.ShowDropButton = True
			End If

		End Sub

		#Region "usual renderer overrides"

		'handle drawing the cell
		Protected Overrides Sub OnDraw(ByVal g As System.Drawing.Graphics, ByVal clientRectangle As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As Syncfusion.Windows.Forms.Grid.GridStyleInfo)
			If Grid.CurrentCell.HasCurrentCellAt(rowIndex, colIndex) AndAlso CurrentCell.IsEditing Then
				dateTimePicker.Size = clientRectangle.Size
				dateTimePicker.CustomFormat = style.Format
				dateTimePicker.Font = style.GdipFont
				dateTimePicker.Location = clientRectangle.Location
				dateTimePicker.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
				dateTimePicker.Show()
				'if (!dateTimePicker.ContainsFocus)
					'dateTimePicker.Focus();
			Else
				style.TextMargins.Left = 3 'avoid the little jump...
				MyBase.OnDraw(g, clientRectangle, rowIndex, colIndex, style)
			End If
		End Sub

		'set the value into the cell control & initialize it
		Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			' Immeditaly switch into editing mode when cell is initialized.
			Dim style As GridStyleInfo = Grid.Model(rowIndex, colIndex)
			If style.CultureInfo IsNot Nothing Then
				dateTimePicker.Culture = style.CultureInfo
			End If
			dateTimePicker.Value = CDate(style.CellValue)
			CurrentCell.BeginEdit()
			MyBase.OnInitialize(rowIndex, colIndex)
			AddHandler dateTimePicker.ValueChanged, AddressOf datePicker_ValueChanged
			dateTimePicker.ShowDropButton = style.ShowButtons <> GridShowButtons.Hide
			dateTimePicker.Update()
		End Sub

		'save the changes from the cell control to the grid cell
		Protected Overrides Function OnSaveChanges() As Boolean
			If CurrentCell.IsModified Then
				Grid.Focus()
				Dim style As GridStyleInfo = Grid.Model(Me.RowIndex, Me.ColIndex)
				style.CellValue = Me.dateTimePicker.Value

				Return True
			End If
			Return False
		End Function
		'hide the control
		Protected Overrides Sub OnDeactived(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			If dateTimePicker.Visible Then
				Me.dateTimePicker.Hide()

			End If
			RemoveHandler dateTimePicker.ValueChanged, AddressOf datePicker_ValueChanged

		End Sub

		Private Sub datePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			CurrentCell.IsModified = True
		End Sub
		#End Region

		#Region "Click stuff"

		'Simulate a click to place focus where user clicked in the control
		Protected Overrides Sub OnClick(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As MouseEventArgs)
			MyBase.OnClick(rowIndex, colIndex, e)
			If e.Button = MouseButtons.Left Then
				ClickControl()
			End If
		End Sub

		Private t As Timer
		Private Sub ClickControl()
			t = New Timer()
			t.Interval = 20
			AddHandler t.Tick, AddressOf click
			t.Start()
		End Sub

		Private Sub click(ByVal sender As Object, ByVal e As EventArgs)
			t.Stop()
			RemoveHandler t.Tick, AddressOf click
			Dim p As Point = Me.dateTimePicker.PointToClient(Control.MousePosition)
			ActiveXSnapshot.FakeLeftMouseClick(Me.dateTimePicker, p)
			t.Dispose()
			t = Nothing
		End Sub
		#End Region

		'handle initial keystroke on inactive cell, passing it to the datetimepicker
		Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
			If Not dateTimePicker.Focused Then
				dateTimePicker.Focus()
				SendKeys.Send(New String(e.KeyChar, 1))
			End If
			MyBase.OnKeyPress(e)
		End Sub

	End Class

	#End Region

	#Region "derived DateTimePickerExt"
	Public Class MyDateTimePicker
		Inherits Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
		Public keyPressed As Boolean = False

		'pass the enter key back to the grid....
		'and trigger change event on other keystrokes...
		Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
			If keyData = Keys.Enter Then
				Return False
			End If

			If msg.Msg = &H100 AndAlso keyData <> Keys.Tab Then 'keydown...
				Me.OnValueChanged(EventArgs.Empty)
			End If

			Return MyBase.ProcessCmdKey(msg, keyData)
		End Function

	End Class
	#End Region
End Namespace