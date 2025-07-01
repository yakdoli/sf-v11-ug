Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web
Imports Syncfusion.Windows.Forms.Diagram


''' <summary>
''' Summary description for CustomRectangle
''' </summary>

<Serializable> _
Public Class CustomRectangle
	Inherits Rectangle
	#Region "Class Members"
'INSTANT VB NOTE: The variable titleImage was renamed since Visual Basic does not allow class members with the same name:
	Private titleImage_Renamed As System.Drawing.Image = Nothing

'INSTANT VB NOTE: The variable className was renamed since Visual Basic does not allow class members with the same name:
	Private className_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable classType was renamed since Visual Basic does not allow class members with the same name:
	Private classType_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable objectType was renamed since Visual Basic does not allow class members with the same name:
	Private objectType_Renamed As String = String.Empty

	Private lblClassName As New Label()
	Private lblClassType As New Label()
	Private lblObjectType As New Label()
	#End Region

	#Region "Class Properties"

	Public Property ClassName() As String
		Get
			Return lblClassName.Text
		End Get
		Set(ByVal value As String)
			lblClassName.Text = value
		End Set
	End Property
	Public Property ClassType() As String
		Get
			Return lblClassType.Text
		End Get
		Set(ByVal value As String)
			lblClassType.Text = value
		End Set
	End Property
	Public Property ObjectType() As String
		Get
			Return lblObjectType.Text
		End Get
		Set(ByVal value As String)
			lblObjectType.Text = value
		End Set
	End Property

	Public Property TitleImage() As System.Drawing.Image
		Get
			Return titleImage_Renamed
		End Get
		Set(ByVal value As System.Drawing.Image)
			titleImage_Renamed = value
		End Set
	End Property

	#End Region

	#Region "Class Initialize/Finalize methods"
	''' <summary>
		''' Initializes a new instance of the <see cref="Rectangle"/> class.
		''' </summary>
		''' <param name="x">X-coordinate of rectangle.</param>
		''' <param name="y">Y-coordinate of rectangle.</param>
		''' <param name="width">Width of rectangle.</param>
		''' <param name="height">Height of rectangle.</param>
		Public Sub New(ByVal x As Single, ByVal y As Single, ByVal width As Single, ByVal height As Single)
			Me.New(New System.Drawing.RectangleF(x, y, width, height))
		End Sub

		''' <summary>
		''' Initializes a new instance of the <see cref="Rectangle"/> class.
		''' </summary>
		''' <param name="rcBounds">Rectangle containing position and size.</param>
		Public Sub New(ByVal rcBounds As System.Drawing.RectangleF)
			MyBase.New(New System.Drawing.RectangleF(rcBounds.X,rcBounds.Y,rcBounds.Width,rcBounds.Height))
			InitializeRectangle(rcBounds, MeasureUnits.Pixel)
		End Sub

		Public Sub New(ByVal src As CustomRectangle)
			MyBase.New(src)
		End Sub
    ''' <summary>
    ''' Serialization constructor for the CustomRectangle class.
    ''' </summary>
    ''' <param name="info">Serialization state information</param>
    ''' <param name="context">Streaming context information</param>
    Protected Sub New(ByVal info As Runtime.Serialization.SerializationInfo, ByVal context As Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
        ' The Serialization constructor is invoked during deserialization or during a drag & drop operation.
        ' If the CustomRectangle type has serializable members, then initialize them with the serialized data 
        ' obtained from the SerializationInfo param
    End Sub
		Private Sub InitializeRectangle(ByVal rectBounds As System.Drawing.RectangleF, ByVal measureUnits As MeasureUnits)
			Me.Labels.Add(lblClassName)
			lblClassName.FontStyle.Family = "Arial"
			lblClassName.FontStyle.Size = 8
			lblClassName.FontStyle.Bold = True
			lblClassName.OffsetX = 10
			lblClassName.OffsetY = 5
			Me.Labels.Add(lblClassType)
			lblClassType.FontStyle.Family = "Arial"
			lblClassType.FontStyle.Size = 8
			lblClassType.OffsetX = 10
			lblClassType.OffsetY = 25

			Me.Labels.Add(lblObjectType)
			lblObjectType.FontStyle.Family = "Arial"
			lblObjectType.FontStyle.Size = 7
			lblObjectType.OffsetX = 10
			lblObjectType.OffsetY = 45
			Me.LineStyle.LineWidth = 0

		End Sub

		#End Region

	#Region "Class Override Methods"
		Protected Overrides Sub Render(ByVal gfx As System.Drawing.Graphics)
			MyBase.Render(gfx)
			Dim graph As System.Drawing.Drawing2D.GraphicsState = gfx.Save()
			If TitleImage IsNot Nothing Then
				gfx.DrawImage(TitleImage,(Me.PinPoint.X -25) +(Me.Size.Width-Me.PinPoint.X),5,17.5f,17.5f)
			End If
			gfx.Restore(graph)
		End Sub
		#End Region
End Class