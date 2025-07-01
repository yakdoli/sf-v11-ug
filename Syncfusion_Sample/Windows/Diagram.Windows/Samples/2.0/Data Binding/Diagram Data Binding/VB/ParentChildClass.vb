Imports Microsoft.VisualBasic
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
Imports Syncfusion.Windows.Forms.Diagram
Imports DiagramDBiManager.DataBinding

Namespace DiagramORM.Sample
    <NodeType(Dimensions:=New Single() {100, 100, 100, 75}, NodeType:=GetType(Rectangle))> _
 Public Class ParentChildClass
        'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
        Private id_Renamed As Integer

        Public Property Id() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                id_Renamed = value
            End Set
        End Property

        'INSTANT VB NOTE: The variable parentId was renamed since Visual Basic does not allow class members with the same name:
        Private parentId_Renamed As Integer

        Public Property ParentId() As Integer
            Get
                Return parentId_Renamed
            End Get
            Set(ByVal value As Integer)
                parentId_Renamed = value
            End Set
        End Property

        'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
        Private name_Renamed As String

        <NodeAttribute(VisibilityType:=VisibleType.Label)> _
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = value
            End Set
        End Property

        Public Sub New(ByVal id As Integer, ByVal parentId As Integer, ByVal name As String)
            Me.id_Renamed = id
            Me.parentId_Renamed = parentId
            Me.name_Renamed = name
        End Sub
    End Class
End Namespace
