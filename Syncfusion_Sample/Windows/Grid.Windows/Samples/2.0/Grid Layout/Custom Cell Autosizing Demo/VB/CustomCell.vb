Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports System.IO

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Styles


Namespace CustomCellAutoSizing

	#Region "CellModel Class"
	Public Class CustomControlCellModel
		Inherits GridGenericControlCellModel
		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
		End Sub

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New CustomControlCellRenderer(control, Me)
		End Function

		'Override this method to calculate proper control size and return the same.
		Protected Overrides Function OnQueryPrefferedClientSize(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal queryBounds As GridQueryBounds) As Size
				If Grid(rowIndex,colIndex).Tag Is Nothing Then
					Throw New Exception("No User Control is tagged")
				Else
					'Get the type of the control from Style.Tag
					Dim userControl As Control = TryCast(Grid(rowIndex,colIndex).Tag, Control)

					'Calculate the size of the control
					Dim size As Size = userControl.Size
					size.Height += 2
					'return the size
					Return size
				End If
		End Function
	End Class
	#End Region

	#Region "Cell Renderer Class"
	Public Class CustomControlCellRenderer
		Inherits GridGenericControlCellRenderer
		Private cm As CustomControlCellModel
		Private activeControl As Control
		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			cm = CType(cellModel, CustomControlCellModel)
				SupportsFocusControl = True
		End Sub

		#Region "Usual Renderer Overrides"
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				activeControl.Dispose()
				activeControl = Nothing
				cm=Nothing
			End If

			MyBase.Dispose (disposing)
		End Sub
		Protected Overrides Function OnSaveChanges() As Boolean 'internal
			Return True
		End Function


		Protected Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)
				activeControl = TryCast(Grid.Model(rowIndex,colIndex).Tag, Control)
				clientRectangle.Size = GridUtil.Max(clientRectangle.Size, activeControl.Size)
				style.Control = activeControl
				MyBase.OnDraw (g, clientRectangle, rowIndex, colIndex, style)
		End Sub
		Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			activeControl = TryCast(Grid.Model(rowIndex,colIndex).Tag, Control)
		End Sub

		Protected Overrides Function OnLayout(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal innerBounds As Rectangle, ByVal buttonsBounds() As Rectangle) As Rectangle
			Dim r As Rectangle = MyBase.OnLayout (rowIndex, colIndex, style, innerBounds, buttonsBounds)
			r.Inflate(-1, -1)
			Return r
		End Function
		#End Region
	End Class
	#End Region

End Namespace
