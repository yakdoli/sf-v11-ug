#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.Collections.Generic
Imports System
Imports System.Collections
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Imports System.Reflection
Imports System.ComponentModel

Namespace DataBinding
    ''' <summary>
    ''' Holds the SourceListSet objects in a collection.
    ''' </summary>
    Public Class SourceListSetCollection
        Implements IList(Of SourceListSetEntry)


#Region "Private members"

        Private _sourceListSetColl As List(Of SourceListSetEntry)
        Private _diagramEngine As DiagramDataBindingManagerEngine

#End Region

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SourceListSetCollection"/>
        ''' </summary>
        Public Sub New(ByVal diagram As DiagramDataBindingManagerEngine)
            _diagramEngine = diagram
            _sourceListSetColl = New List(Of SourceListSetEntry)()
        End Sub

#Region "ResolveNode"

        ''' <summary>
        ''' Resolves all the node present in the SourceListSet.
        ''' </summary>
        ''' <param name="item">The item.</param>
        Friend Sub ResolveNodes(ByVal item As SourceListSetEntry)
            If _sourceListSetColl.Contains(item) Then
                Me._diagramEngine.Diagram.BeginUpdate()

                'Loop thru each object that is present inside the IList of SourceListSet.
                For Each itemObj As Object In NodeReflectionStrategy.IterateListSource(item)
                    AddNode(item, itemObj)
                Next itemObj
                'this._diagramEngine.RefreshLayoutManager( );
                Me._diagramEngine.Diagram.EndUpdate()

                If TypeOf item.Source Is System.ComponentModel.IBindingList Then
                    WireBindingList(CType(item.Source, IBindingList))
                End If
            Else
                Throw New ArgumentException("Unknown SourceListSet instance")
            End If
        End Sub

        ''' <summary>
        ''' Processes the node.
        ''' </summary>
        ''' <param name="sourceListItem">The source list item.</param>
        ''' <param name="item">The item.</param>
        ''' <remarks>
        ''' Pass the ith item of the IList along with the SourceListSet. Use NodeReflectionStrategy.GetItemAt() function for better usage.
        ''' </remarks>
        Public Sub AddNode(ByVal sourceListItem As SourceListSetEntry, ByVal item As Object)
            'If sourceListItem.nodeInfoCollection.Find(Sub(nInfo As NodeInfo){ Return item.Equals(nInfo.ObjectInstance);}) Is Nothing Then
            Dim nodeClassInfo As NodeClassInfo = NodeReflectionStrategy.GetNodeClassInfo(item)
            
            Dim node As Node = GenerateNode(item, nodeClassInfo)
            If node IsNot Nothing Then
                'Add the node to the diagram model.
                AddToDiagramModel(CType(node, Node))
                'Add to NodeInfoCollection
                sourceListItem.nodeInfoCollection.Add(New NodeInfo(nodeClassInfo.ClassType, CType(node, Node), item))
                If _diagramEngine.IsNodeAddedEventListening Then
                    'Raise the event. We can customize the look and feel of the nodes in the event listener code.
                    _diagramEngine.RaiseNodeAddedEvent(New NodeAddedEventArgs(sourceListItem.SourceName, CType(node, Node)))
                End If

                For Each nodeRelation As NodeRelationDescriptor In Me._diagramEngine.IterateNodeRelationOfSourceListSetItem(sourceListItem)
                    'Provide ChildSourceList's objects to iterate and connect.
                    Me._diagramEngine.AddConnection(nodeRelation, item)
                Next nodeRelation
            End If
            'End If
        End Sub

        ''' <summary>
        ''' Removes the node.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <param name="nodeObj">The node obj.</param>

        Public Sub RemoveNode(ByVal item As SourceListSetEntry, ByVal nodeObj As Object)
            If TypeOf item.Source Is IBindingList Then
                Me.UnWireBindingList(CType(item.Source, IBindingList))
            End If
            Dim nodeInfo As NodeInfo = Nothing

            For i As Integer = 0 To item.nodeInfoCollection.Count - 1
                If item.nodeInfoCollection(i).ObjectInstance Is nodeObj Then
                    nodeInfo = item.nodeInfoCollection(i)
                End If
            Next i

            If nodeInfo IsNot Nothing Then
                'Remove connection first
                For Each nodeRelation As NodeRelationDescriptor In Me._diagramEngine.IterateNodeRelationOfSourceListSetItem(item)
                    Me._diagramEngine.RemoveNodeFromConnector(nodeRelation, nodeObj)
                Next nodeRelation
                'Remove from inner list
                item.Source.Remove(nodeInfo.ObjectInstance)
                item.nodeInfoCollection.Remove(nodeInfo)
                Me._diagramEngine.Diagram.Model.RemoveChild(nodeInfo.NodeObject)
            End If
            If TypeOf item.Source Is IBindingList Then
                Me.WireBindingList(CType(item.Source, IBindingList))
            End If
        End Sub


        ''' <summary>
        ''' Wires the binding list.
        ''' </summary>
        ''' <param name="item">The item.</param>
        Private Sub WireBindingList(ByVal item As IBindingList)
            AddHandler item.ListChanged, AddressOf item_ListChanged
        End Sub

        ''' <summary>
        ''' Unwire binding list.
        ''' </summary>
        ''' <param name="item">The item.</param>
        Private Sub UnWireBindingList(ByVal item As IBindingList)
            RemoveHandler item.ListChanged, AddressOf item_ListChanged
        End Sub

        ''' <summary>
        ''' Gets the parent source list set from item.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <returns></returns>

        Private Function GetSourceListSetFromList(ByVal item As IList) As SourceListSetEntry
            Dim tListSet As SourceListSetEntry = Nothing
            For Each sourceListSet As SourceListSetEntry In Me._sourceListSetColl
                If sourceListSet.Source Is item Then
                    tListSet = sourceListSet
                    Exit For
                End If
            Next sourceListSet
            Return tListSet
        End Function

        Private Sub item_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
            If e.ListChangedType = ListChangedType.ItemAdded Then
                Dim sourceListSet As SourceListSetEntry = GetSourceListSetFromList(CType(sender, IList))
                If sourceListSet IsNot Nothing Then
                    AddNode(sourceListSet, NodeReflectionStrategy.GetItemAt(CType(sender, IList), e.NewIndex))
                End If
            End If
            Me._diagramEngine.Diagram.Refresh()
        End Sub

        ''' <summary>
        ''' Resolves the node based on the Attribute values specified dynamically.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <param name="nodeClassInfo">The node class info.</param>
        ''' <returns></returns>
        Friend Function GenerateNode(ByVal item As Object, ByVal nodeClassInfo As NodeClassInfo) As Node
            If nodeClassInfo IsNot Nothing Then
                'Generate Node based on the NodeClassInfo and Append it to the Diagram Model
                Dim nodeTypeAttr As NodeTypeAttribute = nodeClassInfo.GetNodeTypeAttribute()
                Dim node As Object = GenerateNode(nodeTypeAttr.NodeType, nodeTypeAttr.Dimensions)
                For Each pInfo As NodePropInfo In nodeClassInfo.NodePropertyInfoCollection
                    Dim nAttr As NodeAttributeAttribute = pInfo.GetCustomAttribute()
                    If nAttr.VisibilityType = VisibleType.Label Then
                        'Add labels to node type. Get the value from the IList item and then add a label.
                        Dim lblText As String = item.GetType().GetProperty(pInfo.PropertyName).GetValue(item, Nothing).ToString()
                        If lblText <> "" Then
                            AddLabel(node, lblText)
                        End If
                    End If
                Next pInfo
                Return CType(node, Node)
            End If
            Return Nothing
        End Function

        Private Function GenerateNode(ByVal nodeType As Type, ByVal nodeRectangleF() As Single) As Object
            Dim node As Object = Nothing
            Dim cInfo As ConstructorInfo = nodeType.GetConstructor(New Type() {GetType(RectangleF)})

            'Check if the NodeRectangle value is given
            If nodeRectangleF.Length = 4 Then
                node = cInfo.Invoke(New Object() {New RectangleF(nodeRectangleF(0), nodeRectangleF(1), nodeRectangleF(2), nodeRectangleF(3))})
            Else
                node = cInfo.Invoke(New Object() {New RectangleF(100, 100, 100, 100)})
            End If
            Return node
        End Function

        ''' <summary>
        ''' Adds the label.
        ''' </summary>
        ''' <param name="node">The node.</param>
        ''' <param name="lblText">The Label text.</param>
        Private Sub AddLabel(ByVal node As Object, ByVal lblText As String)
            Dim lblPropInfo As PropertyInfo = node.GetType().GetProperty("Labels")
            If lblPropInfo IsNot Nothing Then
                'Get the labelCollection object
                Dim lblCollection As Object = lblPropInfo.GetGetMethod().Invoke(node, Nothing)
                Dim lbl As New Label()
                lbl.FontStyle.Family = "Segoe UI"
                lbl.Text = lblText
                lblCollection.GetType().GetMethod("Add").Invoke(lblCollection, New Object() {lbl})
            End If
        End Sub

         
        Private Sub AddToDiagramModel(ByVal nodeInstance As Node)
            Me._diagramEngine.Diagram.Model.AppendChild(nodeInstance)


        End Sub

#End Region

        ''' <summary>
        ''' Raises when the SourceListSet collection is changing.
        ''' </summary>
        Public Event OnSourceListSetChanging As SourceListSetChanging
        ''' <summary>
        ''' Raises when the SourceListSet collection is changed.
        ''' </summary>
        Public Event OnSourceListSetChanged As SourceListSetChanged

        ''' <summary>
        ''' Raises the source list set changing event args.
        ''' </summary>
        ''' <param name="sourceName">Name of the source.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        ''' <returns></returns>
        Private Function RaiseSourceListSetChangingEventArgs(ByVal sourceName As String, ByVal collectionChangedType As CollectionChangingType) As Boolean
            Dim cEvtArgs As New SourceListSetCancelEventArgs(sourceName, collectionChangedType)
            RaiseEvent OnSourceListSetChanging(Me, cEvtArgs)
            Return cEvtArgs.Cancel
        End Function

        ''' <summary>
        ''' Raises the source list set changed event args.
        ''' </summary>
        ''' <param name="source">Name of the source.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        Private Sub RaiseSourceListSetChangedEventArgs(ByVal source As SourceListSetEntry, ByVal collectionChangedType As CollectionChangedType)
            RaiseEvent OnSourceListSetChanged(Me, New SourceListSetEventArgs(source, collectionChangedType))
        End Sub

#Region "IList<SourceListSet> Members"

        ''' <summary>
        ''' Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1"/>.
        ''' </summary>
        ''' <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        ''' <returns>
        ''' The index of <paramref name="item"/> if found in the list; otherwise, -1.
        ''' </returns>
        Public Function IndexOf(ByVal item As SourceListSetEntry) As Integer Implements System.Collections.Generic.IList(Of SourceListSetEntry).IndexOf
            Return _sourceListSetColl.IndexOf(item)
        End Function

        ''' <summary>
        ''' Inserts an item to the <see cref="T:System.Collections.Generic.IList`1"/> at the specified index.
        ''' </summary>
        ''' <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
        ''' <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        ''' <exception cref="T:System.ArgumentOutOfRangeException">
        ''' 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        Public Sub Insert(ByVal index As Integer, ByVal item As SourceListSetEntry) Implements System.Collections.Generic.IList(Of SourceListSetEntry).Insert
            If Not RaiseSourceListSetChangingEventArgs(item.SourceName, CollectionChangingType.Adding) Then
                _sourceListSetColl.Insert(index, item)

                RaiseSourceListSetChangedEventArgs(item, CollectionChangedType.Added)
            End If
        End Sub

        ''' <summary>
        ''' Removes the <see cref="T:System.Collections.Generic.IList`1"/> item at the specified index.
        ''' </summary>
        ''' <param name="index">The zero-based index of the item to remove.</param>
        ''' <exception cref="T:System.ArgumentOutOfRangeException">
        ''' 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        Public Sub RemoveAt(ByVal index As Integer) Implements System.Collections.Generic.IList(Of SourceListSetEntry).RemoveAt
            If index > -1 AndAlso index < _sourceListSetColl.Count Then
                Remove(Me(index))
            Else
                Throw New ArgumentException("Specified index is not valid")
            End If
        End Sub

        ''' <summary>
        ''' Gets or sets the Diagram.DataBinding.SourceListSetEntry at the specified index.
        ''' </summary>
        ''' <value></value>
        Default Public Property Item(ByVal index As Integer) As SourceListSetEntry Implements System.Collections.Generic.IList(Of SourceListSetEntry).Item
            Get
                If index > -1 AndAlso index < _sourceListSetColl.Count Then
                    Return _sourceListSetColl(index)
                End If
                Return Nothing
            End Get
            Set(ByVal value As SourceListSetEntry)
                If index > -1 AndAlso index < Me._sourceListSetColl.Count Then
                    If Not RaiseSourceListSetChangingEventArgs(_sourceListSetColl(index).SourceName, CollectionChangingType.Modifying) Then
                        _sourceListSetColl(index) = value

                        RaiseSourceListSetChangedEventArgs(_sourceListSetColl(index), CollectionChangedType.Modified)
                    End If
                Else
                    Throw New ArgumentException("Specified index is not valid")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the Diagram.DataBinding.SourceListSetEntry with the specified source name.
        ''' </summary>
        ''' <value></value>
        Default Public Property Item(ByVal sourceName As String) As SourceListSetEntry
            Get
                Dim index As Integer = GetIndexOfSourceName(sourceName)
                If index <> -1 Then
                    Return Me(index)
                End If
                Return Nothing
            End Get
            Set(ByVal value As SourceListSetEntry)
                Dim index As Integer = GetIndexOfSourceName(sourceName)
                If index <> -1 Then
                    If Not RaiseSourceListSetChangingEventArgs(sourceName, CollectionChangingType.Modifying) Then
                        Me(index) = value

                        RaiseSourceListSetChangedEventArgs(Me(index), CollectionChangedType.Modified)
                    End If
                Else
                    Throw New ArgumentException("Specified SourceName doesnot exists")
                End If
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>

        Default Public ReadOnly Property Item(ByVal item1 As IList) As SourceListSetEntry
            Get
                Dim tListSet As SourceListSetEntry = Nothing
                'tListSet = _sourceListSetColl.Find(delegate(SourceListSetEntry source)
                '{
                '    return source.Source.GetHashCode() == item.GetHashCode();
                '});
                For i As Integer = 0 To _sourceListSetColl.Count - 1
                    If _sourceListSetColl(i).Source Is item1 Then
                        tListSet = _sourceListSetColl(i)
                    End If
                Next i
                Return tListSet
            End Get
        End Property

        ''' <summary>
        ''' Gets the name of the index of source.
        ''' </summary>
        ''' <param name="sourceName">Name of the source.</param>
        ''' <returns></returns>
        Private Function GetIndexOfSourceName(ByVal sourceName As String) As Integer
            Dim result As Integer = -1
            For i As Integer = 0 To _sourceListSetColl.Count - 1
                If Me(i).SourceName = sourceName Then
                    result = i
                    Exit For
                End If
            Next i
            Return result
        End Function

#End Region


#Region "ICollection<SourceListSet> Members"

        ''' <summary>
        ''' Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        Public Sub Add(ByVal item As SourceListSetEntry) Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).Add
            If Not RaiseSourceListSetChangingEventArgs(item.SourceName, CollectionChangingType.Adding) Then
                Me._sourceListSetColl.Add(item)

                ResolveNodes(item)

                RaiseSourceListSetChangedEventArgs(item, CollectionChangedType.Added)
            End If
        End Sub

        ''' <summary>
        ''' Adds the specified source name.
        ''' </summary>
        ''' <param name="sourceName">Name of the source.</param>
        ''' <param name="source">The source.</param>
        Public Sub Add(ByVal sourceName As String, ByVal source As IList)
            Add(New SourceListSetEntry(sourceName, source))
        End Sub

        ''' <summary>
        ''' Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only. </exception>
        Public Sub Clear() Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).Clear
            For Each listSet As SourceListSetEntry In _sourceListSetColl
                listSet.nodeInfoCollection.Clear()
            Next listSet
            'to reset the event if it is set.
            Me._diagramEngine.ListenToRelationChanges = False
            _sourceListSetColl.Clear()
        End Sub

        ''' <summary>
        ''' Determines whether the <see cref="T:System.Collections.Generic.ICollection`1"/> contains a specific value.
        ''' </summary>
        ''' <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        ''' <returns>
        ''' true if <paramref name="item"/> is found in the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false.
        ''' </returns>
        Public Function Contains(ByVal item As SourceListSetEntry) As Boolean Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).Contains
            Return _sourceListSetColl.Contains(item)
        End Function

        ''' <summary>
        ''' Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1"/> to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
        ''' </summary>
        ''' <param name="array">The one-dimensional <see cref="T:System.Array"/> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1"/>. The <see cref="T:System.Array"/> must have zero-based indexing.</param>
        ''' <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
        ''' <exception cref="T:System.ArgumentNullException">
        ''' 	<paramref name="array"/> is null.</exception>
        ''' <exception cref="T:System.ArgumentOutOfRangeException">
        ''' 	<paramref name="arrayIndex"/> is less than 0.</exception>
        ''' <exception cref="T:System.ArgumentException">
        ''' 	<paramref name="array"/> is multidimensional.-or-<paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.-or-The number of elements in the source <see cref="T:System.Collections.Generic.ICollection`1"/> is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.-or-Type <paramref name="T"/> cannot be cast automatically to the type of the destination <paramref name="array"/>.</exception>
        Public Sub CopyTo(ByVal array() As SourceListSetEntry, ByVal arrayIndex As Integer) Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).CopyTo
            _sourceListSetColl.CopyTo(array, arrayIndex)
        End Sub

        ''' <summary>
        ''' Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <value></value>
        ''' <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</returns>
        Public ReadOnly Property Count() As Integer Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).Count
            Get
                Return _sourceListSetColl.Count
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
        ''' </summary>
        ''' <value></value>
        ''' <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only; otherwise, false.</returns>
        Public ReadOnly Property IsReadOnly() As Boolean Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).IsReadOnly
            Get
                Return False
            End Get
        End Property

        ''' <summary>
        ''' Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        ''' <returns>
        ''' true if <paramref name="item"/> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false. This method also returns false if <paramref name="item"/> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </returns>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        Public Function Remove(ByVal item As SourceListSetEntry) As Boolean Implements System.Collections.Generic.ICollection(Of SourceListSetEntry).Remove
            Dim result As Boolean = False
            If Not RaiseSourceListSetChangingEventArgs(item.SourceName, CollectionChangingType.Removing) Then
                Me._diagramEngine.Diagram.BeginUpdate()
                'Remove the temproary nodes placed inside SoureListSet too
                For Each nInfo As NodeInfo In item.nodeInfoCollection
                    RemoveChild(nInfo.NodeObject)
                Next nInfo
                Me._diagramEngine.Diagram.EndUpdate()

                item.nodeInfoCollection.Clear()
                Dim tSourceListSet As SourceListSetEntry = item.Clone() 'Generating a clone since the item would be removed once it is removed from the collection.
                result = Me._sourceListSetColl.Remove(item)

                RaiseSourceListSetChangedEventArgs(tSourceListSet, CollectionChangedType.Removed)
            End If
            Return result
        End Function

        ''' <summary>
        ''' Removes the child node.
        ''' </summary>
        ''' <param name="NodeObject">The node object.</param>
        Private Sub RemoveChild(ByVal NodeObject As Node)
            _diagramEngine.Diagram.Model.RemoveChild(NodeObject)
        End Sub

        ''' <summary>
        ''' Removes the specified source name.
        ''' </summary>
        ''' <param name="sourceName">Name of the source.</param>
        ''' <returns></returns>
        Public Function Remove(ByVal sourceName As String) As Boolean
            Return Remove(Me(sourceName))
        End Function

#End Region

#Region "IEnumerable<SourceListSet> Members"

        ''' <summary>
        ''' Returns an enumerator that iterates through the collection.
        ''' </summary>
        ''' <returns>
        ''' A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        ''' </returns>
        Public Function GetEnumerator() As IEnumerator(Of SourceListSetEntry) Implements System.Collections.Generic.IEnumerable(Of SourceListSetEntry).GetEnumerator
            Return _sourceListSetColl.GetEnumerator()
        End Function

#End Region

#Region "IEnumerable Members"

        ''' <summary>
        ''' Returns an enumerator that iterates through a collection.
        ''' </summary>
        ''' <returns>
        ''' An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        ''' </returns>
        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return _sourceListSetColl.GetEnumerator()
        End Function

#End Region
         
    End Class
End Namespace
