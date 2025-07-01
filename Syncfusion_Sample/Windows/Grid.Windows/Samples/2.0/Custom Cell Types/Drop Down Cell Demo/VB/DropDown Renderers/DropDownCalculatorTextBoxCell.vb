Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.ComponentModel
Imports System.Runtime.Serialization
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Styles
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace DropDownCellDemo
	#Region "Cell Model"
	Friend Class DropDownCalculatorTextBoxCellModel
		Inherits GridStaticCellModel

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Sub New(ByVal grid As GridModel) ', CalculatorControl calci)
			MyBase.New(grid)
			ButtonBarSize = New Size(14, 20)
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New DropDownCalculatorTextBoxCellRenderer(control, Me)
		End Function

		Protected Overrides Function OnQueryPrefferedClientSize(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal queryBounds As GridQueryBounds) As Size
			Dim s As Size = MyBase.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds)
			s.Width = s.Width + ButtonBarSize.Width
			Return s
		End Function
	End Class
	#End Region

	#Region "Cell Renderer"
	Friend Class DropDownCalculatorTextBoxCellRenderer
		Inherits GridStaticCellRenderer
		Friend calci As CalculatorControl

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			DropDownPart = New GridDropDownCellImp(Me)
			DropDownButton = New GridCellComboBoxButton(Me)
		End Sub

		Private Sub calci_ValueCalculated(ByVal sender As Object, ByVal arg As CalculatorValueCalculatedEventArgs)
			Dim cc As GridCurrentCell = Me.Grid.CurrentCell
			Me.Grid.Model(cc.RowIndex, cc.ColIndex).CellValue = Me.calci.Value
		End Sub

		Public Shadows ReadOnly Property DropDownContainer() As GridDropDownContainer
			Get
				Return CType(MyBase.DropDownContainer, GridDropDownContainer)
			End Get
		End Property

		Public Overrides Sub DropDownContainerShowingDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			Dim style As GridStyleInfo = Me.Grid.Model(RowIndex, ColIndex)
			Me.calci = TryCast(style.Control, CalculatorControl)
			Me.calci.ShowDisplayArea = False
			Me.calci.Size = New Size(260, 180)

			If Me.DropDownContainer IsNot Nothing Then
				Me.DropDownContainer.Controls.Add(Me.calci)
			End If

			Me.DropDownContainer.Size = Me.calci.Size
			AddHandler calci.ValueCalculated, AddressOf calci_ValueCalculated
		End Sub

		Protected Overrides Function OnSaveChanges() As Boolean
			Grid.Model(RowIndex, ColIndex).CellValue = calci.Value
			Return True
		End Function

		Public Overrides Sub DropDownContainerCloseDropDown(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.PopupClosedEventArgs)
			RemoveHandler calci.ValueCalculated, AddressOf calci_ValueCalculated
			Me.DropDownContainer.Controls.Remove(Me.calci)
		End Sub

	End Class
	#End Region
End Namespace