#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Collections
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Reflection
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace DataBinding
    ''' <summary>
    ''' Contains the Node related objects that is used along with the SourceListSet to ide
    ''' </summary>
    Public NotInheritable Class NodeInfo
        Private _nodeObject As Node
        ''' <summary>
        ''' Gets or sets the node object.
        ''' </summary>
        ''' <value>The node object.</value>
        Public Property NodeObject() As Node
            Get
                Return _nodeObject
            End Get
            Set(ByVal value As Node)
                _nodeObject = value
            End Set
        End Property

        Private _classType As Type
        ''' <summary>
        ''' Gets or sets the type of the class.
        ''' </summary>
        ''' <value>The type of the class.</value>
        Public Property ClassType() As Type
            Get
                Return _classType
            End Get
            Set(ByVal value As Type)
                _classType = value
            End Set
        End Property

        Private _objectInstance As Object
        ''' <summary>
        ''' Gets or sets the object instance.
        ''' </summary>
        ''' <value>The object instance.</value>
        Public Property ObjectInstance() As Object
            Get
                Return _objectInstance
            End Get
            Set(ByVal value As Object)
                _objectInstance = value
            End Set
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="NodeInfo"/> [ERROR: invalid expression DeclaringTypeKind].
        ''' </summary>
        ''' <param name="classType">Type of the class.</param>
        ''' <param name="nodeObject">The node object.</param>
        ''' <param name="objectInstance">The object instance.</param>
        Public Sub New(ByVal classType As Type, ByVal nodeObject As Node, ByVal objectInstance As Object)
            Me._classType = classType
            Me._nodeObject = nodeObject
            Me._objectInstance = objectInstance
        End Sub

    End Class

    ''' <summary>
    ''' Contains the instance of IList source and its Identity name.
    ''' </summary>
    Public Class SourceListSetEntry
        Implements ISourceListSetEntry, ICloneable(Of SourceListSetEntry)
        ''' <summary>
        ''' Initializes a new instance of the SourceListSetEntry
        ''' </summary>
        Public Sub New()
            nodeInfoCollection = New List(Of NodeInfo)()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the SourceListSetEntry
        ''' </summary>
        ''' <param name="sourceName">Name of the source.</param>
        ''' <param name="source">The source.</param>
        Public Sub New(ByVal sourceName As String, ByVal source As IList)
            Me.New()
            Me._sourceName = sourceName
            Me._innerList = source
        End Sub

        Private _sourceName As String
        ''' <summary>
        ''' Gets or sets the name of the source. It would be the Table name.
        ''' </summary>
        ''' <value>The name of the source.</value>
        Public Property SourceName() As String Implements ISourceListSetEntry.SourceName
            Get
                Return _sourceName
            End Get
            Set(ByVal value As String)
                _sourceName = value
            End Set
        End Property

        Private _innerList As IList
        ''' <summary>
        ''' Gets or sets the source. Its the IList associated with the source.
        ''' </summary>
        ''' <value>source value.</value>
        Public Property Source() As IList Implements ISourceListSetEntry.Source
            Get
                Return _innerList
            End Get
            Set(ByVal value As IList)
                _innerList = value
            End Set
        End Property

        ''' <summary>
        ''' NodeInfo collection that holds the Node related information related to the IList source present in this instance.
        ''' </summary>
        Protected Friend nodeInfoCollection As List(Of NodeInfo)

#If Syncfusion3_5 Then

		''' <summary>
		''' Gets the NodeCollection.
		''' </summary>
		Public ReadOnly Property NodeCollection() As List(Of NodeInfo)
			Get
				Return nodeInfoCollection
			End Get
		End Property
#End If

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function Clone() As SourceListSetEntry Implements ICloneable(Of SourceListSetEntry).Clone
            Return New SourceListSetEntry(Me.SourceName, Me.Source)
        End Function

    End Class
End Namespace