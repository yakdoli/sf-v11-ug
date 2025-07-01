Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
Imports System.Runtime.Serialization

Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace DropDownCellDemo

	' The model class is mainly derived to make
	' CreateRenderer return our derived renderer class.
	' Here we add an internal member, ddForm, to hold our Form
	' that we want to show in our popup. We set this member
	' in the constructor call. We also override OnQueryPrefferedClientSize
	' to allow for the button during optimal sizing calls.

	Public Class DropDownFormCellModel
		Inherits GridStaticCellModel
		Friend ddForm As DropDownForm

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		' sets ddForm and also reserves space for our button...
		Public Sub New(ByVal grid As GridModel, ByVal ddForm As DropDownForm)
			MyBase.New(grid)
			Me.ddForm = ddForm
			ButtonBarSize = New Size(14, 18)
		End Sub

		'note that this method create our new derived renderer
		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New DropDownFormCellRenderer(control, Me)
		End Function

		'used to provide optimal height and width for cell (as in grid.ColWidths.ResizeToFit calls)
		Protected Overrides Function OnQueryPrefferedClientSize(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal queryBounds As GridQueryBounds) As Size
			Dim sz As Size = MyBase.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds)

			'adjust to allow for button width
			sz.Width = sz.Width + ButtonBarSize.Width

			Return sz
		End Function

	End Class


	' The renderer class handles the UI part of the cell
	' functionality. We use the constructor add the button,
	' cashe a reference to the cell model's form member.
	' The only method overridden is the OnButtonClicked which
	' is hit when the user clicks the button we added. In this 
	' method, we drop the form using ShowDialog. Upon return,
	' based on DialogResult, the changed values may be saved.

	Public Class DropDownFormCellRenderer
		Inherits GridStaticCellRenderer
		Friend ddForm As DropDownForm

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			Me.ddForm = (CType(Me.Model, DropDownFormCellModel)).ddForm

			Me.AddButton(New GridCellComboBoxButton(Me))

		End Sub

		Protected Overrides Sub OnButtonClicked(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal button As Integer)
			Me.Grid.CurrentCell.MoveTo(rowIndex, colIndex)
			'Console.WriteLine("clicked ({0},{1})", rowIndex, colIndex);

			Me.ddForm.SetValuesFromString(Me.Grid.Model(rowIndex, colIndex).Text)
			Dim rect As Rectangle = Me.Grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, colIndex))

			Me.ddForm.Location = Me.Grid.PointToScreen(New Point(rect.Left, rect.Bottom))

			If Me.ddForm.ShowDialog() = DialogResult.OK Then
				Me.Grid.Model(rowIndex, colIndex).Text = Me.ddForm.GetValuesToString()
			End If
			'base.OnButtonClicked (rowIndex, colIndex, button);
		End Sub


	End Class
End Namespace