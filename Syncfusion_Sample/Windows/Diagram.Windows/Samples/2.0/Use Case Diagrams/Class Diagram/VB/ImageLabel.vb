Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web
Imports Syncfusion.Windows.Forms.Diagram

''' <summary>
''' Summary description for ImageLabel
''' </summary>
<Serializable()> _
Public Class ImageLabel
    Inherits Label

#Region "Class Properties"
    'INSTANT VB NOTE: The variable textImage was renamed since Visual Basic does not allow class members with the same name:
    Private textImage_Renamed As System.Drawing.Image = Nothing
    Public Property TextImage() As System.Drawing.Image
        Get
            Return textImage_Renamed
        End Get
        Set(ByVal value As System.Drawing.Image)
            textImage_Renamed = value
        End Set
    End Property

    'INSTANT VB NOTE: The variable imageOffsetX was renamed since Visual Basic does not allow class members with the same name:
    Private imageOffsetX_Renamed As Single = 0
    Public Property ImageOffsetX() As Single
        Get
            Return imageOffsetX_Renamed
        End Get
        Set(ByVal value As Single)
            imageOffsetX_Renamed = value
        End Set
    End Property

    'INSTANT VB NOTE: The variable imageOffsetY was renamed since Visual Basic does not allow class members with the same name:
    Private imageOffsetY_Renamed As Single = 0
    Public Property ImageOffsetY() As Single
        Get
            Return imageOffsetY_Renamed
        End Get
        Set(ByVal value As Single)
            imageOffsetY_Renamed = value
        End Set
    End Property

    'INSTANT VB NOTE: The variable drawImage was renamed since Visual Basic does not allow class members with the same name:
    Private drawImage_Renamed As Boolean = False
    Public Property DrawImage() As Boolean
        Get
            Return drawImage_Renamed
        End Get
        Set(ByVal value As Boolean)
            drawImage_Renamed = value
        End Set
    End Property
#End Region

#Region "Class Initialize Methods"
    ''' <summary>
    ''' Create a new instance of ImageLabel
    ''' </summary>
    ''' <param name="Container">Container of the label</param>
    ''' <param name="LabelText">Text of the Label</param>
    Public Sub New(ByVal Container As Node, ByVal LabelText As String)
        Me.Text = LabelText
        Me.Container = Container
    End Sub

    ''' <summary>
    ''' Serialization constructor for the ImageLabel class.
    ''' </summary>
    ''' <param name="info">Serialization state information</param>
    ''' <param name="context">Streaming context information</param>
    Protected Sub New(ByVal info As Runtime.Serialization.SerializationInfo, ByVal context As Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
        ' The Serialization constructor is invoked during deserialization or during a drag & drop operation.
        ' If the ImageLabel type has serializable members, then initialize them with the serialized data 
        ' obtained from the SerializationInfo param
    End Sub
#End Region

#Region "Class Override Methods"
    Protected Overrides Sub Render(ByVal gfx As System.Drawing.Graphics)
        MyBase.Render(gfx)

        Dim graph As System.Drawing.Drawing2D.GraphicsState = gfx.Save()
        If TextImage IsNot Nothing AndAlso DrawImage Then
            gfx.DrawImage(TextImage, ImageOffsetX, ImageOffsetY, 17.5F, 17.5F)
            gfx.Restore(graph)
        End If
    End Sub
#End Region
End Class