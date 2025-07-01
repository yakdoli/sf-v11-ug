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
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.Imaging

Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms.Grid

Namespace InteractiveCellDemo
	''' <summary>
	''' Defines a textbox cell with a ellipsis button.
	''' Typically used with <see cref="EllipsisCellRenderer"/>.
	''' </summary>
	Public Class EllipsisCellButton
		Inherits GridCellButton
		Private Shared iconPainter As GridIconPaint

		Shared Sub New()
			iconPainter = New GridIconPaint("InteractiveCellDemo.", GetType(EllipsisCellButton).Assembly)
		End Sub

		''' <summary>
		''' Initializes a <see cref="EllipsisCellButton"/> and associates it with a <see cref="GridTextBoxCellRenderer"/>
		''' </summary>
		''' <param name="control">The <see cref="GridTextBoxCellRenderer"/> that draws this cell button element.</param>
		Public Sub New(ByVal control As GridTextBoxCellRenderer)
			MyBase.New(control)
		End Sub

		''' <override/>
		Public Overrides Sub Draw(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal bActive As Boolean, ByVal style As GridStyleInfo)
			TraceUtil.TraceCurrentMethodInfo(rowIndex, colIndex, bActive, style.CellValue)

			MyBase.Draw(g, rowIndex, colIndex, bActive, style)

			' draw the button
			Dim hovering As Boolean = IsHovering(rowIndex, colIndex)
			Dim mouseDown As Boolean = IsMouseDown(rowIndex, colIndex)
			Dim disabled As Boolean = Not style.Clickable

			Dim buttonState As ButtonState = ButtonState.Normal
			If disabled Then
				buttonState = buttonState Or ButtonState.Inactive Or ButtonState.Flat

			ElseIf (Not hovering) AndAlso (Not mouseDown) Then
				buttonState = buttonState Or ButtonState.Flat
			End If

			Dim ptOffset As Point = Point.Empty
			If mouseDown Then
				ptOffset = New Point(1, 1)
				buttonState = buttonState Or ButtonState.Pushed
			End If

			DrawButton(g, Bounds, buttonState, style)

			Dim bitmapName As String = "Browse.bmp" ' make sure this is included in project and marked as "Embedded Resource"

			' Instead of using GridIconPaint you could simple use Image.Draw here
			' with an existing bitmap. GridIconPaint is convenient because it lets
			' us easily draw over existing background and replace the black color
			' in the bitmap with a different color.
			iconPainter.PaintIcon(g, Bounds, ptOffset, bitmapName, Color.White)
		End Sub
	End Class


	''' <summary>
	''' Implements the data/model part for a textbox cell with ellipse in a <see cref="GridDataBoundGrid"/>. The
	''' The exandable row header cell will display a '+' for expanded rows and a '-' for collapsed rows similar to a TreeControl.
	''' a pencil when the row is being edited.
	''' </summary>
	<Serializable> _
	Public Class EllipsisCellModel
		Inherits GridTextBoxCellModel
		''' <overload>
		''' Initializes a new <see cref="EllipsisCellModel"/> object.
		''' </overload>
		''' <summary>
		''' Initializes a new <see cref="EllipsisCellModel"/> from a serialization stream.
		''' </summary>
		''' <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		''' <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			MyBase.ButtonBarSize = New Size(20, 20)
		End Sub

		''' <summary>
		''' Initializes a new <see cref="EllipsisCellModel"/> object 
		''' and stores a reference to the <see cref="GridModel"/> this cell belongs to.
		''' </summary>
		''' <param name="grid">The <see cref="GridModel"/> for this cell model.</param>	
		''' <remarks>
		''' You typically access cell models through the <see cref="GridModel.CellModels"/>
		''' property of the <see cref="GridModel"/> class.
		''' </remarks>
		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
		End Sub

		''' <override/>
		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New EllipsisCellRenderer(control, Me)
		End Function


		''' <override/>
		Protected Overrides Function OnQueryPrefferedClientSize(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal GridQueryBounds As GridQueryBounds) As Size
			Dim size As Size = MyBase.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, GridQueryBounds)
			Return New Size(size.Width + 20, size.Height) ' base method already consides ButtonBarSize, but let's add some more pixels here.
		End Function


	End Class

	''' <summary>
	''' Implements the renderer part for a textbox cell with ellipsis button
	''' </summary>
	Public Class EllipsisCellRenderer
		Inherits GridTextBoxCellRenderer
		''' <summary>
		''' Initializes a new <see cref="GridTextBoxCellRenderer"/> object for the given GridControlBase
		''' and <see cref="GridTextBoxCellModel"/>.
		''' </summary>
		''' <param name="grid">The <see cref="GridControlBase"/> that display this cell renderer.</param>
		''' <param name="cellModel">The <see cref="GridTextBoxCellModel"/> that holds data for this cell renderer that should
		''' be shared among views.</param>
		''' <remarks>References to GridControlBase, 
		''' and GridTextBoxCellModel will be saved.</remarks>
		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridTextBoxCellModel)
			MyBase.New(grid, cellModel)
			AddButton(New EllipsisCellButton(Me))
		End Sub

		''' <override/>
		Public Overrides Sub OnPrepareViewStyleInfo(ByVal e As GridPrepareViewStyleInfoEventArgs)
			' Here you can adjust settings that override the default settings from the grid
			e.Style.ShowButtons = GridShowButtons.Show
			e.Style.Clickable = True
			e.Style.TextAlign = GridTextAlign.Left
			e.Style.VerticalAlignment = GridVerticalAlignment.Middle
			e.Style.WrapText = False
		End Sub

		''' <override/>
		Protected Overrides Function OnLayout(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal innerBounds As Rectangle, ByVal buttonsBounds() As Rectangle) As Rectangle
			TraceUtil.TraceCurrentMethodInfo(rowIndex, colIndex, style, innerBounds, buttonsBounds)

			' Here you specify where the button should be drawn within the cell.
			Dim rightArea As Rectangle = Rectangle.FromLTRB(innerBounds.Right-20, innerBounds.Top, innerBounds.Right, innerBounds.Bottom)
			buttonsBounds(0) = GridUtil.CenterInRect(rightArea, New Size(20, 20))

			' Here you return the area where the text should be drawn/edited.
			innerBounds.Width -= 20
			Return innerBounds
		End Function

	End Class

End Namespace
