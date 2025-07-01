Imports System
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports Syncfusion.Windows.Forms.Diagram

Namespace DataBinding
    Public Class DiagramDataBindingManagerEngine
        Implements IDiagramEngine, INodeRelationDescriptor

        Private diagram_Renamed As Diagram
        Private nodeReflectionStrategy As NodeReflectionStrategy
        
        Public Sub New(ByVal diagram As Diagram)
            _sourceListSetColl = New SourceListSetCollection(Me)
            nodeReflectionStrategy = New NodeReflectionStrategy()
            'Initialize NodeRelationCollection and hook it to listen any new node relations added to the Diagram.
            nodeRelationCollection = New NodeRelationCollection(Me)
            AddHandler nodeRelationCollection.NodeRelationCollectionChanged, AddressOf nodeRelationCollection_NodeRelationCollectionChanged
            HookUpDiagram(diagram)
        End Sub

        Private Sub nodeRelationCollection_NodeRelationCollectionChanged(ByVal sender As Object, ByVal args As NodeRelationEventArgs)
            If args.CollectionChangedType = CollectionChangedType.Added Then
                Me.BeginUpdate()
                ResolveNodeRelations(args.Relation.RelationName)
                Me.EndUpdate()
            End If
        End Sub

        
        Protected Overrides Sub Finalize()
            nodeReflectionStrategy.TearDown()
            _sourceListSetColl.Clear()
            TearDown()
        End Sub

#Region "IDiagramEngine Members"
        ''' <summary>
        ''' Implement this event handler to customize the node before it is added to the Diagram Model.
        ''' </summary>
        Public Event NodeAdded As NodeAddedEventHandler Implements IDiagramEngine.NodeAdded

        Friend Sub RaiseNodeAddedEvent(ByVal args As NodeAddedEventArgs)
            RaiseEvent NodeAdded(Me, args)
        End Sub

        ''' <summary>
        ''' used for checking across different class instances if the DiagramDataBindingManager is listening to the QueryNodeStyleInfo event.
        ''' </summary>
        Friend ReadOnly Property IsNodeAddedEventListening() As Boolean
            Get
                If NodeAddedEvent Is Nothing Then
                    Return False
                Else
                    Return True
                End If

            End Get
        End Property
        Public _ProvideNodeConnectorInfo As NodeConnectEventHandler

        Friend ReadOnly Property isNodeConnectStyleListening() As Boolean
            Get
                If _ProvideNodeConnectorInfo Is Nothing Then
                    Return False
                Else
                    Return True
                End If
            End Get
        End Property

        Friend Function RaiseNodeConnectStyleInfo(ByVal args As NodeConnectEventArgs) As ConnectorBase
            Return _ProvideNodeConnectorInfo(args)
        End Function

        ''' <summary>
        ''' Gets the Diagram model.
        ''' </summary>
        ''' <value>The Diagram.</value>
        Public ReadOnly Property Diagram() As Diagram Implements IDiagramEngine.Diagram
            Get
                Return diagram_Renamed
            End Get
        End Property
        ''' <summary>
        ''' Returns the LayoutManager associated with the DiagramDataBindingManager.
        ''' </summary>
        ''' <value></value>
        Public ReadOnly Property LayoutManagerDescriptor() As LayoutManager Implements IDiagramEngine.LayoutManagerDescriptor
            Get
                If Me.diagram_Renamed.LayoutManager IsNot Nothing Then
                    Return Me.diagram_Renamed.LayoutManager
                Else
                    Return Nothing
                End If

            End Get
        End Property
        ''' <summary>
        ''' Updates / Refreshes the LayoutManager.
        ''' </summary>
        Public Sub RefreshLayoutManager()
            If Me.LayoutManagerDescriptor IsNot Nothing AndAlso _canUpdateAlways Then
                For Each node As Node In Me.Diagram.Model.Nodes
                    If Not Me.LayoutManagerDescriptor.Nodes.Contains(node) Then
                        Me.LayoutManagerDescriptor.Nodes.Add(node)
                    End If
                Next node
                Me.LayoutManagerDescriptor.UpdateLayout(Nothing)
            End If
        End Sub
        Private _sourceListSetColl As SourceListSetCollection
        ''' <summary>
        ''' Gets or sets the source list set keys.
        ''' </summary>
        ''' <value>The source list set keys.</value>
        Public ReadOnly Property SourceListSet() As SourceListSetCollection Implements IDiagramEngine.SourceListSet
            Get
                Return _sourceListSetColl
            End Get
        End Property
        ''' <summary>
        ''' Gets the NodeReflectionStrategy instance. Use this to dynamically load the NodeType attribute marked classes into the DiagramDataBindingManager.
        ''' </summary>
        ''' <value></value>
        Public ReadOnly Property ReflectionStrategy() As NodeReflectionStrategy Implements IDiagramEngine.ReflectionStrategy
            Get
                Return nodeReflectionStrategy
            End Get
        End Property
        ''' <summary>
        ''' Hooks the diagram with the DiagramDataBindingManager.
        ''' </summary>
        ''' <param name="diagram">The diagram.</param>
        Protected Overridable Sub HookUpDiagram(ByVal diagram As Diagram)
            Me.diagram_Renamed = diagram
            nodeReflectionStrategy.BuildUp(System.Reflection.Assembly.GetEntryAssembly())
        End Sub
        Private _canUpdateAlways As Boolean = True
        ''' <summary>
        ''' Sets the parameters for holding all the updates.
        ''' </summary>
        Public Sub BeginUpdate() Implements IDiagramEngine.BeginUpdate
            _canUpdateAlways = False
        End Sub
        ''' <summary>
        ''' Resets the parameters and refreshes the updates from the DiagramDataBindingManager to the Diagram control.
        ''' </summary>
        Public Sub EndUpdate() Implements IDiagramEngine.EndUpdate
            _canUpdateAlways = True
            RefreshLayoutManager()
        End Sub
#End Region

#Region "INodeRelationDescriptor Members"
        Private nodeRelationCollection As NodeRelationCollection
        ''' <summary>
        ''' Gets or sets the node relation keys.
        ''' </summary>
        ''' <value>The node relation keys.</value>
        Public Property Relations() As NodeRelationCollection Implements INodeRelationDescriptor.Relations
            Get
                Return nodeRelationCollection
            End Get
            Set(ByVal value As NodeRelationCollection)
                nodeRelationCollection = value
            End Set
        End Property

#Region "NodeConnection change events"

        Private _listenToRelationChanges As Boolean
        ''' <summary>
        ''' Gets or sets a value indicating whether the Engine should listen to changes done on the Node's relation change
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if [listen to relation changes]; otherwise, <c>false</c>.
        ''' </value>
        Public Property ListenToRelationChanges() As Boolean Implements INodeRelationDescriptor.ListenToRelationChanges
            Get
                Return _listenToRelationChanges
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    WireDiagramConnectionsEvent()
                Else
                    UnWireDiagramConnectionsEvent()
                End If

                _listenToRelationChanges = value
            End Set
        End Property
        Private Sub WireDiagramConnectionsEvent()
            AddHandler (CType(Diagram.Model.EventSink, DocumentEventSink)).ConnectionsChanged, AddressOf NodeRelationDescriptor_ConnectionsChanged
        End Sub
        Private Sub UnWireDiagramConnectionsEvent()
            RemoveHandler (CType(Diagram.Model.EventSink, DocumentEventSink)).ConnectionsChanged, AddressOf NodeRelationDescriptor_ConnectionsChanged
        End Sub
        Private isConnectionRemoved As Boolean = False 'this flag checks if the connection is removed first and then inserted. Only in this sequence we can raise the NodeConnectionsChanged event properly
        Private Sub NodeRelationDescriptor_ConnectionsChanged(ByVal evtArgs As CollectionExEventArgs)
            If evtArgs.Element IsNot Nothing Then
                Dim connector As ConnectorBase = TryCast((CType(evtArgs.Element, EndPoint)).Container, ConnectorBase)
                If evtArgs.ChangeType = CollectionExChangeType.Remove Then
                    isConnectionRemoved = True
                ElseIf evtArgs.ChangeType = CollectionExChangeType.Insert AndAlso isConnectionRemoved Then
                    'Raise the node connected event handler after the connection gets inserted.
                    RaiseNodeConnectChangedEventHandler(New NodeConnectChangedEventArgs(connector.FromNode, connector.ToNode, evtArgs.ChangeType))
                End If
            End If
        End Sub

        ''' <summary>
        ''' Event raised when a node connection is changed from a childnode to some other child node.
        ''' </summary>
        Public Event NodeConnectChanged As NodeConnectChangedEventHandler Implements INodeRelationDescriptor.NodeConnectChanged
        Private Sub RaiseNodeConnectChangedEventHandler(ByVal args As NodeConnectChangedEventArgs)
            RaiseEvent NodeConnectChanged(args)
        End Sub

#End Region

        ''' <summary>
        ''' Clears up memory used.
        ''' </summary>
        Public Sub TearDown() Implements INodeRelationDescriptor.TearDown
            nodeRelationCollection.Clear()
        End Sub

#Region "Resolve Node relations"

        ''' <summary>
        ''' Connects the parent node and child node based on the node relation. Iterates all the nodes present in the NodeRelation and connects it.
        ''' </summary>
        Friend Sub ResolveNodeRelations(ByVal relationName As String)
            Dim nodeRelation As NodeRelationDescriptor = Me.nodeRelationCollection(relationName)
            If nodeRelation IsNot Nothing Then
                'Ensure that the IList is present with the ChildSourceName
                If Me.SourceListSet(nodeRelation.ChildSourceName) IsNot Nothing Then
                    Diagram.BeginUpdate()

                    'Iterate thru the ChildSourceList and process the connections
                    For Each item As Object In DataBinding.NodeReflectionStrategy.IterateListSource(Me.SourceListSet(nodeRelation.ChildSourceName))
                        AddConnection(nodeRelation, item)
                    Next item

                    Diagram.EndUpdate()
                Else
                    Throw New ArgumentException("object passed is not an instance of " & Me.SourceListSet(nodeRelation.ChildSourceName).SourceName)
                End If
            End If
        End Sub

        ''' <summary>
        ''' Processes the connection.
        ''' </summary>
        ''' <param name="nodeRelation">The node relation.</param>
        ''' <param name="listItem">The item present in the IList provided as source.</param>
        Friend Sub AddConnection(ByVal nodeRelation As NodeRelationDescriptor, ByVal listItem As Object)
            If CheckItemInCollection(Me.SourceListSet(nodeRelation.ChildSourceName), listItem) Then
                If nodeRelation.RelationType = RelationType.ParentChild Then
                    Dim childSourceList As SourceListSetEntry = Me.SourceListSet(nodeRelation.ChildSourceName)
                    Dim parentSourceList As SourceListSetEntry = Me.SourceListSet(nodeRelation.ParentSourceName)
                    ProcessConnection(nodeRelation, childSourceList, parentSourceList, listItem)
                ElseIf nodeRelation.RelationType = RelationType.SelfRelation Then
                    'if the RelationType is a SelfRelation one, it will take the SourceListSet based on the ChildSourceName of the NodeRelation.
                    Dim sourceList As SourceListSetEntry = Me.SourceListSet(nodeRelation.ChildSourceName)
                    ProcessConnection(nodeRelation, sourceList, sourceList, listItem)
                End If
            Else
                Throw New ArgumentException("object passed is not an instance of " & Me.SourceListSet(nodeRelation.ChildSourceName).SourceName)
            End If
        End Sub

        Private Sub ProcessConnection(ByVal nodeRelation As NodeRelationDescriptor, ByVal childSourceList As SourceListSetEntry, ByVal parentSourceList As SourceListSetEntry, ByVal item As Object)
            Dim connector As ConnectorBase = Nothing
            Dim parentNode As Node = GetParentNodeFromSourceListSet(parentSourceList, item, nodeRelation.ChildID, nodeRelation.ParentID)
            Dim childNode As Node = GetChildNodeFromSourceListSet(childSourceList, item)

            If parentNode IsNot Nothing AndAlso childNode IsNot Nothing AndAlso (Not CheckParentAndChildNodeAlreadyConnected(parentNode, childNode)) Then
                If Not isNodeConnectStyleListening Then
                    'Connect nodes
                    connector = ConnectNodes(parentNode, childNode)
                Else
                    'Raise the event to customize the connectors
                    connector = RaiseQueryNodeConnectorStyleInfoHandler(nodeRelation, parentNode, childNode)
                End If
            End If
            'Append the Connector to the DiagramModel.
            If connector IsNot Nothing Then
                Diagram.Model.AppendChild(connector)
                Diagram.Model.SendToBack(connector)
                nodeRelation.nodeConnections.Add(connector)
            End If
        End Sub

        ''' <summary>
        ''' Gets the parent node from source list set.
        ''' </summary>
        ''' <param name="itemList">The item list.</param>
        ''' <param name="item">The item.</param>
        ''' <param name="childId">The child id.</param>
        ''' <param name="parentId">The parent id.</param>
        ''' <returns></returns>
        Private Function GetParentNodeFromSourceListSet(ByVal itemList As SourceListSetEntry, ByVal item As Object, ByVal childId As String, ByVal parentId As String) As Node
            Dim nodeInfo As NodeInfo = Nothing
            Dim ManagerId As Integer = Convert.ToInt32(item.GetType().GetProperty(parentId).GetValue(item, Nothing).ToString())
            For i As Integer = 0 To itemList.nodeInfoCollection.Count - 1
                If ManagerId = Convert.ToInt32(itemList.nodeInfoCollection(i).ObjectInstance.GetType().GetProperty(childId).GetValue(itemList.nodeInfoCollection(i).ObjectInstance, Nothing)) Then
                    nodeInfo = itemList.nodeInfoCollection(i)
                    Exit For
                End If
            Next i
            If nodeInfo IsNot Nothing Then
                Return nodeInfo.NodeObject
            End If
            Return Nothing
        End Function

        ''' <summary>
        ''' Gets the child node from source list set.
        ''' </summary>
        ''' <param name="itemList">The item list.</param>
        ''' <param name="item">The item.</param>
        ''' <returns></returns>
        Private Function GetChildNodeFromSourceListSet(ByVal itemList As SourceListSetEntry, ByVal item As Object) As Node
            Dim nInfo As NodeInfo = Nothing
            For i As Integer = 0 To itemList.nodeInfoCollection.Count - 1
                If itemList.nodeInfoCollection(i).ObjectInstance Is item Then
                    nInfo = itemList.nodeInfoCollection(i)
                End If
            Next i
            If nInfo IsNot Nothing Then
                Return nInfo.NodeObject
            End If
            Return Nothing
        End Function

        ''' <summary>
        ''' Raises the query node connector style info handler.
        ''' </summary>
        ''' <param name="nodeRelation">The node relation.</param>
        ''' <param name="parentNode">The parent node.</param>
        ''' <param name="childNode">The child node.</param>
        Private Function RaiseQueryNodeConnectorStyleInfoHandler(ByVal nodeRelation As NodeRelationDescriptor, ByVal parentNode As Node, ByVal childNode As Node) As ConnectorBase
            'raise the event to customize the connectors.
            Return RaiseNodeConnectStyleInfo(New NodeConnectEventArgs(nodeRelation, parentNode, childNode))
        End Function

        ''' <summary>
        ''' Connects the nodes.
        ''' </summary>
        ''' <param name="parentNode">The parent node.</param>
        ''' <param name="childNode">The child node.</param>
        ''' <returns></returns>
        Private Function ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node) As ConnectorBase

            'Check if parentNode and childNode is not NULL and then connect it
            If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then
                Dim connector As New LineConnector(PointF.Empty, New PointF(0, 1))
                connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
                connector.LineStyle.LineColor = Color.Gray
                connector.HeadDecorator.FillStyle.Color = Color.LightGray
                'Connect the nodes
                parentNode.CentralPort.TryConnect(connector.TailEndPoint)
                childNode.CentralPort.TryConnect(connector.HeadEndPoint)
                Return connector
            End If
            Return Nothing
        End Function

        Private Function CheckParentAndChildNodeAlreadyConnected(ByVal parentNode As Node, ByVal childNode As Node) As Boolean
            Dim isAlreadyConnected As Boolean = False

            Dim thisNode As IGraphNode = TryCast(parentNode, IGraphNode)

            If thisNode IsNot Nothing Then
                Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
                If edgesLeaving IsNot Nothing Then
                    For Each curEdge As IGraphEdge In edgesLeaving
                        ' Get from IGraphEdge link.
                        Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)
                        If outlink IsNot Nothing Then
                            Dim tChildNode As Node = TryCast(outlink.ToNode, Node)
                            If tChildNode.Equals(childNode) Then
                                isAlreadyConnected = True
                                Exit For
                            End If
                        End If
                    Next curEdge
                End If
            End If
            Return isAlreadyConnected
        End Function

#End Region

        ''' <summary>
        ''' Removes the node from connector.
        ''' </summary>
        ''' <param name="nodeRelation">The node relation.</param>
        ''' <param name="nodeObj">The node obj.</param>
        ''' <remarks>
        ''' If the Connector is removed at both ends it would be automatically removed from the inner collection.
        ''' </remarks>
        Public Sub RemoveNodeFromConnector(ByVal nodeRelation As NodeRelationDescriptor, ByVal nodeObj As Object) Implements INodeRelationDescriptor.RemoveNodeFromConnector
            If CheckItemInCollection(Me.SourceListSet(nodeRelation.ChildSourceName), nodeObj) Then
                Dim childNode As Node = GetChildNodeFromSourceListSet(Me.SourceListSet(nodeRelation.ChildSourceName), nodeObj)
                Dim tNode As IGraphNode = TryCast(childNode, IGraphNode)
                If tNode IsNot Nothing Then
                    For Each connector As ConnectorBase In IterateEdges(childNode, tNode.EdgesEntering)
                        Diagram.Model.RemoveChild(connector)
                        nodeRelation.nodeConnections.Remove(connector)
                    Next connector
                    For Each connector As ConnectorBase In IterateEdges(childNode, tNode.EdgesLeaving)
                        Diagram.Model.RemoveChild(connector)
                        nodeRelation.nodeConnections.Remove(connector)
                    Next connector
                End If
            Else
                Throw New ArgumentException("object passed is not an instance of " & Me.SourceListSet(nodeRelation.ChildSourceName).SourceName)
            End If

        End Sub

        Private Function IterateEdges(ByVal childNode As Node, ByVal edges As ICollection) As IEnumerable(Of ConnectorBase)
            Dim connectorCount As List(Of ConnectorBase) = New List(Of ConnectorBase)
            If edges IsNot Nothing Then
                For Each curEdge As IGraphEdge In edges
                    ' Get from IGraphEdge link.
                    Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)
                    If outlink IsNot Nothing Then
                        childNode.CentralPort.Disconnect(outlink.HeadEndPoint)
                        connectorCount.Add(outlink)
                    End If
                Next curEdge
            End If
            Return connectorCount
        End Function

        ''' <summary>
        ''' Iterates the node relation of source list set.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <returns></returns>
        Public Function IterateNodeRelationOfSourceListSetItem(ByVal item As SourceListSetEntry) As System.Collections.Generic.IEnumerable(Of NodeRelationDescriptor) Implements INodeRelationDescriptor.IterateNodeRelationOfSourceListSetItem
            Dim nodeRelation As List(Of NodeRelationDescriptor) = New List(Of NodeRelationDescriptor)
            For Each nRelation As NodeRelationDescriptor In Me.Relations
                If nRelation.ChildSourceName = item.SourceName Then
                    nodeRelation.Add(nRelation)
                End If
            Next nRelation
            Return nodeRelation
        End Function

        Private Function CheckItemInCollection(ByVal source As SourceListSetEntry, ByVal Obj As Object) As Boolean
            Dim result As Boolean = False
            For Each o As Object In DataBinding.NodeReflectionStrategy.IterateListSource(source)
                If o.Equals(Obj) Then
                    result = True
                    Exit For
                End If
            Next o
            Return result
        End Function

#End Region

    End Class

End Namespace