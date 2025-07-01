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
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Imports System.Collections

Namespace DataBinding
    ''' <summary>
    ''' Defines the Reflection implementation for retrieving the Node info from the Class attributes. 
    ''' </summary>
    ''' <remarks>
    ''' Loads the Node parameters identified thru reflection. By default, it will look for the Class with NodeType attributes defined. If the classes are defined in some other assembly, call the BuildUp() function to load those into the DiagramDataBindingManager.
    ''' </remarks>
    Public Class NodeReflectionStrategy
        Inherits ReflectionStrategy(Of NodeClassInfo)
        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeReflectionStrategy"/>
        ''' </summary>
        Public Sub New()
            _reflectionInfoCollection = New List(Of NodeClassInfo)()
        End Sub

#Region "BuildUp"

        ''' <summary>
        ''' Builds up the Reflection info that would be used for getting the Node attribute's information.
        ''' </summary>
        Public Overrides Sub BuildUp(ByVal [assembly] As System.Reflection.Assembly)
            For Each classType As Type In GetNodeType([assembly])
                Dim nodePropInfoColl As New List(Of NodePropInfo)()
                For Each pInfo As PropertyInfo In GetNodeAttributePropertyInfo(classType)
                    nodePropInfoColl.Add(New NodePropInfo(pInfo.Name, pInfo))
                Next pInfo
                _reflectionInfoCollection.Add(New NodeClassInfo(classType.Name, classType, nodePropInfoColl))
            Next classType
        End Sub

        ''' <summary>
        ''' Gets the type of the node.
        ''' </summary>
        ''' <returns></returns>
        Private Function GetNodeType(ByVal [assembly] As System.Reflection.Assembly) As IEnumerable(Of Type)
            Dim tlist As List(Of Type) = New List(Of Type)
            If [assembly] IsNot Nothing Then
                Dim types() As Type = [assembly].GetTypes()
                For Each t As Type In types
                    If Attribute.GetCustomAttribute(t, GetType(NodeTypeAttribute)) IsNot Nothing Then
                        tlist.Add(t)
                    End If
                Next t
            End If
            Return tlist
        End Function

        ''' <summary>
        ''' Gets the node attribute property info.
        ''' </summary>
        ''' <param name="nodeType">Type of the node.</param>
        ''' <returns></returns>
        Private Function GetNodeAttributePropertyInfo(ByVal nodeType As Type) As IEnumerable(Of PropertyInfo)
            Dim pinfolist As List(Of PropertyInfo) = New List(Of PropertyInfo)
            For Each pInfo As PropertyInfo In nodeType.GetProperties()
                If Attribute.GetCustomAttribute(pInfo, GetType(NodeAttributeAttribute)) IsNot Nothing Then
                    pinfolist.Add(pInfo)
                End If
            Next pInfo
            Return pinfolist
        End Function

#End Region

        ''' <summary>
        ''' Clears up the memory.
        ''' </summary>
        Public Overrides Sub TearDown()
            _reflectionInfoCollection.Clear()
        End Sub

        Private Shared _reflectionInfoCollection As List(Of NodeClassInfo)
        ''' <summary>
        ''' Gets or sets the reflection info collection.
        ''' </summary>
        ''' <value>The reflection info collection.</value>
        Public Shared ReadOnly Property ReflectionInfoCollection() As List(Of NodeClassInfo)
            Get
                Return _reflectionInfoCollection
            End Get
        End Property

        ''' <summary>
        ''' Gets the node object.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <returns></returns>
        Friend Shared Function IterateListSource(ByVal item As SourceListSetEntry) As IEnumerable(Of Object)
            Dim objectlist As List(Of Object) = New List(Of Object)
            Dim pInfo As PropertyInfo = CType(item.Source, Object).GetType().GetProperty("Item")
            Dim i As Integer = 0
            For Each o As Object In item.Source
                objectlist.Add(pInfo.GetValue(item.Source, New Object() {i}))
                i += 1
            Next o
            Return objectlist
        End Function

        ''' <summary>
        ''' Gets the item at 'i' for the IList object.
        ''' </summary>        
        ''' <param name="list">The list.</param>
        ''' <param name="i">ith location.</param>
        ''' <returns></returns>
        Public Shared Function GetItemAt(ByVal list As IList, ByVal i As Integer) As Object
            Return CType(list, Object).GetType().GetProperty("Item").GetValue(list, New Object() {i})
        End Function

        ''' <summary>
        ''' Gets the node class info.
        ''' </summary>
        ''' <param name="item">The item.</param>
        ''' <returns></returns>
        Friend Shared Function GetNodeClassInfo(ByVal item As Object) As NodeClassInfo
            Dim nInfo As NodeClassInfo = Nothing
            For i As Integer = 0 To _reflectionInfoCollection.Count - 1
                If _reflectionInfoCollection(i).ClassType.Name = item.GetType().Name Then
                    nInfo = _reflectionInfoCollection(i)
                End If
            Next i
            Return nInfo
        End Function


    End Class
End Namespace