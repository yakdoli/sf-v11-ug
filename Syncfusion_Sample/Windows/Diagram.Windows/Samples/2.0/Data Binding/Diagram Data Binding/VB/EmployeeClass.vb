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
    <NodeType(Dimensions:=New Single() {100, 100, 100, 65}, NodeType:=GetType(Rectangle))> _
 Public Class EmployeeClass
        Private empName As String
        <NodeAttribute(VisibilityType:=VisibleType.Label)> _
        Public Property EmployeeName() As String
            Get
                Return empName
            End Get
            Set(ByVal value As String)
                empName = value
            End Set
        End Property

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

        'INSTANT VB NOTE: The variable managerId was renamed since Visual Basic does not allow class members with the same name:
        Private managerId_Renamed As Integer
        Public Property ManagerId() As Integer
            Get
                Return managerId_Renamed
            End Get
            Set(ByVal value As Integer)
                managerId_Renamed = value
            End Set
        End Property

        Public Sub New(ByVal id As Integer, ByVal managerId As Integer, ByVal name As String)
            Me.id_Renamed = id
            Me.managerId_Renamed = managerId
            Me.empName = name
        End Sub

    End Class
End Namespace
