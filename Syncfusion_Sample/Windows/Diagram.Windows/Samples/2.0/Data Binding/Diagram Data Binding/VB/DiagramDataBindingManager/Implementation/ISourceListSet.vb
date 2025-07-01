#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace DataBinding
    ''' <summary>
    ''' Contains the base implementation of SourceListSet objects. These objects represent the business objects that is to be binded with the Diagram instance.
    ''' </summary>
    Friend Interface ISourceListSetEntry
        ''' <summary>
        ''' Gets or sets the name of the source.
        ''' </summary>
        ''' <value>The name of the source.</value>
        Property SourceName() As String

        ''' <summary>
        ''' Gets or sets the source.
        ''' </summary>
        ''' <value>The source.</value>
        Property Source() As IList
    End Interface

#Region "EventArgs Impl Classes"
    ''' <summary>
    ''' Defines the EventArgs for SourceListSet
    ''' </summary>
    Public Class SourceListSetEventArgs
        Inherits EventArgs
        Private _source As SourceListSetEntry
        ''' <summary>
        ''' Gets or sets the name of the source.
        ''' </summary>
        ''' <value>The name of the source.</value>
        Public Property Source() As SourceListSetEntry
            Get
                Return _source
            End Get
            Set(ByVal value As SourceListSetEntry)
                _source = value
            End Set
        End Property

        Private _collectionChangedType As CollectionChangedType
        ''' <summary>
        ''' Gets the type of the collection changed.
        ''' </summary>
        ''' <value>The type of the collection changed.</value>
        Public ReadOnly Property CollectionChangedType() As CollectionChangedType
            Get
                Return _collectionChangedType
            End Get
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SourceListSetEventArgs"/>.
        ''' </summary>
        ''' <param name="source">Name of the source.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        Public Sub New(ByVal source As SourceListSetEntry, ByVal collectionChangedType As CollectionChangedType)
            Me._source = source
            Me._collectionChangedType = collectionChangedType
        End Sub

    End Class

    ''' <summary>
    ''' Defines the Cancel Event args for SourceListSet.
    ''' </summary>
    Public Class SourceListSetCancelEventArgs
        Inherits CancelEventArgs
        Private _sourceName As String
        ''' <summary>
        ''' Gets or sets the name of the source.
        ''' </summary>
        ''' <value>The name of the source.</value>
        Public Property SourceName() As String
            Get
                Return _sourceName
            End Get
            Set(ByVal value As String)
                _sourceName = value
            End Set
        End Property

        Private _collectionChangedType As CollectionChangingType
        ''' <summary>
        ''' Gets the type of the collection changed.
        ''' </summary>
        ''' <value>The type of the collection changed.</value>
        Public ReadOnly Property CollectionChangedType() As CollectionChangingType
            Get
                Return _collectionChangedType
            End Get
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SourceListSetCancelEventArgs"/>.
        ''' </summary>
        ''' <param name="sourceName">Name of the source.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        Public Sub New(ByVal sourceName As String, ByVal collectionChangedType As CollectionChangingType)
            Me._sourceName = sourceName
            Me._collectionChangedType = collectionChangedType
        End Sub

    End Class

#End Region

#Region "Delegates"
    ''' <summary>
    ''' Delegate for SourceListSetChanged event.
    ''' </summary>
    ''' <param name="sender">object</param>
    ''' <param name="args"><see cref="SourceListSetEventArgs"/></param>
    Public Delegate Sub SourceListSetChanged(ByVal sender As Object, ByVal args As SourceListSetEventArgs)
    ''' <summary>
    ''' Delegate for SourceListSetChanging event.
    ''' </summary>
    ''' <param name="sender">object</param>
    ''' <param name="args"><see cref="SourceListSetCancelEventArgs"/></param>
    Public Delegate Sub SourceListSetChanging(ByVal sender As Object, ByVal args As SourceListSetCancelEventArgs)

#End Region
End Namespace