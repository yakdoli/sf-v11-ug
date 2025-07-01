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
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text
Imports System.Runtime.Serialization

Imports Syncfusion.Diagnostics

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace DropDownCellDemo
	''' <summary>
	''' Summary description for DropDownGridCell.
	''' </summary>
	Public Class DropDownGridCellModel
		Inherits GridDropDownGridCellModel
		Private _embbeddedGrid As GridControlBase

		Public Property EmbeddedGrid() As GridControlBase
			Get
				If _embbeddedGrid Is Nothing Then
					_embbeddedGrid = New GridControlBaseImp()
				End If
				Return _embbeddedGrid
			End Get
			Set(ByVal value As GridControlBase)
				_embbeddedGrid = value
			End Set
		End Property

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)

		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New DropDownGridCellRenderer(control, Me)
		End Function
	End Class

	Public Class DropDownGridCellRenderer
		Inherits GridDropDownGridCellRenderer
'INSTANT VB NOTE: The variable grid was renamed since Visual Basic does not allow class members with the same name:
		Private grid_Renamed As GridControlBase

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			Me.DisableTextBox = True
			DropDownButton = New GridCellComboBoxButton(Me)
			Me.grid_Renamed = Nothing
		End Sub

		Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			Me.grid_Renamed = (CType(Me.Model, DropDownGridCellModel)).EmbeddedGrid
			Me.grid_Renamed.Dock = DockStyle.Fill
			MyBase.OnInitialize(rowIndex, colIndex)
		End Sub

		Protected Overrides Sub InitializeDropDownContainer()
			MyBase.InitializeDropDownContainer()

			'this.DropDownContainer.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Me.DropDownContainer.IgnoreDialogKey = True
		End Sub

		Protected Overrides Function CreateInnerControl(<System.Runtime.InteropServices.Out()> ByRef grid As GridControlBase) As Control
			grid = Me.grid_Renamed
			grid.Dock = DockStyle.Fill
			grid.CausesValidation = False

			Return grid
		End Function


	End Class

End Namespace
