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
	' Here we add an internal member, ddUser, to hold our UserControl
	' that we want to show in our popup. We set this member
	' in the constructor call. 

	Public Class DropDownUserCellModel
		Inherits GridStaticCellModel
		Friend ddUser As DropDownUser

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			ButtonBarSize = New Size(14, 14)
		End Sub

		Public Sub New(ByVal grid As GridModel, ByVal ddUser As DropDownUser)
			MyBase.New(grid)
			Me.ddUser = ddUser
			ButtonBarSize = New Size(14, 14)
		End Sub

		'note that this method create our new derived renderer
		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New DropDownUserCellRenderer(control, Me)
		End Function
	End Class

	'The renderer class. The constructor caches a reference to the UserControl,
	'adds the button, disables the text box from being typed into, and 
	'subscribes to Save and Cancel events on teh User Control.

	Public Class DropDownUserCellRenderer
		Inherits GridStaticCellRenderer
		Friend ddUser As DropDownUser

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			Me.ddUser = (CType(Me.Model, DropDownUserCellModel)).ddUser
			Me.ddUser.Visible = False
			DropDownPart = New GridDropDownCellImp(Me)
			DropDownButton = New GridCellComboBoxButton(Me)

			'hook the usercontrol save and cancel events...
			AddHandler ddUser.UserControlSave, AddressOf user_Save
			AddHandler ddUser.UserControlCancel, AddressOf user_Cancel

		End Sub

		Public Shadows ReadOnly Property DropDownContainer() As GridDropDownContainer
			Get
				Return CType(MyBase.DropDownContainer, GridDropDownContainer)
			End Get
		End Property

		'here we add the user control to the popup window.
		Protected Overrides Sub InitializeDropDownContainer()
			MyBase.InitializeDropDownContainer()

			If Me.DropDownContainer IsNot Nothing Then
				Me.DropDownContainer.Controls.Add(Me.ddUser)
			End If
		End Sub

		'used to setup the dropdown before it is shown. The RaiseCurrentCellShowingDropDown
		'code is commeted out as it requires teh 2.0 code base. This commented code allow
		'for an event that might cancel teh drop or set its size.
		Public Overrides Sub DropDownContainerShowingDropDown(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim cc As GridCurrentCell = Me.Grid.CurrentCell

'//			Size size = ddUser.Size;
'//			GridCurrentCellShowingDropDownEventArgs ce = new GridCurrentCellShowingDropDownEventArgs(size);
'//			Grid.RaiseCurrentCellShowingDropDown(ce);
'//			if (ce.Cancel)
'//			{
'//				e.Cancel = true;
'//				return;
'//			}
'//			ddUser.Size = ce.Size;
'''
			Me.DropDownContainer.Size = ddUser.Size
			Me.ddUser.SetValuesFromString(Me.ControlText)
			ddUser.Visible = True
		End Sub

		'used to change teh ControlValue if dropdown was closed with Done.
		Public Overrides Sub DropDownContainerCloseDropDown(ByVal sender As Object, ByVal e As PopupClosedEventArgs)
			If e.PopupCloseType = PopupCloseType.Done Then
				If Me.NotifyCurrentCellChanging() Then
					ControlValue = Me.ddUser.GetValuesToString()
					Me.NotifyCurrentCellChanged()
				End If
			End If
			Grid.InvalidateRange(GridRangeInfo.Cell(RowIndex, ColIndex), GridRangeOptions.MergeCoveredCells) ' Merge all cells

			MyBase.DropDownContainerCloseDropDown(sender, e)
		End Sub

		'handler for the user control Save event
		Private Sub user_Save(ByVal sender As Object, ByVal e As EventArgs)
			' closethe dropdown with a Done setting
			Me.Grid.CurrentCell.CloseDropDown(Syncfusion.Windows.Forms.PopupCloseType.Done)
		End Sub

		'handler for the user control Cancel event
		Private Sub user_Cancel(ByVal sender As Object, ByVal e As EventArgs)
			' close the dropdown with a Canceled setting
			Me.Grid.CurrentCell.CloseDropDown(Syncfusion.Windows.Forms.PopupCloseType.Canceled)
		End Sub

		'used to move the grid value into the cell control
		Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			MyBase.OnInitialize (rowIndex, colIndex)
			ddUser.SetValuesFromString(Me.Grid.Model(rowIndex, colIndex).Text)
		End Sub

		'used to save the cell control value back to the grid
		Protected Overrides Function OnSaveChanges() As Boolean
			Dim s As String = Me.ddUser.GetValuesToString()
			Me.Grid.Model(Me.RowIndex, Me.ColIndex).Text = s
			Return True
		End Function
	End Class
End Namespace
