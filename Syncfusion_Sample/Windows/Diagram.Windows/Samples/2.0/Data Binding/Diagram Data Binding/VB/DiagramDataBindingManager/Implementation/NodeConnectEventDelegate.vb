#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports Syncfusion.Windows.Forms.Diagram
Imports System.ComponentModel

Namespace DataBinding
    ''' <summary>
    ''' EventArgs that is used when NodeConnectEvent is raised
    ''' </summary>
    Public Class NodeConnectEventArgs
        Inherits EventArgs
        Private _parentNode As Node
        ''' <summary>
        ''' Gets or sets the parent node.
        ''' </summary>
        ''' <value>The parent node.</value>
        Public Property ParentNode() As Node
            Get
                Return _parentNode
            End Get
            Set(ByVal value As Node)
                _parentNode = value
            End Set
        End Property

        Private _childNode As Node
        ''' <summary>
        ''' Gets or sets the child node.
        ''' </summary>
        ''' <value>The child node.</value>
        Public Property ChildNode() As Node
            Get
                Return _childNode
            End Get
            Set(ByVal value As Node)
                _childNode = value
            End Set
        End Property

        Private _nodeRelation As NodeRelationDescriptor
        ''' <summary>
        ''' Gets or sets the node relation.
        ''' </summary>
        ''' <value>The node relation.</value>
        Public Property NodeRelation() As NodeRelationDescriptor
            Get
                Return _nodeRelation
            End Get
            Set(ByVal value As NodeRelationDescriptor)
                _nodeRelation = value
            End Set
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeConnectEventArgs"/> [ERROR: invalid expression DeclaringTypeKind].
        ''' </summary>
        ''' <param name="nodeRelation">The node relation.</param>
        ''' <param name="parentNode">The parent node.</param>
        ''' <param name="childNode">The child node.</param>
        Public Sub New(ByVal nodeRelation As NodeRelationDescriptor, ByVal parentNode As Node, ByVal childNode As Node)
            Me._nodeRelation = nodeRelation
            Me._parentNode = parentNode
            Me._childNode = childNode
        End Sub

    End Class
    ''' <summary>
    ''' 
    ''' </summary>   
    Public Class NodeConnectChangingEventArgs
        Inherits CancelEventArgs
        'INSTANT VB NOTE: The variable toNode was renamed since Visual Basic does not allow class members with the same name:
        Private toNode_Renamed As IGraphNode
        ''' <summary>
        ''' Gets to node.
        ''' </summary>
        ''' <value>To node.</value>
        Public ReadOnly Property ToNode() As IGraphNode
            Get
                Return toNode_Renamed
            End Get
        End Property

        'INSTANT VB NOTE: The variable fromNode was renamed since Visual Basic does not allow class members with the same name:
        Private fromNode_Renamed As IGraphNode
        ''' <summary>
        ''' Gets from node.
        ''' </summary>
        ''' <value>From node.</value>
        Public ReadOnly Property FromNode() As IGraphNode
            Get
                Return fromNode_Renamed
            End Get
        End Property

        Private _collectionChangedType As CollectionExChangeType
        ''' <summary>
        ''' Gets the type of the collection changed.
        ''' </summary>
        ''' <value>The type of the collection changed.</value>
        Public ReadOnly Property CollectionChangedType() As CollectionExChangeType
            Get
                Return _collectionChangedType
            End Get
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeConnectChangingEventArgs"/> [ERROR: invalid expression DeclaringTypeKind].
        ''' </summary>
        ''' <param name="collectionChangedType">Name of the node relation.</param>
        ''' <param name="fromNode">From node.</param>
        ''' <param name="toNode">To node.</param>
        Public Sub New(ByVal fromNode As IGraphNode, ByVal toNode As IGraphNode, ByVal collectionChangedType As CollectionExChangeType)
            Me.fromNode_Renamed = fromNode
            Me.toNode_Renamed = toNode
            Me._collectionChangedType = collectionChangedType
        End Sub

    End Class
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class NodeConnectChangedEventArgs
        Inherits EventArgs
        'INSTANT VB NOTE: The variable toNode was renamed since Visual Basic does not allow class members with the same name:
        Private toNode_Renamed As IGraphNode

        ''' <summary>
        ''' Gets or sets to node.
        ''' </summary>
        ''' <value>To node.</value>
        Public ReadOnly Property ToNode() As IGraphNode
            Get
                Return toNode_Renamed
            End Get
        End Property

        'INSTANT VB NOTE: The variable fromNode was renamed since Visual Basic does not allow class members with the same name:
        Private fromNode_Renamed As IGraphNode

        ''' <summary>
        ''' Gets or sets from node.
        ''' </summary>
        ''' <value>From node.</value>
        Public ReadOnly Property FromNode() As IGraphNode
            Get
                Return fromNode_Renamed
            End Get
        End Property

        Private _collectionChangedType As CollectionExChangeType
        ''' <summary>
        ''' Gets the type of the collection changed.
        ''' </summary>
        ''' <value>The type of the collection changed.</value>
        Public ReadOnly Property CollectionChangedType() As CollectionExChangeType
            Get
                Return _collectionChangedType
            End Get
        End Property
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeConnectChangedEventArgs"/>
        ''' </summary>
        ''' <param name="collectionChangedType">Name of the node relation.</param>
        ''' <param name="fromNode">From node.</param>
        ''' <param name="toNode">To node.</param>
        Public Sub New(ByVal fromNode As IGraphNode, ByVal toNode As IGraphNode, ByVal collectionChangedType As CollectionExChangeType)
            Me.fromNode_Renamed = fromNode
            Me.toNode_Renamed = toNode
            Me._collectionChangedType = collectionChangedType
        End Sub
       
    End Class


    ''' <summary>
    ''' Delegate to be used when connecting two nodes
    ''' </summary>
    ''' <param name="args">NodeConnectEventArgs</param>
    Public Delegate Function NodeConnectEventHandler(ByVal args As NodeConnectEventArgs) As ConnectorBase


    ''' <summary>
    ''' Delegate used when connection is changing.
    ''' </summary>    
    ''' <param name="args"></param>
    Public Delegate Sub NodeConnectChangingEventHandler(ByVal args As NodeConnectChangingEventArgs)

    ''' <summary>
    ''' Delegate used when the connection is changed.
    ''' </summary>    
    ''' <param name="args"></param>
    Public Delegate Sub NodeConnectChangedEventHandler(ByVal args As NodeConnectChangedEventArgs)

End Namespace