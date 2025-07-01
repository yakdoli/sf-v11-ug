Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.Imaging
Imports System.ComponentModel

Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports Syncfusion.Drawing
Imports Syncfusion.ComponentModel


Namespace InteractiveCellDemo
	''' <summary>
	''' Implements the data/model part for a ButtonEdit cell
	''' </summary>
	''' 

	#Region "CellModel"
	<Serializable> _
	Public Class ButtonEditCellModel
		Inherits GridTextBoxCellModel
		''' <summary>
		''' Represents the method that handles the <see cref="ButtonEditCellModel.GridDrawButtonFace"/> event.
		''' </summary>
		''' <param name="sender">The source of the event.</param>
		''' <param name="e">A <see cref="ButtonEditCell.GridDrawButtonFaceEventArgs"/> that contains the event data.</param>
		Public Delegate Sub GridDrawButtonFaceEventHandler(ByVal sender As Object, ByVal e As GridDrawButtonFaceEventArgs)


		''' <summary>
		''' Occurs before the Grid draws the ButtonEdit face
		''' </summary>
		''' <remarks>
		''' See <see cref="ButtonEditCell.GridDrawButtonFaceEventArgs"/> for more detailed discussion about this event.
		''' </remarks>
		<Description("Occurs just before the Grid draws the button face")> _
		Public Event GridDrawButtonFace As GridDrawButtonFaceEventHandler


		''' <overload>
		''' Initializes a new <see cref="ButtonEditCellModel"/> object.
		''' </overload>
		''' <summary>
		''' Initializes a new <see cref="ButtonEditCellModel"/> from a serialization stream.
		''' </summary>
		''' <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		''' <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			MyBase.ButtonBarSize = New Size(20, 20)


		End Sub

		''' <summary>
		''' Initializes a new <see cref="ButtonEditCellModel"/> object 
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
			Return New ButtonEditCellRenderer(control, Me)
		End Function

		''' <summary>
		''' Raises the <see cref="GridDrawButtonFace"/> event
		''' </summary>
		''' <param name="e"><see cref="GridDrawButtonFaceEventArgs"/> data</param>
		Public Sub RaiseDrawButtonFace(ByVal e As GridDrawButtonFaceEventArgs)
			If e Is Nothing Then
				Return
			End If
			If Me.GridDrawButtonFaceEvent IsNot Nothing Then
				RaiseEvent GridDrawButtonFace(Me, e)
			End If
		End Sub


		' To do

		'		/// <override/>
		'		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds GridQueryBounds)
		'		{ 
		'			Size size = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, GridQueryBounds);
		'			return new Size(size.Width + 20, size.Height); // base method already consides ButtonBarSize, but let's add some more pixels here.
		'		}
	End Class

	#End Region

	#Region "CellRenderer"
	''' <summary>
	''' Implements the renderer part for the ButtonEditCellRenderer
	''' </summary>
	''' 
	Public Class ButtonEditCellRenderer
		Inherits GridTextBoxCellRenderer
		''' <summary>
		''' Initializes a new <see cref="ButtonEditCellRenderer"/> object for the given GridControlBase
		''' and <see cref="ButtonEditCellModel"/>.
		''' </summary>
		''' <param name="grid">The <see cref="GridControlBase"/> that display this cell renderer.</param>
		''' <param name="cellModel">The <see cref="ButtonEditCellModel"/> that holds data for this cell renderer that should
		''' be shared among views.</param>
		''' <remarks>References to GridControlBase, 
		''' and GridTextBoxCellModel will be saved.</remarks>
		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridTextBoxCellModel)
			MyBase.New(grid, cellModel)
			AddButton(New ButtonEditCellButton(Me))
		End Sub

		''' <override/>
		Protected Overrides Function OnLayout(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal innerBounds As Rectangle, ByVal buttonsBounds() As Rectangle) As Rectangle

			Dim sp As New ButtonEditStyleProperties(style)
			Dim isRightToLeft As Boolean = False

			If Me.Grid.RightToLeft = RightToLeft.Inherit AndAlso Grid.IsRightToLeft() OrElse style.RightToLeft = RightToLeft.Yes Then
				isRightToLeft = True
			End If

			' Here you specify where the button should be drawn within the cell.
			If sp.ButtonEditInfo.IsLeft Xor isRightToLeft Then
				' Draw left
				Dim rightArea As Rectangle = Rectangle.FromLTRB(innerBounds.Left, innerBounds.Top, innerBounds.Left + sp.ButtonEditInfo.Width, innerBounds.Bottom)
				buttonsBounds(0) = GridUtil.CenterInRect(rightArea, New Size(sp.ButtonEditInfo.Width, 20))

				' Here you return the area where the text should be drawn/edited.
				innerBounds.Width -= sp.ButtonEditInfo.Width
				innerBounds.Offset(sp.ButtonEditInfo.Width,0)
			Else
				' Draw right
				' Here you specify where the button should be drawn within the cell.
				Dim rightArea As Rectangle = Rectangle.FromLTRB(innerBounds.Right-sp.ButtonEditInfo.Width, innerBounds.Top, innerBounds.Right, innerBounds.Bottom)
				buttonsBounds(0) = GridUtil.CenterInRect(rightArea, New Size(sp.ButtonEditInfo.Width, 20))

				' Here you return the area where the text should be drawn/edited.
				innerBounds.Width -= sp.ButtonEditInfo.Width
			End If
			Return innerBounds
		End Function
	End Class
	#End Region

	#Region "CellButton"
	''' <summary>
	''' Defines a ButtonEdit CellButton
	''' Typically used with <see cref="ButtonEditCellRenderer"/>.
	''' </summary>
	''' 
	Public Class ButtonEditCellButton
		Inherits GridCellButton
		Private Shared iconPainter As GridIconPaint

		Shared Sub New()
			iconPainter = New GridIconPaint("InteractiveCellDemo.", GetType(ButtonEditCellButton).Assembly)
		End Sub

		''' <summary>
		''' Initializes a <see cref="ButtonEditCellButton"/> and associates it with a <see cref="ButtonEditCellRenderer"/>
		''' </summary>
		''' <param name="control">The <see cref="ButtonEditCellRenderer"/> that draws this cell button element.</param>
		Public Sub New(ByVal control As GridTextBoxCellRenderer)
			MyBase.New(control)
		End Sub

		''' <override/>
		Public Overrides Sub Draw(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal bActive As Boolean, ByVal style As GridStyleInfo)
			Dim hovering As Boolean = IsHovering(rowIndex, colIndex)
			Dim mouseDown As Boolean = IsMouseDown(rowIndex, colIndex)

			Dim sp As New ButtonEditStyleProperties(style)
			Dim disabled As Boolean = Not sp.ButtonEditInfo.Enabled

			Dim buttonState As ButtonState = ButtonState.Normal
			If disabled Then
				buttonState = buttonState Or ButtonState.Inactive Or ButtonState.Flat

			ElseIf (Not hovering) AndAlso (Not mouseDown) Then
				buttonState = buttonState Or ButtonState.Flat
			End If

			If mouseDown Then
				buttonState = buttonState Or ButtonState.Pushed
			End If

			' Draw the button
			DrawButton(g, Bounds, buttonState, style)

			' Draw the button face
			DrawButtonFace(g, buttonState, style)

		End Sub

		''' <summary>
		''' Draws the button face
		''' </summary>
		''' <param name="g">The <see cref="System.Drawing.Graphics"/> context of the canvas.</param>
		''' <param name="buttonState">A <see cref="ButtonState"/> that specifies the current state.</param>
		''' <param name="style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
		Protected Overridable Sub DrawButtonFace(ByVal g As Graphics, ByVal buttonState As ButtonState, ByVal style As GridStyleInfo)
			Dim e As New GridDrawButtonFaceEventArgs(Me, g, style, style.CellIdentity.RowIndex, style.CellIdentity.ColIndex)
			  OnDrawButtonFace(e)

			If Not e.Handled Then
				Me.DrawDefaultButtonFace(g, buttonState, style)
			End If
		End Sub

		''' <summary>
		''' Raises the <see cref="ButtonEditCellModel.GridDrawButtonFace"/> event
		''' </summary>
		''' <param name="e">An <see cref="GridDrawButtonFaceEventArgs"/>GridDrawButtonFaceEventArgs that contains event data</param>

		Protected Overridable Sub OnDrawButtonFace(ByVal e As GridDrawButtonFaceEventArgs)
			'Raise the event from CellModel
			'TODO - move to Grid instead..
			TryCast(Me.Owner.Model, ButtonEditCellModel).RaiseDrawButtonFace(e)
		End Sub

		''' <summary>
		''' Draws the default button face
		''' </summary>
		''' <param name="g">The <see cref="System.Drawing.Graphics"/> context of the canvas.</param>
		''' <param name="buttonState">A <see cref="ButtonState"/> that specifies the current state.</param>
		''' <param name="style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
		Public Sub DrawDefaultButtonFace(ByVal g As Graphics, ByVal buttonState As ButtonState, ByVal style As GridStyleInfo)
			' Set the button style properties
			Dim sp As New ButtonEditStyleProperties(style)

			'Button bounds
			Dim rect As Rectangle = Bounds
			Dim faceRect As Rectangle = Rectangle.FromLTRB(rect.Left+1, rect.Top+1, rect.Right-2, rect.Bottom-2)

			Dim disabled As Boolean = Not sp.ButtonEditInfo.Enabled
			Dim drawPressed As Boolean = (buttonState And ButtonState.Pushed) <> 0

			'Determine the Offset
			Dim ptOffset As Point = Point.Empty

			If drawPressed Then
			 ptOffset = New Point(1, 1)
			End If

			' Draws the image based on ButtonEditInfo.ButtonEditType
			Dim resourceName As String
			If sp.ButtonEditInfo.ButtonEditType <> ButtonType.None Then
				Select Case sp.ButtonEditInfo.ButtonEditType
					Case ButtonType.Browse
						resourceName = "Browse.bmp"

					Case ButtonType.Check
						resourceName = "Check.bmp"

					Case ButtonType.Down
						resourceName = "Down.bmp"

					Case ButtonType.Left
						resourceName = "Left.bmp"

					Case ButtonType.Leftend
						resourceName = "Leftend.bmp"

					Case ButtonType.Redo
						resourceName = "Redo.bmp"

					Case ButtonType.Right
						resourceName = "Right.bmp"

					Case ButtonType.Rightend
						resourceName = "Rightend.bmp"

					Case ButtonType.Undo
						resourceName = "Undo.bmp"

					Case ButtonType.Up
						resourceName = "Up.bmp"

					Case Else
						resourceName = "Browse.bmp"
				End Select

				' Draws the image from ButtonEditInfo.Image
				If sp.ButtonEditInfo.ButtonEditType = ButtonType.Image Then
					If sp.ButtonEditInfo.Image IsNot Nothing Then
						If Not drawPressed Then
							DrawingUtils.DrawImage(g, TryCast(sp.ButtonEditInfo.Image, Image),Bounds.X+2, Bounds.Y+2, Bounds.Width-4, Bounds.Height-4)
						Else
							DrawingUtils.DrawImage(g, TryCast(sp.ButtonEditInfo.Image, Image),Bounds.X+1, Bounds.Y+1, Bounds.Width-4, Bounds.Height-4)
						End If
					End If
					Return
				End If

				Dim prefix As String = "ButtonImages."
				Dim bitmapName As String = prefix & resourceName

					' Instead of using GridIconPaint you could simple use Image.Draw here
					' with an existing bitmap. GridIconPaint is convenient because it lets
					' us easily draw over existing background and replace the black color
					' in the bitmap with a different color.

				iconPainter.PaintIcon(g, Bounds, ptOffset, bitmapName, Color.Black)
				Return
			End If


			' Colored button drawing
			Dim hilight As Color = SystemColors.ControlLightLight
			Dim shadow As Color = SystemColors.ControlDarkDark
			Dim draw As Color = sp.ButtonEditInfo.BackColor

			Dim br As Brush = New SolidBrush(draw)

			' Colors the button only if the ForceBackColor is set (themes application)
			If sp.ButtonEditInfo.ForceBackColor Then
				If Not disabled Then
					If Not drawPressed Then
						g.FillRectangle(br, Bounds)

						If buttonState = ButtonState.Flat Then
							ControlPaint.DrawBorder(g, Bounds, SystemColors.ControlDark, ButtonBorderStyle.Solid)
						Else
							GridUtil.Draw3dFrame(g, rect.Left, rect.Top, rect.Right-1, rect.Bottom-1, 1, hilight, shadow)
						End If
					Else
						g.FillRectangle(br, New Rectangle(Bounds.X+1, Bounds.Y+1, Bounds.Width, Bounds.Height))

						GridUtil.Draw3dFrame(g, rect.Left-1, rect.Top-1, rect.Right, rect.Bottom, 1, hilight, shadow)
						br.Dispose()
					End If
				End If
			End If


			' Draw the button text
			Dim text As String = sp.ButtonEditInfo.Text

			If text IsNot Nothing AndAlso text.Length > 0 Then
				Dim font As Font = style.GdipFont

				Dim format As New StringFormat()
				Dim isRightToLeft As Boolean = False

				If Me.Grid.RightToLeft = RightToLeft.Inherit AndAlso Grid.IsRightToLeft() OrElse style.RightToLeft = RightToLeft.Yes Then
					 isRightToLeft = True
				End If

				If isRightToLeft Then
					format.FormatFlags = format.FormatFlags Or StringFormatFlags.DirectionRightToLeft
				End If

				format.Alignment = StringAlignment.Center
				format.LineAlignment = StringAlignment.Center
				format.HotkeyPrefix = style.HotkeyPrefix
				format.Trimming = style.Trimming

				If Not style.WrapText Then
					format.FormatFlags = StringFormatFlags.NoWrap
				End If

                Dim textColor As Color
                If (Grid.PrintingMode AndAlso Grid.Model.Properties.BlackWhite) Then
                    textColor = Color.Black
                Else
                    textColor = sp.ButtonEditInfo.TextColor
                End If

				If disabled Then
					DrawText(g, sp.ButtonEditInfo.Text, font, faceRect, style, textColor, True, isRightToLeft)

				Else
					If Not drawPressed Then
						If buttonState = ButtonState.Flat Then
							DrawText(g, sp.ButtonEditInfo.Text, font, New Rectangle(faceRect.Left, faceRect.Top, faceRect.Width, faceRect.Height), style, textColor, False, isRightToLeft)
						Else
							DrawText(g, sp.ButtonEditInfo.Text, font, New Rectangle(faceRect.Left+1, faceRect.Top+1, faceRect.Width, faceRect.Height), style, textColor, False, isRightToLeft)
						End If
					Else
						DrawText(g, sp.ButtonEditInfo.Text, font, faceRect, style, textColor, False, isRightToLeft)
					End If
				End If

				format.Dispose()
			End If
		End Sub

		#Region "Helper methods"
		'Draws the button text
		Public Shared Sub DrawText(ByVal g As Graphics, ByVal displayText As String, ByVal font As Font, ByVal textRectangle As Rectangle, ByVal style As GridStyleInfo, ByVal textColor As Color, ByVal drawDisabled As Boolean, ByVal isRightToLeft As Boolean)
			Dim sp As New ButtonEditStyleProperties(style)

			Dim br As Brush = New SolidBrush(textColor)
			Dim format As New StringFormat()
			format.LineAlignment = GridUtil.ConvertToStringAlignment(sp.ButtonEditInfo.VerticalAlignment)
			format.Alignment = GridUtil.ConvertToStringAlignment(sp.ButtonEditInfo.HorizontalAlignment)
			If isRightToLeft Then
				format.FormatFlags = format.FormatFlags Or StringFormatFlags.DirectionRightToLeft
			End If

			format.HotkeyPrefix = style.HotkeyPrefix
			format.Trimming = style.Trimming
			format.SetTabStops(0f, New Single(){50})

			' Note: Trimming will only work if style.WrapText = True, FloatCell = false.
			If Not style.WrapText Then
				format.FormatFlags = format.FormatFlags Or StringFormatFlags.NoWrap
			End If

			Dim orientation As Integer = style.ReadOnlyFont.Orientation

			If orientation <> 0 Then
				Dim angle As Single = CSng(orientation)

				' Let GDI+ do text rotation.
				RotatePaint.DrawRotatedString(g, displayText, font, br, textRectangle, format, angle)
			Else
				If format.Alignment = StringAlignment.Far AndAlso GridControlBase.UseGdiPlusRightAlignedTextWorkaround Then
					If g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault Then
						Dim stringWidth As Integer = MeasureDisplayStringWidth(g, displayText, font)
						'if (stringWidth < textRectangle.Width)
						stringWidth = Math.Min(stringWidth, textRectangle.Width)
						textRectangle = New Rectangle(textRectangle.Right - stringWidth, textRectangle.Y, stringWidth, textRectangle.Height)
						format.Alignment = StringAlignment.Near
						format.Trimming = StringTrimming.None
						format.FormatFlags = StringFormatFlags.NoWrap
					End If
				End If

				If Not drawDisabled Then
					g.DrawString(displayText, font, br, textRectangle, format)
				Else
					ControlPaint.DrawStringDisabled(g, displayText, font, textColor, textRectangle, format)
				End If
			End If
			br.Dispose()
			format.Dispose()
		End Sub

		Friend Shared Function MeasureDisplayStringWidth(ByVal graphics As Graphics, ByVal text As String, ByVal font As Font) As Integer
			Dim rect As RectangleF = RectangleF.Empty

			Using format As StringFormat = New System.Drawing.StringFormat()
				rect = New System.Drawing.RectangleF(0, 0, 1000, 1000)
				Dim ranges() As CharacterRange = {New System.Drawing.CharacterRange(0, text.Length)}
				Dim regions() As Region = New System.Drawing.Region(0){}
				format.SetMeasurableCharacterRanges(ranges)
				regions = graphics.MeasureCharacterRanges(text, font, rect, format)
				rect = regions(0).GetBounds(graphics)
			End Using

			Return CInt(Fix(rect.Right + 1.0f))
		End Function
		#End Region
	End Class

''' <summary>
''' Provides data about <see cref="ButtonEditCellModel.DrawButtonFace"/> event which can be handled
''' </summary>
''' <remarks>
''' GridDrawButtonFaceEventArgs is a custom event argument class used by the
''' <see cref="ButtonEditCellModel.DrawButtonFace"/> event to allow custom drawing of
''' a buttonedit. Set the Handled property true if you have drawn the cell button contents and
''' do not want the grid to proceed with default button drawing.
''' </remarks>
''' <seealso cref="ButtonEditCellModel.GridDrawButtonFaceEventHandler"/>

	Public NotInheritable Class GridDrawButtonFaceEventArgs
		Inherits SyncfusionHandledEventArgs
'INSTANT VB NOTE: The variable graphics was renamed since Visual Basic does not allow class members with the same name:
		Private graphics_Renamed As Graphics
'INSTANT VB NOTE: The variable style was renamed since Visual Basic does not allow class members with the same name:
		Private style_Renamed As GridStyleInfo
'INSTANT VB NOTE: The variable rowIndex was renamed since Visual Basic does not allow class members with the same name:
		Private rowIndex_Renamed As Integer
'INSTANT VB NOTE: The variable colIndex was renamed since Visual Basic does not allow class members with the same name:
		Private colIndex_Renamed As Integer
'INSTANT VB NOTE: The variable button was renamed since Visual Basic does not allow class members with the same name:
		Private button_Renamed As ButtonEditCellButton

		''' <summary>
		''' Initializes new instance of the GridDrawButtonFaceEventArgs class
		''' </summary>
		''' <param name="Button">Reference to <see cref="ButtonEditCellButton"/></param>
		''' <param name="Graphics">Graphics context</param>
		''' <param name="Style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
		''' <param name="RowIndex">The row index</param>
		''' <param name="ColIndex">The col index</param>
		''' <param name="Handled"></param>
		Public Sub New(ByVal Button As ButtonEditCellButton, ByVal Graphics As Graphics, ByVal Style As GridStyleInfo, ByVal RowIndex As Integer, ByVal ColIndex As Integer)
			Me.graphics_Renamed = Graphics
			Me.style_Renamed = Style
			Me.rowIndex_Renamed = RowIndex
			Me.colIndex_Renamed = ColIndex
			Me.button_Renamed = Button
		End Sub

		''' <summary>
		''' The <see cref="ButtonEditButton"/> that is associated with the cell
		''' </summary>
		''' <remarks>
		''' If you do not set <see cref="GridDrawButtonFaceEventArgs.Handled"/> to True, this buttons's <see cref="ButtonEditCellButton.DrawDefaultButtonFace"/> 
		''' will get called.
		''' </remarks>
		<TraceProperty(True)> _
		Public ReadOnly Property Button() As ButtonEditCellButton
			Get
				Return Me.button_Renamed
			End Get
		End Property
		''' <summary>
		''' Graphics context
		''' </summary>
		<TraceProperty(True)> _
		Public ReadOnly Property Graphics() As Graphics
			Get
				Return Me.graphics_Renamed
			End Get
		End Property

		''' <summary>
		''' The style object associated with that cell.
		''' </summary>
		<TraceProperty(True)> _
		Public ReadOnly Property Style() As GridStyleInfo
			Get
				Return style_Renamed
			End Get

		End Property

		''' <summary>
		''' The row index
		''' </summary>
		<TraceProperty(True)> _
		Public ReadOnly Property RowIndex() As Integer
			Get
				Return rowIndex_Renamed
			End Get
		End Property

		''' <summary>
		''' The col index
		''' </summary>
		<TraceProperty(True)> _
		Public ReadOnly Property ColIndex() As Integer
			Get
				Return colIndex_Renamed
			End Get
		End Property
	End Class
	#End Region
End Namespace