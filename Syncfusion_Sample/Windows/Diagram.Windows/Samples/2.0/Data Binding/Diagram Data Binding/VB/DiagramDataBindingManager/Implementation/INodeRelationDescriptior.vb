#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports Syncfusion.Windows.Forms.Diagram

Namespace DataBinding
    ''' <summary>
    ''' Provides the Enumeration for CollectionChangedType enum.
    ''' </summary>
    Public Enum CollectionChangedType
        ''' <summary>
        ''' 
        ''' </summary>
        Added
        ''' <summary>
        ''' 
        ''' </summary>
        Modified
        ''' <summary>
        ''' 
        ''' </summary>
        Removed
    End Enum

    ''' <summary>
    ''' Provides the Enumeration for CollectionChanging enum.
    ''' </summary>
    Public Enum CollectionChangingType
        ''' <summary>
        ''' 
        ''' </summary>
        Adding
        ''' <summary>
        ''' 
        ''' </summary>
        Modifying
        ''' <summary>
        ''' 
        ''' </summary>
        Removing
    End Enum

    ''' <summary>
    ''' Defines the EventArgs value for NodeRelation
    ''' </summary>
    Public Class NodeRelationEventArgs
        Inherits EventArgs
        Private _collectionChangedType As CollectionChangedType
        ''' <summary>
        ''' Gets the CollectionChangedType instance.
        ''' </summary>
        ''' <value>The type of the collection changed.</value>
        Public ReadOnly Property CollectionChangedType() As CollectionChangedType
            Get
                Return _collectionChangedType
            End Get
        End Property

        Private _relation As NodeRelationDescriptor
        ''' <summary>
        ''' Gets the name of the relation.
        ''' </summary>
        ''' <value>The name of the relation.</value>
        Public ReadOnly Property Relation() As NodeRelationDescriptor
            Get
                Return _relation
            End Get
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeRelationEventArgs"/> 
        ''' </summary>
        ''' <param name="relation">Name of the relation.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        Public Sub New(ByVal relation As NodeRelationDescriptor, ByVal collectionChangedType As CollectionChangedType)
            _relation = relation
            _collectionChangedType = collectionChangedType
        End Sub
    End Class

    ''' <summary>
    ''' Defines the CancelEventArgs for NodeRelation
    ''' </summary>
    Public Class NodeRelationCancelEventArgs
        Inherits System.ComponentModel.CancelEventArgs
        Private _collectionChangedType As CollectionChangingType
        ''' <summary>
        ''' Gets the CollectionChangedType instance.
        ''' </summary>
        ''' <value>The type of the collection changed.</value>
        Public ReadOnly Property CollectionChangedType() As CollectionChangingType
            Get
                Return _collectionChangedType
            End Get
        End Property

        Private _relationName As String
        ''' <summary>
        ''' Gets the name of the relation.
        ''' </summary>
        ''' <value>The name of the relation.</value>
        Public ReadOnly Property RelationName() As String
            Get
                Return _relationName
            End Get
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeRelationCancelEventArgs"/>.
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        Public Sub New(ByVal relationName As String, ByVal collectionChangedType As CollectionChangingType)
            _relationName = relationName
            _collectionChangedType = collectionChangedType
        End Sub

    End Class
    ''' <summary>
    ''' 
    ''' </summary>
    Public Delegate Sub NodeRelationCollectionChangingEventHandler(ByVal sender As Object, ByVal args As NodeRelationCancelEventArgs)
    ''' <summary>
    ''' 
    ''' </summary>
    Public Delegate Sub NodeRelationCollectionChangedEventHandler(ByVal sender As Object, ByVal args As NodeRelationEventArgs)

    ''' <summary>
    ''' Delegate used when the NodeRelation is changing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="args"></param>
    Public Delegate Sub NodeRelationChanging(ByVal sender As Object, ByVal args As NodeRelationCancelEventArgs)

    ''' <summary>
    ''' Delegate used when the NodeRelation is changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="args"></param>
    Public Delegate Sub NodeRelationChanged(ByVal sender As Object, ByVal args As NodeRelationEventArgs)

    ''' <summary>
    ''' Defines all the base implementation for NodeRelationDescriptor.
    ''' </summary>
    Friend Interface INodeRelationDescriptor
        ''' <summary>
        ''' Gets or sets a value indicating whether 
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if [listen to relation changes]; otherwise, <c>false</c>.
        ''' </value>
        Property ListenToRelationChanges() As Boolean


        ''' <summary>
        ''' Event raised when a node connection is changed from a childnode to some other child node.
        ''' </summary>
        Event NodeConnectChanged As NodeConnectChangedEventHandler


        ''' <summary>
        ''' Gets or sets the node relation keys.
        ''' </summary>
        ''' <value>The node relation keys.</value>
        Property Relations() As NodeRelationCollection

        ''' <summary>
        ''' Clears up memory used.
        ''' </summary>
        Sub TearDown()

        ''' <summary>
        ''' Iterates the node relation of source list set.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <returns></returns>
        Function IterateNodeRelationOfSourceListSetItem(ByVal item As SourceListSetEntry) As IEnumerable(Of NodeRelationDescriptor)

        ''' <summary>
        ''' Removes the node from connector.
        ''' </summary>
        ''' <param name="nodeRelation">The node relation.</param>
        ''' <param name="nodeObj">The node obj.</param>
        ''' <remarks>
        ''' If the Connector is removed at both ends it would be automatically removed from the inner collection.
        ''' </remarks>
        Sub RemoveNodeFromConnector(ByVal nodeRelation As NodeRelationDescriptor, ByVal nodeObj As Object)
    End Interface
End Namespace
