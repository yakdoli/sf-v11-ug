Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

''' <summary>
''' Summary description for ClassSymbol
''' </summary>
<Serializable> _
Public Class CustomGroup
	Inherits Group

#Region "Class Initialize Methods"
    Private _lstClass As ClassList
    ''' <summary>
    ''' Create a new instance of CustomGroup
    ''' </summary>
    ''' <param name="classList">ClassList</param>

    Public Sub New(ByVal classList As ClassList)

        Dim Height As Single = 60, PinPointY As Single = 0
        'if (string.IsNullOrEmpty(classList.ObjectType))
        '    Height = 55;
        Dim customRect As New CustomRectangle(0, 0, 220, Height)
        customRect.ClassName = classList.ClassName
        customRect.ClassType = classList.ClassType
        customRect.ObjectType = classList.ObjectType
        customRect.TitleImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\5.png")
        customRect.FillStyle.Color = Color.Transparent
        customRect.LineStyle.LineColor = Color.Transparent
        Me.AppendChild(customRect)

        PinPointY = customRect.PinPoint.Y + (customRect.Size.Height - customRect.PinPoint.Y)
        If classList.PropertyList.Count > 0 Then
            Dim rect As New RowRectangle(0, PinPointY, 220, 25)
            rect.FillStyle.Color = Color.FromArgb(248, 249, 252)
            rect.LineStyle.LineColor = Color.Transparent
            rect.Labels(0).OffsetX = 25
            rect.RowText = "Properties"
            Me.AppendChild(rect)
            PinPointY = rect.PinPoint.Y + 12.5F
            For i As Integer = 0 To classList.PropertyList.Count - 1
                Dim rect1 As New RowRectangle(0, PinPointY, 220, 25)
                If classList.PropertyList(i).PropertyType = PropertyType.Internal Then
                    rect1.RowImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\6.png")
                Else
                    rect1.RowImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\7.png")
                End If
                rect1.RowText = classList.PropertyList(i).PropertyName
                rect1.FillStyle.Color = Color.White
                rect1.LineStyle.LineColor = Color.Transparent
                Me.AppendChild(rect1)
                PinPointY += rect1.PinPoint.Y + (rect1.Size.Height - rect1.PinPoint.Y)
            Next i
        End If

        If classList.MethodList.Count > 0 Then
            Dim rect As New RowRectangle(0, PinPointY, 220, 25)
            rect.FillStyle.Color = Color.FromArgb(248, 249, 252)
            rect.LineStyle.LineColor = Color.Transparent
            rect.RowText = "Methods"
            rect.Labels(0).OffsetX = 25
            Me.AppendChild(rect)
            PinPointY = rect.PinPoint.Y + 12.5F
            For i As Integer = 0 To classList.MethodList.Count - 1
                Dim rect1 As New RowRectangle(0, PinPointY, 220, 25)
                If classList.MethodList(i).MethodType = MethodType.Internal Then
                    rect1.RowImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\1.png")
                ElseIf classList.MethodList(i).MethodType = MethodType.Protected Then
                    rect1.RowImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\2.png")
                ElseIf classList.MethodList(i).MethodType = MethodType.Public Then
                    rect1.RowImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\3.png")
                End If
                rect1.RowText = classList.MethodList(i).MethodName
                rect1.FillStyle.Color = Color.White
                rect1.LineStyle.LineColor = Color.Transparent
                Me.AppendChild(rect1)
                PinPointY += 25
            Next i

        End If

        Dim roundRect As New RoundRect(Me.Nodes(0).PinPoint.X - 110, Me.Nodes(0).PinPoint.Y - 30, Me.Size.Width, Me.Size.Height + 10, MeasureUnits.Pixel)
        roundRect.FillStyle.Color = Color.White
        roundRect.FillStyle.ForeColor = Color.FromArgb(236, 238, 247)
        roundRect.FillStyle.ForeColor = Color.FromArgb(222, 226, 241)
        roundRect.FillStyle.Type = FillStyleType.LinearGradient
        roundRect.FillStyle.GradientAngle = 90
        roundRect.FillStyle.GradientCenter = 1
        roundRect.LineStyle.LineColor = Color.FromArgb(199, 205, 231)
        Me.AppendChild(roundRect)
        Me.SendToBack(roundRect)
    End Sub

    ''' <summary>
    ''' Copy constructor.
    ''' </summary>
    ''' <param name="src"></param>
    Public Sub New(ByVal src As CustomGroup)
        MyBase.New(src)
    End Sub
    ''' <summary>
    ''' Serialization constructor for the CustomGroup class.
    ''' </summary>
    ''' <param name="info">Serialization state information</param>
    ''' <param name="context">Streaming context information</param>
    Protected Sub New(ByVal info As Runtime.Serialization.SerializationInfo, ByVal context As Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
        ' The Serialization constructor is invoked during deserialization or during a drag & drop operation.
        ' If the CustomGroup type has serializable members, then initialize them with the serialized data 
        ' obtained from the SerializationInfo param
    End Sub
#End Region
    Public Overrides Function Clone() As Object
        Return New CustomGroup(Me)
    End Function
End Class