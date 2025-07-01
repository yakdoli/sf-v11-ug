#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System

Namespace CustomGridCell

    <Serializable()> _
    Public Class SampleData
        Private _count As Integer
        Private _indentLevel As Integer
        Private _items() As String
        Private _state As Integer
        'Fields
        'Constructors
        'Methods
        Public Sub New(ByVal indentLevel As Integer, ByVal expandstate As Integer, ByVal item1 As String, ByVal item2 As String, ByVal item3 As String, ByVal item4 As String)
            MyBase.New()
            _count = 4
            _items = New String(_count - 1) {}
            _items(0) = item1
            _items(1) = item2
            _items(2) = item3
            _items(3) = item4
            _indentLevel = indentLevel
            _state = expandstate

        End Sub
        Public Property Items() As String()
            Get

                If (_items Is Nothing) Then
                    _items = New String(_count - 1) {}
                End If
                Return _items

            End Get
            Set(ByVal Value() As String)

                _items = Value

            End Set
        End Property
        Public Property IndentLevel() As Integer
            Get

                Return _indentLevel

            End Get
            Set(ByVal Value As Integer)

                _indentLevel = Value

            End Set
        End Property
        Public ReadOnly Property ItemCount() As Integer
            Get

                Return _count

            End Get
        End Property
        Public Property ExpandState() As Integer
            Get

                Return _state

            End Get
            Set(ByVal Value As Integer)

                _state = Value

            End Set
        End Property
    End Class
End Namespace
