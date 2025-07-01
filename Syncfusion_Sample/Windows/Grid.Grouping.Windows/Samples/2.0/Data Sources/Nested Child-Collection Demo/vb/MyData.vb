#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace RecursiveNestedCollection
    Public Class MyData
        Private field1_Renamed As String = ""
        Private field2_Renamed As String = ""
        Private name_Renamed As String
        Private value_Renamed As String

        'INSTANT VB NOTE: The parameter name was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter value was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        Public Sub New(ByVal name_Renamed As String, ByVal value_Renamed As String)
            Me.name_Renamed = name_Renamed
            Me.value_Renamed = value_Renamed
        End Sub

        Public Property Field1() As String
            Get
                Return field1_Renamed
            End Get
            Set(ByVal value As String)
                field1_Renamed = Value
            End Set
        End Property

        Public Property Field2() As String
            Get
                Return field2_Renamed
            End Get
            Set(ByVal value As String)
                field2_Renamed = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = Value
            End Set
        End Property

        Public Property Value() As String
            Get
                Return Me.value_Renamed
            End Get
            Set(ByVal value As String)
                Me.value_Renamed = Value
            End Set
        End Property
    End Class
End Namespace
