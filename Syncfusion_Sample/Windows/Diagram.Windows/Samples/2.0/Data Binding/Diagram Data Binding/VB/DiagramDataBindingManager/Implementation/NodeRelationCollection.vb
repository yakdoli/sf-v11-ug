#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.Collections.Generic
Imports System.Collections
Imports Syncfusion.Windows.Forms.Diagram
Imports System

Namespace DataBinding
    ''' <summary>
    ''' Defines the RelationType for the NodeRelation.
    ''' </summary>
    Public Enum RelationType
        ''' <summary>
        ''' 
        ''' </summary>
        ParentChild
        ''' <summary>
        ''' 
        ''' </summary>
        SelfRelation
    End Enum
    ''' <summary>
    ''' Contains the default properties required for generating Relations between objects.
    ''' </summary>
    Public NotInheritable Class NodeRelationDescriptor
        Implements ICloneable(Of NodeRelationDescriptor)
        ''' <summary>
        ''' Initializes a new instance of the NodeRelation.
        ''' </summary>
        Public Sub New()
            Me.nodeConnections = New List(Of ConnectorBase)()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the NodeRelation
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <param name="childSourceName">Name of the child source.</param>
        ''' <param name="childID">The child ID.</param>
        ''' <param name="parentSourceName">Name of the parent source.</param>
        ''' <param name="parentID">The parent ID.</param>
        Public Sub New(ByVal relationName As String, ByVal childSourceName As String, ByVal childID As String, ByVal parentSourceName As String, ByVal parentID As String)
            Me.New()
            Me._relationName = relationName
            Me._parentSourceName = parentSourceName
            Me._parentID = parentID
            Me._childID = childID
            Me._childSourceName = childSourceName
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the NodeRelation
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <param name="childSourceName">Name of the child source.</param>
        ''' <param name="childID">The child ID.</param>
        ''' <param name="parentName">Name of the parent.</param>
        ''' <param name="parentID">The parent ID.</param>
        ''' <param name="relationType">Type of the relation.</param>
        Public Sub New(ByVal relationName As String, ByVal childSourceName As String, ByVal childID As String, ByVal parentName As String, ByVal parentID As String, ByVal relationType As RelationType)
            Me.New(relationName, childSourceName, childID, parentName, parentID)
            Me._relationType = relationType
        End Sub

        Private _relationType As RelationType
        ''' <summary>
        ''' Gets or sets the type of the relation.
        ''' </summary>
        ''' <value>The type of the relation.</value>
        Public Property RelationType() As RelationType
            Get
                Return _relationType
            End Get
            Set(ByVal value As RelationType)
                _relationType = value
            End Set
        End Property

        Private _parentSourceName As String
        ''' <summary>
        ''' Gets or sets the name of the parent object collection / table.
        ''' </summary>
        ''' <value>The name of the parent object collection / table.</value>
        Public Property ParentSourceName() As String
            Get
                Return _parentSourceName
            End Get
            Set(ByVal value As String)
                _parentSourceName = value
            End Set
        End Property

        Private _parentID As String
        ''' <summary>
        ''' Gets or sets the parent ID.
        ''' </summary>
        ''' <value>The parent ID.</value>
        Public Property ParentID() As String
            Get
                Return _parentID
            End Get
            Set(ByVal value As String)
                _parentID = value
            End Set
        End Property

        Private _childSourceName As String
        ''' <summary>
        ''' Gets or sets the name of the child object collection / table.
        ''' </summary>
        ''' <value>The name of the child object collection / table.</value>
        Public Property ChildSourceName() As String
            Get
                Return _childSourceName
            End Get
            Set(ByVal value As String)
                _childSourceName = value
            End Set
        End Property

        Private _childID As String
        ''' <summary>
        ''' Gets or sets the child ID.
        ''' </summary>
        ''' <value>The child ID.</value>
        Public Property ChildID() As String
            Get
                Return _childID
            End Get
            Set(ByVal value As String)
                _childID = value
            End Set
        End Property

        Private _relationName As String
        ''' <summary>
        ''' Gets or sets the name of the relation.
        ''' </summary>
        ''' <value>The name of the relation.</value>
        Public Property RelationName() As String
            Get
                Return _relationName
            End Get
            Set(ByVal value As String)
                _relationName = value
            End Set
        End Property

        ''' <summary>
        ''' Contains the connectors collection info that would be required internally.
        ''' </summary>
        Friend nodeConnections As List(Of ConnectorBase)
        ''' <summary>
        ''' 
        ''' </summary>
        Public Function Clone() As NodeRelationDescriptor Implements ICloneable(Of NodeRelationDescriptor).Clone
            Return New NodeRelationDescriptor(Me._relationName, Me._childSourceName, Me._childID, Me._parentSourceName, Me._parentID, Me._relationType)
        End Function
         
    End Class

    ''' <summary>
    ''' Contains the List of NodeRelation objects
    ''' </summary>
    Public Class NodeRelationCollection
        Implements IList(Of NodeRelationDescriptor), IEnumerable
        ''' <summary>
        ''' Event raised when the NodeRelationCollection is changed.
        ''' </summary>
        Public Event NodeRelationCollectionChanged As NodeRelationCollectionChangedEventHandler

        ''' <summary>
        ''' Event raised when the NodeRelationCollection is changing.
        ''' </summary>
        Public Event NodeRelationCollectionChanging As NodeRelationCollectionChangingEventHandler

        Private nodeRelationColl As List(Of NodeRelationDescriptor)
        Private _diagramEngine As DiagramDataBindingManagerEngine
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeRelationCollection"/>
        ''' </summary>
        Public Sub New(ByVal DiagramDataBindingManager As DiagramDataBindingManagerEngine)
            nodeRelationColl = New List(Of NodeRelationDescriptor)()
            Me._diagramEngine = DiagramDataBindingManager
        End Sub

        ''' <summary>
        ''' Raises the node relation collection changing.
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        ''' <returns></returns>
        Private Function RaiseNodeRelationCollectionChanging(ByVal relationName As String, ByVal collectionChangedType As CollectionChangingType) As Boolean
            Dim nrCancelEvtArgs As New NodeRelationCancelEventArgs(relationName, collectionChangedType)
            RaiseEvent NodeRelationCollectionChanging(Me, nrCancelEvtArgs)
            Return nrCancelEvtArgs.Cancel
        End Function


        ''' <summary>
        ''' Raises the node relation collection changed.
        ''' </summary>
        ''' <param name="relation">Name of the relation.</param>
        ''' <param name="collectionChangedType">Type of the collection changed.</param>
        Private Sub RaiseNodeRelationCollectionChanged(ByVal relation As NodeRelationDescriptor, ByVal collectionChangedType As CollectionChangedType)
            RaiseEvent NodeRelationCollectionChanged(Me, New NodeRelationEventArgs(relation, collectionChangedType))
        End Sub


#Region "IList<NodeRelation> Members"

        ''' <summary>
        ''' Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1"/>.
        ''' </summary>
        ''' <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        ''' <returns>
        ''' The index of <paramref name="item"/> if found in the list; otherwise, -1.
        ''' </returns>
        Public Function IndexOf(ByVal item As NodeRelationDescriptor) As Integer Implements IList(Of NodeRelationDescriptor).IndexOf
            Return nodeRelationColl.IndexOf(item)
        End Function

        ''' <summary>
        ''' Inserts an item to the <see cref="T:System.Collections.Generic.IList`1"/> at the specified index.
        ''' </summary>
        ''' <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
        ''' <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        ''' <exception cref="T:System.ArgumentOutOfRangeException">
        ''' 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        Public Sub Insert(ByVal index As Integer, ByVal item As NodeRelationDescriptor) Implements IList(Of NodeRelationDescriptor).Insert

            If Not RaiseNodeRelationCollectionChanging(item.RelationName, CollectionChangingType.Removing) Then
                nodeRelationColl.Insert(index, item)

                'Raise the CollectionChanged event
                RaiseNodeRelationCollectionChanged(item, CollectionChangedType.Added)
            End If
        End Sub

        ''' <summary>
        ''' Removes the <see cref="T:System.Collections.Generic.IList`1"/> item at the specified index.
        ''' </summary>
        ''' <param name="index">The zero-based index of the item to remove.</param>
        ''' <exception cref="T:System.ArgumentOutOfRangeException">
        ''' 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        Public Sub RemoveAt(ByVal index As Integer) Implements IList(Of NodeRelationDescriptor).RemoveAt
            If index > -1 AndAlso index < nodeRelationColl.Count Then
                Remove(Me(index))
            End If
        End Sub

        ''' <summary>
        ''' Gets or sets the Syncfusion.Windows.Forms.Diagram.DataBinding.NodeRelationDescriptor at the specified index.
        ''' </summary>
        ''' <value></value>
        Default Public Property Item(ByVal index As Integer) As NodeRelationDescriptor Implements System.Collections.Generic.IList(Of NodeRelationDescriptor).Item
            Get
                If index > -1 Then
                    Return Me.nodeRelationColl(index)
                End If
                Return Nothing
            End Get
            Set(ByVal value As NodeRelationDescriptor)
                If index > -1 AndAlso index < nodeRelationColl.Count Then
                    If Not RaiseNodeRelationCollectionChanging(Me(index).RelationName, CollectionChangingType.Modifying) Then
                        Me.nodeRelationColl(index) = value

                        'Raise the Event when the collection is modified
                        Me.RaiseNodeRelationCollectionChanged(Me.nodeRelationColl(index), CollectionChangedType.Modified)
                    End If
                Else
                    Throw New System.ArgumentException("Invalid index")
                End If
            End Set
        End Property


        ''' <summary>
        ''' Gets or sets the Syncfusion.Windows.Forms.Diagram.DataBinding.NodeRelationDescriptor with the specified relation name.
        ''' </summary>
        ''' <value></value>
        Default Public Property Item(ByVal relationName As String) As NodeRelationDescriptor
            Get
                Dim index As Integer = GetIndexOfNodeRelation(relationName)
                If index <> -1 Then
                    Return Me.nodeRelationColl(index)
                End If
                Return Nothing
            End Get
            Set(ByVal value As NodeRelationDescriptor)
                Dim index As Integer = GetIndexOfNodeRelation(relationName)
                If index <> -1 AndAlso index < Me.nodeRelationColl.Count Then
                    If Not RaiseNodeRelationCollectionChanging(relationName, CollectionChangingType.Modifying) Then
                        Me.nodeRelationColl(index) = value

                        'Raise the Event when the collection is modified
                        Me.RaiseNodeRelationCollectionChanged(Me(relationName), CollectionChangedType.Modified)
                    End If
                Else
                    Throw New System.ArgumentException("Invalid RelationName")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets the index of node relation.
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <returns></returns>
        Private Function GetIndexOfNodeRelation(ByVal relationName As String) As Integer
            Dim index As Integer = -1
            For i As Integer = 0 To nodeRelationColl.Count - 1
                Dim item As NodeRelationDescriptor = Me.nodeRelationColl(i)
                If item.RelationName = relationName Then
                    index = i
                    Exit For
                End If
            Next i
            Return index
        End Function

#End Region

#Region "ICollection<NodeRelation> Members"

        ''' <summary>
        ''' Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        Public Sub Add(ByVal item As NodeRelationDescriptor) Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).Add
            If CheckSourceListSetSourceNameIsPresent(item.ChildSourceName) AndAlso CheckSourceListSetSourceNameIsPresent(item.ParentSourceName) Then
                If Not RaiseNodeRelationCollectionChanging(item.RelationName, CollectionChangingType.Adding) Then
                    Me.nodeRelationColl.Add(item)

                    'Raise the CollectionChanged event
                    RaiseNodeRelationCollectionChanged(item, CollectionChangedType.Added)
                End If
            Else
                Throw New System.ArgumentException("The sourcename specified in ChildSourceName or ParentSourceName is not proper in the NodeRelation - " & item.RelationName)
            End If
        End Sub

        ''' <summary>
        ''' Adds the specified relation name.
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <param name="parentName">Name of the parent.</param>
        ''' <param name="parentID">The parent ID.</param>
        ''' <param name="childName">Name of the child.</param>
        ''' <param name="childID">The child ID.</param>
        Public Sub Add(ByVal relationName As String, ByVal parentName As String, ByVal parentID As String, ByVal childName As String, ByVal childID As String)
            Me.Add(New NodeRelationDescriptor(relationName, childName, childID, parentName, parentID))
        End Sub

        ''' <summary>
        ''' Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only. </exception>
        Public Sub Clear() Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).Clear
            For Each item As NodeRelationDescriptor In nodeRelationColl
                item.nodeConnections.Clear()
            Next item
            nodeRelationColl.Clear()
        End Sub

        ''' <summary>
        ''' Determines whether the <see cref="T:System.Collections.Generic.ICollection`1"/> contains a specific value.
        ''' </summary>
        ''' <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        ''' <returns>
        ''' true if <paramref name="item"/> is found in the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false.
        ''' </returns>
        Public Function Contains(ByVal item As NodeRelationDescriptor) As Boolean Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).Contains
            Return nodeRelationColl.Contains(item)
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
        Public Sub CopyTo(ByVal array() As NodeRelationDescriptor, ByVal arrayIndex As Integer) Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).CopyTo
            nodeRelationColl.CopyTo(array, arrayIndex)
        End Sub

        ''' <summary>
        ''' Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        ''' </summary>
        ''' <value></value>
        ''' <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</returns>
        Public ReadOnly Property Count() As Integer Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).Count
            Get
                Return nodeRelationColl.Count
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
        ''' </summary>
        ''' <value></value>
        ''' <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only; otherwise, false.</returns>
        Public ReadOnly Property IsReadOnly() As Boolean Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).IsReadOnly
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
        Public Function Remove(ByVal item As NodeRelationDescriptor) As Boolean Implements System.Collections.Generic.ICollection(Of NodeRelationDescriptor).Remove
            Dim result As Boolean = False

            If nodeRelationColl.Contains(item) AndAlso (Not RaiseNodeRelationCollectionChanging(item.RelationName, CollectionChangingType.Removing)) Then

                Me._diagramEngine.Diagram.BeginUpdate()
                For Each connector As ConnectorBase In item.nodeConnections
                    'Me._diagramEngine.Diagram.Model.RemoveChild(connector)
                Next connector
                Me._diagramEngine.Diagram.EndUpdate()

                item.nodeConnections.Clear()
                'Clone the NodeRelation object to be passed in the Event.
                Dim tNodeRelation As NodeRelationDescriptor = item.Clone()
                result = nodeRelationColl.Remove(item)
                'Raises the CollectionChanged event when the NodeRelation is removed
                Me.RaiseNodeRelationCollectionChanged(tNodeRelation, CollectionChangedType.Removed)
            Else
                Throw New System.ArgumentException("Specified NodeRelation is not present")
            End If

            Return result
        End Function

        ''' <summary>
        ''' Removes the specified relation name.
        ''' </summary>
        ''' <param name="relationName">Name of the relation.</param>
        ''' <returns></returns>
        Public Function Remove(ByVal relationName As String) As Boolean
            Return Remove(Me(relationName))
        End Function

#End Region

#Region "IEnumerable<NodeRelation> Members"

        ''' <summary>
        ''' Returns an enumerator that iterates through the collection.
        ''' </summary>
        ''' <returns>
        ''' A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        ''' </returns>
        Public Function GetEnumerator() As IEnumerator(Of NodeRelationDescriptor) Implements System.Collections.Generic.IEnumerable(Of NodeRelationDescriptor).GetEnumerator
            Return nodeRelationColl.GetEnumerator()
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
            Return nodeRelationColl.GetEnumerator()
        End Function

#End Region

        Private Function CheckSourceListSetSourceNameIsPresent(ByVal childSourceName As String) As Boolean
            Dim result As Boolean = False
            For Each source As SourceListSetEntry In Me._diagramEngine.SourceListSet
                If source.SourceName = childSourceName Then
                    result = True
                    Exit For
                End If
            Next source
            Return result
        End Function

    End Class
End Namespace