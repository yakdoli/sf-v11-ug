Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web
Imports Syncfusion.Windows.Forms.Diagram

''' <summary>
''' Summary description for RowRectangle
''' </summary>
<Serializable> _
Public Class RowRectangle
	Inherits Rectangle
	#Region "Class Properties"

	Private lblRowText As New Label()
	Public Property RowText() As String
		Get
			Return lblRowText.Text
		End Get
		Set(ByVal value As String)
			lblRowText.Text = value
		End Set
	End Property

'INSTANT VB NOTE: The variable rowImage was renamed since Visual Basic does not allow class members with the same name:
	Private rowImage_Renamed As System.Drawing.Image = Nothing
	Public Property RowImage() As System.Drawing.Image
		Get
			Return rowImage_Renamed
		End Get
		Set(ByVal value As System.Drawing.Image)
			rowImage_Renamed = value
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

    Public Sub New(ByVal src As RowRectangle)
        MyBase.New(src)
    End Sub
    ''' <summary>
    ''' Serialization constructor for the RowRectangle class.
    ''' </summary>
    ''' <param name="info">Serialization state information</param>
    ''' <param name="context">Streaming context information</param>
    Protected Sub New(ByVal info As Runtime.Serialization.SerializationInfo, ByVal context As Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
        ' The Serialization constructor is invoked during deserialization or during a drag & drop operation.
        ' If the RowRectangle type has serializable members, then initialize them with the serialized data 
        ' obtained from the SerializationInfo param
    End Sub

		Private Sub InitializeRectangle(ByVal rectBounds As System.Drawing.RectangleF, ByVal measureUnits As MeasureUnits)
			Me.Labels.Add(lblRowText)
			lblRowText.FontStyle.Family = "Arial"
			lblRowText.FontStyle.Size = 8
			lblRowText.OffsetX = 55
			lblRowText.OffsetY = 5


		End Sub

		#End Region

	#Region "Class Override Methods"
		Protected Overrides Sub Render(ByVal gfx As System.Drawing.Graphics)
			MyBase.Render(gfx)
			Dim graph As System.Drawing.Drawing2D.GraphicsState = gfx.Save()
			If RowImage IsNot Nothing Then
				gfx.DrawImage(RowImage, Me.Labels(0).OffsetX -20, 2,17.5f,17.5f)
				gfx.Restore(graph)
			End If
		End Sub
		#End Region
End Class