#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.Reflection

Namespace DataBinding
    ''' <summary>
    ''' Defines the attributes for Node properties got through reflection.
    ''' </summary>
    Public Class NodePropInfo
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodePropInfo"/> 
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodePropInfo"/>
        ''' </summary>
        ''' <param name="propertyName">Name of the property.</param>
        ''' <param name="pInfo">The p info.</param>
        Public Sub New(ByVal propertyName As String, ByVal pInfo As PropertyInfo)
            Me._propertyName = propertyName
            Me._propInfo = pInfo
        End Sub

        Private _propertyName As String
        ''' <summary>
        ''' Gets or sets the name of the property.
        ''' </summary>
        ''' <value>The name of the property.</value>
        Public Property PropertyName() As String
            Get
                Return _propertyName
            End Get
            Set(ByVal value As String)
                _propertyName = value
            End Set
        End Property

        Private _propInfo As PropertyInfo
        ''' <summary>
        ''' Gets or sets the prop info.
        ''' </summary>
        ''' <value>The prop info.</value>
        Public Property PropertyInfo() As PropertyInfo
            Get
                Return _propInfo
            End Get
            Set(ByVal value As PropertyInfo)
                _propInfo = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the custom attributes.
        ''' </summary>
        ''' <returns></returns>
        Public Function GetCustomAttribute() As NodeAttributeAttribute
            Return CType(Attribute.GetCustomAttribute(_propInfo, GetType(NodeAttributeAttribute)), NodeAttributeAttribute)
        End Function
    End Class

    ''' <summary>
    ''' Defines the Class info that is got through reflection.
    ''' </summary>
    Public Class NodeClassInfo
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeClassInfo"/> 
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeClassInfo"/>
        ''' </summary>
        ''' <param name="className">Name of the class.</param>
        ''' <param name="classType">Type of the class.</param>
        ''' <param name="nodePropInfoCollection">The node prop info collection.</param>
        Public Sub New(ByVal className As String, ByVal classType As Type, ByVal nodePropInfoCollection As List(Of NodePropInfo))
            Me._className = className
            Me._classType = classType
            Me._nodePropertyInfoCollection = nodePropInfoCollection
        End Sub

        Private _className As String
        ''' <summary>
        ''' Gets or sets the name of the class.
        ''' </summary>
        ''' <value>The name of the class.</value>
        Public Property ClassName() As String
            Get
                Return _className
            End Get
            Set(ByVal value As String)
                _className = value
            End Set
        End Property

        Private _classType As Type
        ''' <summary>
        ''' Gets or sets the typeof value.
        ''' </summary>
        Public Property ClassType() As Type
            Get
                Return _classType
            End Get
            Set(ByVal value As Type)
                _classType = value
            End Set
        End Property

        Private _nodePropertyInfoCollection As List(Of NodePropInfo)
        ''' <summary>
        ''' Gets or sets the node property info.
        ''' </summary>
        ''' <value>The node property info.</value>
        Public Property NodePropertyInfoCollection() As List(Of NodePropInfo)
            Get
                Return _nodePropertyInfoCollection
            End Get
            Set(ByVal value As List(Of NodePropInfo))
                _nodePropertyInfoCollection = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the node type attribute.
        ''' </summary>
        ''' <returns></returns>
        Public Function GetNodeTypeAttribute() As NodeTypeAttribute
            Return CType(Attribute.GetCustomAttribute(_classType, GetType(NodeTypeAttribute)), NodeTypeAttribute)
        End Function

    End Class

End Namespace