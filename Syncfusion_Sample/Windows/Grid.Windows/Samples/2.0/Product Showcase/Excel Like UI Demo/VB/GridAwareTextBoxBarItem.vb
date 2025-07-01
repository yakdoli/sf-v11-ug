Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Design
Imports Syncfusion.Collections
Imports Syncfusion.ComponentModel
Imports System.Drawing.Design
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Runtime.Serialization
Imports System.Reflection
Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms.Grid


Namespace ExcelLikeUI_2005
	''' <summary>
	''' Summary description for GridAwareTextBoxBarItem.
	''' </summary>
	Public Class GridAwareTextBoxBarItem
		Inherits TextBoxBarItem
		Private gridAwareTextBox As GridAwareTextBox = Nothing
		Private _grid As GridControlBase = Nothing
		Private rangeofgrid As Boolean=False
		Private ignoreSync As Boolean = False

		Public Sub New()
			MyBase.New()

		End Sub

		Public Sub WireGridAwareTextBox(ByVal gridAwareTextBox As GridAwareTextBox, ByVal grid As GridControlBase, ByVal range As Boolean)
			Me._grid = grid
			Me.gridAwareTextBox = gridAwareTextBox
			Me.rangeofgrid=range

			'Assign the current selection range to NameBox
			If rangeofgrid Then
				Me.TextBoxValue = String.Format("R{0}C{0}",grid.CurrentCell.RowIndex,grid.CurrentCell.ColIndex)
			End If

            AddHandler _grid.Model.SelectionChanged, AddressOf Model_SelectionChanged
            AddHandler _grid.CurrentCellMoved, AddressOf _grid_CurrentCellMoved
			AddHandler gridAwareTextBox.TextChanged, AddressOf gridAwareTextBox_TextChanged
        End Sub
        Private Sub _grid_CurrentCellMoved(ByVal sender As Object, ByVal e As GridCurrentCellMovedEventArgs)
            If rangeofgrid Then
                Me.TextBoxValue = String.Format("R{0}C{0}", _grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex)
            End If
        End Sub


		Public Sub UnwireGrid(ByVal grid As GridControlBase)
			Me.gridAwareTextBox.UnwireGrid(grid)
		End Sub


		Public Overrides Property TextBoxValue() As String
			Get
				Return MyBase.TextBoxValue
			End Get
			Set(ByVal value As String)

				If rangeofgrid OrElse ignoreSync Then
					MyBase.TextBoxValue = value
				Else
					If Not Me._grid Is Nothing Then
						'Set textbox value to current cell value
						Dim cc As GridCurrentCell= GetCurrentCell()
						cc.MoveTo(cc.RowIndex,cc.ColIndex,GridSetCurrentCellOptions.ScrollInView)
						Me.gridAwareTextBox.Text = value
						MyBase.TextBoxValue = value
					End If
				End If
			End Set
		End Property

		Private Sub gridAwareTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not rangeofgrid) Then
				ignoreSync = True
				Me.TextBoxValue = Me.gridAwareTextBox.Text
				ignoreSync = False
			End If
		End Sub

		Private Sub Model_SelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs)
			'Change the NameBox value to reflect the current selection range
			If rangeofgrid Then
				Me.TextBoxValue= e.Range.ToString()
			End If
		End Sub

		Private Function GetCurrentCell() As GridCurrentCell
			Dim cc As GridCurrentCell = Nothing
			If TypeOf Me._grid.Parent Is SplitterControl Then
				Dim c As Control = (CType(Me._grid.Parent, SplitterControl)).ActivePane
				If TypeOf c Is GridControlBase Then
					cc = (CType(c, GridControlBase)).CurrentCell
				End If
			End If
			If cc Is Nothing Then
				If Not Me._grid.Model.ActiveGridView Is Nothing Then
					cc = Me._grid.Model.ActiveGridView.CurrentCell
				End If
				If cc Is Nothing Then
					cc = Me._grid.CurrentCell
				End If
			End If
			Return cc
		End Function

	End Class
End Namespace
