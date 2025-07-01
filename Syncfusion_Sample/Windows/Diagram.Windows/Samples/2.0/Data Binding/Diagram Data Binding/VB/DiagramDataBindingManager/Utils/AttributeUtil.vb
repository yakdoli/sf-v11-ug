#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports Syncfusion.Windows.Forms.Diagram

Namespace DataBinding
    ' <summary>
    ' Attribute defining the NodeType for the class.
    '</summary>
    <System.AttributeUsage(AttributeTargets.Class Or AttributeTargets.Property, AllowMultiple:=True, Inherited:=True)> _
    Public Class NodeTypeAttribute
        Inherits Attribute
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeTypeAttribute"/>.
        ''' </summary>
        Public Sub New()
        End Sub
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeTypeAttribute"/> class.
        ''' </summary>
        Public Sub New(ByVal nodeRectangle As System.Drawing.RectangleF)
        End Sub

        Private _nodeType As Type
        ''' <summary>
        ''' Gets or sets the type of the node.
        ''' </summary>
        ''' <value>The type of the node.</value>
        Public Property NodeType() As Type
            Get
                Return _nodeType
            End Get
            Set(ByVal value As Type)
                If CheckForBaseTypeAsNode(value) Then
                    _nodeType = value
                ElseIf value Is Nothing Then
                    Throw New ArgumentNullException("NodeType cannot be null")
                End If
                'else
                '    throw new ArgumentException("Not a valid NodeType passed");
            End Set
        End Property

        Private _rectangle() As Single
        ''' <summary>
        ''' Gets or sets the node rectangle. Specify the x, y, width and height of the Node.
        ''' </summary>
        ''' <value>The node rectangle.</value>
        Public Property Dimensions() As Single()
            Get
                Return _rectangle
            End Get
            Set(ByVal value As Single())
                If value.Length = 4 Then
                    _rectangle = value
                Else
                    Throw New ArgumentException("Rectangle needs four parameters of value")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Checks for base type as Node.
        ''' </summary>
        ''' <param name="value">The value.</param>
        ''' <returns></returns>
        Protected Function CheckForBaseTypeAsNode(ByVal value As Type) As Boolean
            Dim result As Boolean = False
            If value IsNot Nothing AndAlso value.BaseType IsNot Nothing Then
                If value.BaseType Is GetType(Group) Then
                    result = False
                    Return result
                End If

                If value.BaseType Is GetType(Node) Then
                    result = True
                    Return result
                Else
                    result = CheckForBaseTypeAsNode(value.BaseType)
                    Return result
                End If
            End If
            Return result
        End Function

    End Class

    ' <summary>
    ' Defines the NodeAttribute that would enable adding labels / images to the Node dynamically.
    ' </summary>
    <System.AttributeUsage(AttributeTargets.Property, AllowMultiple:=True, Inherited:=True)> _
    Public Class NodeAttributeAttribute
        Inherits System.Attribute

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeAttributeAttribute"/> class.
        ''' </summary>
        Public Sub New()
        End Sub

        Private _visibleType As VisibleType = VisibleType.None
        ''' <summary>
        ''' Gets or sets the type of the visibility.
        ''' </summary>
        ''' <value>The type of the visibility.</value>
        Public Property VisibilityType() As VisibleType
            Get
                Return _visibleType
            End Get
            Set(ByVal value As VisibleType)
                _visibleType = value
            End Set
        End Property

    End Class


    ''' <summary>
    '''  Enum for Node's visible type
    ''' </summary>
    Public Enum VisibleType
        ''' <summary>
        ''' 
        ''' </summary>
        Label
        'Image,
        'Node,
        ''' <summary>
        ''' 
        ''' </summary>
        None
    End Enum
End Namespace