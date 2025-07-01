#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Diagram

Namespace DataBinding


    ''' <summary>
    ''' Delegate for customizing the node before it is added to the Diagram Model.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="args"></param>
    Public Delegate Sub NodeAddedEventHandler(ByVal sender As Object, ByVal args As NodeAddedEventArgs)

    ''' <summary>
    ''' Defines the interface for Diagram OM
    ''' </summary>
    Friend Interface IDiagramEngine
        ''' <summary>
        ''' EventHandler for customizing nodes when they are added to the Diagram Model.
        ''' </summary>
        Event NodeAdded As NodeAddedEventHandler
        ''' <summary>
        ''' Gets the Diagram model.
        ''' </summary>
        ''' <value>The Diagram.</value>
        ReadOnly Property Diagram() As Diagram

        ''' <summary>
        ''' Gets the source list set keys.
        ''' </summary>
        ''' <value>The source list set keys.</value>
        ReadOnly Property SourceListSet() As SourceListSetCollection

        ''' <summary>
        ''' Gets the NodeReflectionStrategy instance.
        ''' </summary>
        ReadOnly Property ReflectionStrategy() As NodeReflectionStrategy

        ''' <summary>
        ''' Returns the LayoutManager associated with the DiagramDataBindingManager.
        ''' </summary>
        ReadOnly Property LayoutManagerDescriptor() As LayoutManager

        ''' <summary>
        ''' Sets the parameters for holding all the updates.
        ''' </summary>
        Sub BeginUpdate()

        ''' <summary>
        ''' Resets the parameters and refreshes the updates from the DiagramDataBindingManager to the Diagram control.
        ''' </summary>
        Sub EndUpdate()

    End Interface

    ''' <summary>
    ''' EventArgs implementation when Node is added to the Diagram Model.
    ''' </summary>
    Public Class NodeAddedEventArgs
        Inherits EventArgs
        Private _source As String
        ''' <summary>
        ''' Gets the source.
        ''' </summary>
        ''' <value>The source.</value>
        Public Property SourceName() As String
            Get
                Return _source
            End Get
            Set(ByVal value As String)
                _source = value
            End Set
        End Property

        Private _node As Node
        ''' <summary>
        ''' Gets the node object.
        ''' </summary>
        ''' <value>The node object.</value>
        Public Property NodeObject() As Node
            Get
                Return _node
            End Get
            Set(ByVal value As Node)
                _node = value
            End Set
        End Property

        ''' <summary>
        ''' Initializes a new instance of the NodesCollectionEventArgs 
        ''' </summary>
        ''' <param name="source">The source.</param>
        ''' <param name="node">The node.</param>
        Public Sub New(ByVal source As String, ByVal node As Node)
            Me._source = source
            Me._node = node
        End Sub

    End Class
End Namespace